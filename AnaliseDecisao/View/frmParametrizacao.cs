using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnaliseDecisao3.View;

namespace AnaliseDecisao3 {
    public partial class frmParametrizacao : Form {

        public frmParametrizacao() {
            InitializeComponent();
            rdbIncerteza.Checked = true;
            txtInvestimentos.Focus();
        }

        private void txtInvestimentos_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                ValidarCampos();
            }
            else {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txtCenarios_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                ValidarCampos();
            } else {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void ValidarCampos(){

            if (txtInvestimentos.Text == "") {
                MessageBox.Show("Campo Investimentos não pode ser vazio","Erro");
                return;
            }

            if (txtCenario.Text == "") {
                MessageBox.Show("Campo Cenário não pode ser vazio","Erro");
                return;
            }
            RedirecionarFrmAnaliseDecisao();
        }

        private void RedirecionarFrmAnaliseDecisao() {
            int Colunas = Convert.ToInt32(txtCenario.Text);
            int Linhas = Convert.ToInt32(txtInvestimentos.Text);
            frmAnaliseDecisao frmAnaliseDecisao = new frmAnaliseDecisao(Colunas, Linhas);
            frmAnaliseDecisao.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Dispose();
        }

        private void rdbIncerteza_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                ValidarCampos();
            }
        }

        private void rdbRisco_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                ValidarCampos();
            }
        }

        private void rdbRiscoIncerteza_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                ValidarCampos();
            }
        }
    }
}
