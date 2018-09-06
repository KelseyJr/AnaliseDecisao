using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaliseDecisao3.View {
    public partial class frmAnaliseDecisao : Form {

        int QuantidadeColunas;
        int QuantidadeLinhas;
        decimal[] Porcentagem;
        int[] InvestimentoIncerteza;
        decimal[] MenorArrependimentoIncerteza;
        decimal[] MenorArrependimentoRisco;

        public frmAnaliseDecisao(int Colunas, int Linhas){
            InitializeComponent();
            QuantidadeColunas = Colunas;
            QuantidadeLinhas = Linhas;
            MenorArrependimentoIncerteza = new decimal[Linhas];
            InvestimentoIncerteza = new int[Linhas];
            MenorArrependimentoRisco = new decimal[Linhas];
            Porcentagem = new decimal[Colunas];
            for (int i = 0; i < Porcentagem.Length; i++) {
                Porcentagem[i] = 0;
            }
        }

        private void frmAnaliseDecisao_Load(object sender, EventArgs e){
            dgvInvestimentoCenario.ColumnCount = QuantidadeColunas + 1;
            dgvIncertezaArrependimento.ColumnCount = QuantidadeColunas + 1;
            dgvPerdaEsperadaPonderada.ColumnCount = QuantidadeColunas + 1;
            

            PreencherColunas(QuantidadeColunas);
            PreencherLinhas(QuantidadeLinhas);
            AjustarPesoELarguraGridInvestimentoCenario();

            dgvInvestimentoCenario.Columns[0].ReadOnly = true;
            dgvInvestimentoCenario.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvInvestimentoCenario.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInvestimentoCenario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvIncertezaArrependimento.Columns[0].ReadOnly = true;
            dgvIncertezaArrependimento.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvIncertezaArrependimento.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvIncertezaArrependimento.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPerdaEsperadaPonderada.Columns[0].ReadOnly = true;
            dgvPerdaEsperadaPonderada.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPerdaEsperadaPonderada.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPerdaEsperadaPonderada.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            lblMaxVME.Text = "";
            lblVEIP.Text = "";
        }


        #region "Grid Principal"

        private void AjustarPesoELarguraGridInvestimentoCenario() {
            int LarguraTotal = dgvInvestimentoCenario.RowHeadersWidth;
            int PesoTotal = dgvInvestimentoCenario.ColumnHeadersHeight;

            foreach (DataGridViewColumn Linha in dgvInvestimentoCenario.Columns) {
                LarguraTotal += Linha.Width;
            }

            foreach (DataGridViewRow Linha in dgvInvestimentoCenario.Rows) {
                PesoTotal += Linha.Height;
            }

            LarguraTotal = LarguraTotal > 744 ? LarguraTotal = 744 : LarguraTotal;
            PesoTotal = PesoTotal > 142 ? PesoTotal = 142 : PesoTotal;

            dgvInvestimentoCenario.ClientSize = new Size(LarguraTotal + 2, PesoTotal + 2);
        }

        private void dgvInvestimentoCenario_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            decimal TotalPorcentagem = Porcentagem.Sum();
            using (frmPorcentagemAnaliseDecisao FrmPorcentagemAnaliseDecisao = new frmPorcentagemAnaliseDecisao(TotalPorcentagem)) {
                decimal NovaPorcentagem = FrmPorcentagemAnaliseDecisao.RetornaPorcentagem();
                if (NovaPorcentagem > 0) {
                    this.dgvInvestimentoCenario.Columns[e.ColumnIndex].HeaderText = "Cenário " + e.ColumnIndex + ": " + NovaPorcentagem + "%";
                    Porcentagem[e.ColumnIndex -1] = NovaPorcentagem;
                }
            }
            ExecutaFuncoes();
        }

        private void dgvInvestimentoCenario_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            ExecutaFuncoes();
        }

        #endregion


        #region "Incerteza"

        private void CalcularValoresTabelaIncerteza(decimal[,] matrizValoresLinha) {

            for (int i = 0; i < matrizValoresLinha.GetLength(0); i++) {
                // Pega todos os valores da linha e transforma em um Array
                var Array = (from col in Enumerable.Range(0, matrizValoresLinha.GetLength(1))
                             select matrizValoresLinha[i, col]).ToArray();

                
                decimal Maximax = Convert.ToDecimal(Array.Max());
                decimal Maximin = Convert.ToDecimal(Array.Min());
                decimal Laplace = CalcularLaplace(Array);
                decimal Huswicz = CalcularHuscwizVME(Array);

                // Insere na tabela os valores
                dgvIncerteza.Rows[i].Cells[1].Value = Maximax;
                dgvIncerteza.Rows[i].Cells[2].Value = Maximin;
                dgvIncerteza.Rows[i].Cells[3].Value = Laplace;
                dgvIncerteza.Rows[i].Cells[4].Value = Huswicz;
            }
        }

        private decimal CalcularLaplace(decimal[] arrayValores) {
            // Método para calcular Laplace
            return Convert.ToDecimal(arrayValores.Sum()) / arrayValores.Length;
        }

        private decimal[,] ObterArrayValoresIncerteza() {
            // Matriz para obter todos os dados da tabela que contém o MaxiMax, MaxiMin, Laplace e Huswicz
            decimal[,] ArrayValores = new decimal[QuantidadeLinhas, 4];
            int linha = 0;

            // Para cada linha da tabela
            foreach (DataGridViewRow Linha in dgvIncerteza.Rows) {
                // Recebe os valores da posição e o insere dentro da Matriz
                for (int i = 0; i < 4; i++) {
                    ArrayValores[linha, i] = Linha.Cells[i + 1].Value == null ? 0 : Convert.ToDecimal(Linha.Cells[i + 1].Value);
                }
                linha++;
            }
            return ArrayValores;
        }

        private void MelhorInvestimentoTabelaIncerteza(decimal[,] matrizValores) {

            for (int i = 0; i < 4; i++) {
                // Obtém os valores de cada coluna e transforma em um Array
                var Array = (from row in Enumerable.Range(0, matrizValores.GetLength(0))
                             select matrizValores[row, i]).ToArray();

                //Maior valor do array
                decimal MaiorValor = Array.Max();
                // index do maior valor do array
                int Index = Array.ToList().IndexOf(MaiorValor);
                // Incremento no array da posição do maior valor
                InvestimentoIncerteza[Index] += 1;
                // Pinta a célula que contém o maior valor
                dgvIncerteza.Rows[Index].Cells[i + 1].Style.BackColor = Color.Red;
            }
            //Obtém o maior valor do array
            int MelhorValorInvestimento = InvestimentoIncerteza.Max();
            // index do maior valor do array
            int IndexMelhorInvestimento = InvestimentoIncerteza.ToList().IndexOf(MelhorValorInvestimento);
            // Pinta a linha grid Principal
            dgvInvestimentoCenario.Rows[IndexMelhorInvestimento].DefaultCellStyle.BackColor = Color.Red;

        }

        private void AlterarArrependimentoIncerteza(decimal[,] matrizValores) {
            decimal MaxVME = 0;
            for (int i = 0; i < QuantidadeColunas; i++) {

                decimal MaiorValor = ObterMaiorValorColunaPrincipal(i, matrizValores);

                for (int k = 0; k < QuantidadeLinhas; k++) {
                    dgvIncertezaArrependimento.Rows[k].Cells[i + 1].Value = MaiorValor - (Convert.ToDecimal(dgvInvestimentoCenario.Rows[k].Cells[i + 1].Value));
                }

                MaxVME += MaiorValor * (Porcentagem[i] / 100);
            }
            lblMaxVME.Text = Convert.ToString(MaxVME);
        }

        private decimal[,] ObterMatrizValoresMinimoArrependimentoIncerteza() {
            decimal[,] ArrayValores = new decimal[QuantidadeLinhas, QuantidadeColunas];
            int linha = 0;
            foreach (DataGridViewRow Linha in dgvIncertezaArrependimento.Rows) {
                for (int i = 0; i < QuantidadeColunas; i++) {
                    ArrayValores[linha, i] = Linha.Cells[i + 1].Value == null ? 0 : Convert.ToDecimal(Linha.Cells[i + 1].Value);
                }
                linha++;
            }
            return ArrayValores;
        }

        private void ColorirLinhaMinimoArrependimentoTabelaIncerteza(decimal[,] matrizValores) {
            for (int i = 0; i < matrizValores.GetLength(0); i++) {
                var Array = (from col in Enumerable.Range(0, matrizValores.GetLength(1))
                             select matrizValores[i, col]).ToArray();
                MenorArrependimentoIncerteza[i] += Convert.ToDecimal(Array.Max());
            }
            decimal MenorValor = MenorArrependimentoIncerteza.Min();
            int Index = MenorArrependimentoIncerteza.ToList().IndexOf(MenorValor);
            dgvIncertezaArrependimento.Rows[Index].DefaultCellStyle.BackColor = Color.Red;
        }


        #endregion






        #region "Risco"
        
        private void CalcularVME(decimal[,] matrizValoresLinha) {
            for (int i = 0; i < QuantidadeLinhas; i++) {
                var Array = (from col in Enumerable.Range(0, matrizValoresLinha.GetLength(1))
                             select matrizValoresLinha[i, col]).ToArray();

                decimal VME = CalcularHuscwizVME(Array);
                dgvVMERisco.Rows[i].Cells[1].Value = VME;
            }
        }

        private decimal[] ObterArrayValoresRisco() {
            decimal[] ArrayValores = new decimal[QuantidadeLinhas];
            for (int i = 0; i < QuantidadeLinhas; i++) {
                ArrayValores[i] = dgvVMERisco.Rows[i].Cells[1].Value == null ? 0 : Convert.ToDecimal(dgvVMERisco.Rows[i].Cells[1].Value);
            }

            return ArrayValores;
        }

        private void CalcularPerdaEsperadaPonderada(decimal[,] matrizValores) {
            for (int i = 0; i < QuantidadeColunas; i++) {
                decimal MaiorValor = ObterMaiorValorColunaPrincipal(i, matrizValores);

                for (int k = 0; k < QuantidadeLinhas; k++) {
                    dgvPerdaEsperadaPonderada.Rows[k].Cells[i + 1].Value = MaiorValor - (Convert.ToDecimal(dgvInvestimentoCenario.Rows[k].Cells[i + 1].Value));
                }
            }
        }

        private void CalcularVEIP() {
            decimal MaxVME = Convert.ToDecimal(lblMaxVME.Text);
            decimal MaiorVME = Convert.ToDecimal(dgvVMERisco.Rows.Cast<DataGridViewRow>().Max(r => r.Cells[1].Value));
            lblVEIP.Text = Convert.ToString(MaxVME - MaiorVME);
        }

        private void MelhorInvestimentoRisco(decimal[] matrizValores) {
            decimal MelhorValorInvestimento = matrizValores.ToList().Max();
            int IndexMelhorInvestimento = matrizValores.ToList().IndexOf(MelhorValorInvestimento);
            if (dgvInvestimentoCenario.Rows[IndexMelhorInvestimento].DefaultCellStyle.BackColor == Color.Red) {
                dgvInvestimentoCenario.Rows[IndexMelhorInvestimento].DefaultCellStyle.BackColor = Color.Green;
            } else {
                dgvInvestimentoCenario.Rows[IndexMelhorInvestimento].DefaultCellStyle.BackColor = Color.Blue;
            }

            dgvVMERisco.Rows[IndexMelhorInvestimento].DefaultCellStyle.BackColor = Color.Blue;
        }

        private decimal[,] ObterArrayMenorArrependimentoRisco() {
            decimal[,] ArrayValores = new decimal[QuantidadeLinhas, QuantidadeColunas];
            int linha = 0;
            foreach (DataGridViewRow Linha in dgvPerdaEsperadaPonderada.Rows) {
                for (int i = 0; i < QuantidadeColunas; i++) {
                    ArrayValores[linha, i] = Linha.Cells[i+1].Value == null ? 0 : Convert.ToDecimal(Linha.Cells[i+1].Value);
                }
                linha++;
            }
            return ArrayValores;
        }

        private int CustoMedioOportunidade(decimal [,] matrizValores) { 
            decimal[] Oportunidade = new decimal[QuantidadeLinhas];
            decimal Soma = 0;
            for (int i = 0; i < matrizValores.GetLength(0); i++) {
                Soma = 0;
                var Array = (from col in Enumerable.Range(0, matrizValores.GetLength(1))
                             select matrizValores[i, col]).ToArray();
                for (int j = 0; j < Array.Length; j++) {
                    Soma += Array[j] * (Porcentagem[j] / 100);
                }
                Oportunidade[i] = Soma;
            }
            decimal MenorValor = Oportunidade.ToArray().Min();
            int Index = Oportunidade.ToList().IndexOf(MenorValor);
            return Index;
        }

        private void PintarMenorArrependimentoRisco(int posicao) {
            dgvPerdaEsperadaPonderada.Rows[posicao].DefaultCellStyle.BackColor = Color.Blue;
        }

        #endregion

        #region "Util"

        private void DescolorirGrid() {
            foreach (DataGridViewRow Linha in dgvInvestimentoCenario.Rows) {
                Linha.DefaultCellStyle.BackColor = default(Color);
            }

            foreach (DataGridViewRow  Linha in dgvIncerteza.Rows) {
                for (int i = 0; i < dgvIncerteza.Columns.Count; i++) {
                    Linha.Cells[i].Style.BackColor = default(Color);
                }                   
            }

            foreach (DataGridViewRow Linha in dgvVMERisco.Rows) {
                Linha.DefaultCellStyle.BackColor = default(Color);
            }

            foreach (DataGridViewRow Linha in dgvIncertezaArrependimento.Rows) {
                Linha.DefaultCellStyle.BackColor = default(Color);
            }

            foreach (DataGridViewRow Linha in dgvPerdaEsperadaPonderada.Rows) {
                Linha.DefaultCellStyle.BackColor = default(Color);
            }
        }

        private decimal ObterMaiorValorColunaPrincipal(int posicao, decimal[,] matrizValores) {
            var Array = (from row in Enumerable.Range(0, matrizValores.GetLength(0))
                         select matrizValores[row, posicao]).ToArray();

            return Convert.ToDecimal(Array.Max());
        }

        private void PreencherLinhas(int quantidadeLinhas) {
            ArrayList Row;

            for (int i = 0; i < quantidadeLinhas; i++) {
                Row = new ArrayList();
                Row.Add("Investimento " + (i + 1));
                dgvInvestimentoCenario.Rows.Add(Row.ToArray());
                dgvIncerteza.Rows.Add(Row.ToArray());
                dgvIncertezaArrependimento.Rows.Add(Row.ToArray());
                dgvVMERisco.Rows.Add(Row.ToArray());
                dgvPerdaEsperadaPonderada.Rows.Add(Row.ToArray());
            }
        }

        private void PreencherColunas(int quantidadeColunas) {
            for (int i = 1; i <= quantidadeColunas; i++) {
                dgvInvestimentoCenario.Columns[i].HeaderText = "Cenário " + i;
                dgvInvestimentoCenario.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgvIncertezaArrependimento.Columns[i].HeaderText = "Cenário " + i;
                dgvIncertezaArrependimento.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgvPerdaEsperadaPonderada.Columns[i].HeaderText = "Cenário " + i;
                dgvPerdaEsperadaPonderada.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;              
            }
        }

        private decimal CalcularHuscwizVME(decimal[] linha) {
            decimal ValorHuscwizVME = 0;
            for (int i = 0; i < linha.Length; i++) {
                ValorHuscwizVME += Porcentagem[i] == 0 ? 0 : linha[i] * (Porcentagem[i] / 100);
            }
            return ValorHuscwizVME;
        }

        private decimal[ , ] ObterValoresTabelaPrincipal() {
            decimal[ , ] ArrayValores = new decimal[QuantidadeLinhas, QuantidadeColunas];
            int linha = 0;
            foreach (DataGridViewRow Linha in dgvInvestimentoCenario.Rows) {
                for (int i = 1; i <= QuantidadeColunas; i++) {
                    ArrayValores[linha, i - 1] = Linha.Cells[i].Value == null ? 0 : Convert.ToDecimal(Linha.Cells[i].Value);
                }
                linha++;
            }
            return ArrayValores;
        }

        private void ZerarArrays() {
            for (int i = 0; i < QuantidadeLinhas; i++) {
                MenorArrependimentoRisco[i] = 0;
                InvestimentoIncerteza[i] = 0;
                MenorArrependimentoIncerteza[i] = 0;
            }
        }

        #endregion

        private void ExecutaFuncoes() {

            decimal[,] ArrayValores = ObterValoresTabelaPrincipal();
            DescolorirGrid();
            ZerarArrays();

            // Métodos Relacionados a Análise de Incerteza
            CalcularValoresTabelaIncerteza(ArrayValores);
            AlterarArrependimentoIncerteza(ArrayValores);

            decimal[,] ArrayValoresIncerteza = ObterArrayValoresIncerteza();
            MelhorInvestimentoTabelaIncerteza(ArrayValoresIncerteza);

            decimal[,] MinimoArrependimentoIncerteza = ObterMatrizValoresMinimoArrependimentoIncerteza();
            ColorirLinhaMinimoArrependimentoTabelaIncerteza(MinimoArrependimentoIncerteza);



            // Métodos Relacionados a Análise de Risco

            CalcularVME(ArrayValores);
            CalcularPerdaEsperadaPonderada(ArrayValores);
            decimal[] ArrayValoresRisco = ObterArrayValoresRisco();
            MelhorInvestimentoRisco(ArrayValoresRisco);
            CalcularVEIP();
            decimal[,] MinimoArrependimentoRisco = ObterArrayMenorArrependimentoRisco();
            int Posicao = CustoMedioOportunidade(MinimoArrependimentoRisco);
            PintarMenorArrependimentoRisco(Posicao);

            dgvIncerteza.Refresh();
            dgvVMERisco.Refresh();
            dgvPerdaEsperadaPonderada.Refresh();
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAnaliseIncerteza_Click(object sender, EventArgs e)
        {
            pnlAnaliseIncerteza.Visible = pnlAnaliseIncerteza.Visible ? pnlAnaliseIncerteza.Visible = false : pnlAnaliseIncerteza.Visible = true;
        }

        private void btnAnaliseRisco_Click(object sender, EventArgs e)
        {
            pnlAnaliseRisco.Visible = pnlAnaliseRisco.Visible ? pnlAnaliseRisco.Visible = false : pnlAnaliseRisco.Visible = true;
        }
    }
}
