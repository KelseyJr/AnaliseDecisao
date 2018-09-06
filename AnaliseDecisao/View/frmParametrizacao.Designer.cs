namespace AnaliseDecisao3
{
    partial class frmParametrizacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblInvestimentos = new System.Windows.Forms.Label();
            this.lblCenario = new System.Windows.Forms.Label();
            this.gpbInvestimentosCenarios = new System.Windows.Forms.GroupBox();
            this.txtCenario = new System.Windows.Forms.TextBox();
            this.txtInvestimentos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRiscoIncerteza = new System.Windows.Forms.RadioButton();
            this.rdbRisco = new System.Windows.Forms.RadioButton();
            this.rdbIncerteza = new System.Windows.Forms.RadioButton();
            this.lblContinuar = new System.Windows.Forms.Label();
            this.gpbInvestimentosCenarios.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(76, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Início";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFechar.Location = new System.Drawing.Point(234, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(44, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblInvestimentos
            // 
            this.lblInvestimentos.AutoSize = true;
            this.lblInvestimentos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblInvestimentos.Location = new System.Drawing.Point(6, 35);
            this.lblInvestimentos.Name = "lblInvestimentos";
            this.lblInvestimentos.Size = new System.Drawing.Size(72, 13);
            this.lblInvestimentos.TabIndex = 3;
            this.lblInvestimentos.Text = "Investimentos";
            // 
            // lblCenario
            // 
            this.lblCenario.AutoSize = true;
            this.lblCenario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCenario.Location = new System.Drawing.Point(144, 35);
            this.lblCenario.Name = "lblCenario";
            this.lblCenario.Size = new System.Drawing.Size(48, 13);
            this.lblCenario.TabIndex = 4;
            this.lblCenario.Text = "Cenários";
            // 
            // gpbInvestimentosCenarios
            // 
            this.gpbInvestimentosCenarios.Controls.Add(this.txtCenario);
            this.gpbInvestimentosCenarios.Controls.Add(this.txtInvestimentos);
            this.gpbInvestimentosCenarios.Controls.Add(this.lblInvestimentos);
            this.gpbInvestimentosCenarios.Controls.Add(this.lblCenario);
            this.gpbInvestimentosCenarios.Location = new System.Drawing.Point(17, 64);
            this.gpbInvestimentosCenarios.Name = "gpbInvestimentosCenarios";
            this.gpbInvestimentosCenarios.Size = new System.Drawing.Size(261, 71);
            this.gpbInvestimentosCenarios.TabIndex = 5;
            this.gpbInvestimentosCenarios.TabStop = false;
            this.gpbInvestimentosCenarios.Text = "Defina a quantidade de investimentos e cenários:";
            // 
            // txtCenario
            // 
            this.txtCenario.Location = new System.Drawing.Point(195, 32);
            this.txtCenario.Name = "txtCenario";
            this.txtCenario.Size = new System.Drawing.Size(54, 20);
            this.txtCenario.TabIndex = 6;
            this.txtCenario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCenarios_KeyPress);
            // 
            // txtInvestimentos
            // 
            this.txtInvestimentos.Location = new System.Drawing.Point(79, 32);
            this.txtInvestimentos.Name = "txtInvestimentos";
            this.txtInvestimentos.Size = new System.Drawing.Size(54, 20);
            this.txtInvestimentos.TabIndex = 5;
            this.txtInvestimentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvestimentos_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRiscoIncerteza);
            this.groupBox1.Controls.Add(this.rdbRisco);
            this.groupBox1.Controls.Add(this.rdbIncerteza);
            this.groupBox1.Location = new System.Drawing.Point(17, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Defina a quantidade de investimentos e cenários:";
            // 
            // rdbRiscoIncerteza
            // 
            this.rdbRiscoIncerteza.AutoSize = true;
            this.rdbRiscoIncerteza.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbRiscoIncerteza.Location = new System.Drawing.Point(7, 75);
            this.rdbRiscoIncerteza.Name = "rdbRiscoIncerteza";
            this.rdbRiscoIncerteza.Size = new System.Drawing.Size(108, 17);
            this.rdbRiscoIncerteza.TabIndex = 2;
            this.rdbRiscoIncerteza.TabStop = true;
            this.rdbRiscoIncerteza.Text = "Risco e Incerteza";
            this.rdbRiscoIncerteza.UseVisualStyleBackColor = true;
            this.rdbRiscoIncerteza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdbRiscoIncerteza_KeyPress);
            // 
            // rdbRisco
            // 
            this.rdbRisco.AutoSize = true;
            this.rdbRisco.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbRisco.Location = new System.Drawing.Point(7, 52);
            this.rdbRisco.Name = "rdbRisco";
            this.rdbRisco.Size = new System.Drawing.Size(52, 17);
            this.rdbRisco.TabIndex = 1;
            this.rdbRisco.TabStop = true;
            this.rdbRisco.Text = "Risco";
            this.rdbRisco.UseVisualStyleBackColor = true;
            this.rdbRisco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdbRisco_KeyPress);
            // 
            // rdbIncerteza
            // 
            this.rdbIncerteza.AutoSize = true;
            this.rdbIncerteza.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbIncerteza.Location = new System.Drawing.Point(7, 29);
            this.rdbIncerteza.Name = "rdbIncerteza";
            this.rdbIncerteza.Size = new System.Drawing.Size(69, 17);
            this.rdbIncerteza.TabIndex = 0;
            this.rdbIncerteza.TabStop = true;
            this.rdbIncerteza.Text = "Incerteza";
            this.rdbIncerteza.UseVisualStyleBackColor = true;
            this.rdbIncerteza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdbIncerteza_KeyPress);
            // 
            // lblContinuar
            // 
            this.lblContinuar.AutoSize = true;
            this.lblContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinuar.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblContinuar.Location = new System.Drawing.Point(24, 275);
            this.lblContinuar.Name = "lblContinuar";
            this.lblContinuar.Size = new System.Drawing.Size(242, 15);
            this.lblContinuar.TabIndex = 3;
            this.lblContinuar.Text = "Aperte a tecla ENTER para continuar";
            // 
            // frmParametrizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(294, 313);
            this.Controls.Add(this.lblContinuar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbInvestimentosCenarios);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParametrizacao";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.gpbInvestimentosCenarios.ResumeLayout(false);
            this.gpbInvestimentosCenarios.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblInvestimentos;
        private System.Windows.Forms.Label lblCenario;
        private System.Windows.Forms.GroupBox gpbInvestimentosCenarios;
        private System.Windows.Forms.TextBox txtCenario;
        private System.Windows.Forms.TextBox txtInvestimentos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbRiscoIncerteza;
        private System.Windows.Forms.RadioButton rdbRisco;
        private System.Windows.Forms.RadioButton rdbIncerteza;
        private System.Windows.Forms.Label lblContinuar;
    }
}

