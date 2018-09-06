using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaliseDecisao3.View {
    public partial class frmPorcentagemAnaliseDecisao : Form {

        decimal PorcentagemTotal;

        public frmPorcentagemAnaliseDecisao(decimal porcentagemTotal) {
            InitializeComponent();
            txtPorcentagem.Focus();
            PorcentagemTotal = porcentagemTotal;
        }

        private void txtPorcentagem_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtPorcentagem.Text != "") {
                decimal Valor = Convert.ToDecimal(txtPorcentagem.Text);
                if (Valor <= 100 - PorcentagemTotal) {
                    this.Close();
                } else {
                    MessageBox.Show("O valor deve ser inferior a " + (100 - PorcentagemTotal), "Erro");
                }

            } else if (e.KeyChar == Convert.ToChar(Keys.Escape)) {
                txtPorcentagem.Text = "";
                this.Close();

            } else {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
            }
        }

        public decimal RetornaPorcentagem() {
            this.ShowDialog();
            decimal Retorno = txtPorcentagem.Text == "" ? -1 : Convert.ToDecimal(txtPorcentagem.Text);
            return Retorno;
        }
    }
}
