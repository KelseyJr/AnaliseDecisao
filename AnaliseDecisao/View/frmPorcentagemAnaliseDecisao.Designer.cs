namespace AnaliseDecisao3.View {
    partial class frmPorcentagemAnaliseDecisao {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPorcentagem = new System.Windows.Forms.Panel();
            this.lblSair = new System.Windows.Forms.Label();
            this.pnlPorcentagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Alteração de Porcentagem";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPorcentagem.Location = new System.Drawing.Point(4, 54);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(196, 16);
            this.lblPorcentagem.TabIndex = 1;
            this.lblPorcentagem.Text = "Insira a nova porcentagem:";
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Location = new System.Drawing.Point(206, 54);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(78, 20);
            this.txtPorcentagem.TabIndex = 2;
            this.txtPorcentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentagem_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(69, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aperte Enter para continuar";
            // 
            // pnlPorcentagem
            // 
            this.pnlPorcentagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPorcentagem.Controls.Add(this.lblSair);
            this.pnlPorcentagem.Controls.Add(this.lblTitulo);
            this.pnlPorcentagem.Controls.Add(this.label1);
            this.pnlPorcentagem.Controls.Add(this.lblPorcentagem);
            this.pnlPorcentagem.Controls.Add(this.txtPorcentagem);
            this.pnlPorcentagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPorcentagem.Location = new System.Drawing.Point(0, 0);
            this.pnlPorcentagem.Name = "pnlPorcentagem";
            this.pnlPorcentagem.Size = new System.Drawing.Size(346, 133);
            this.pnlPorcentagem.TabIndex = 4;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSair.Location = new System.Drawing.Point(69, 107);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(120, 15);
            this.lblSair.TabIndex = 4;
            this.lblSair.Text = "Aperte ESC para sair";
            // 
            // frmPorcentagemAnaliseDecisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 133);
            this.Controls.Add(this.pnlPorcentagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPorcentagemAnaliseDecisao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPorcentagemAnaliseDecisao";
            this.pnlPorcentagem.ResumeLayout(false);
            this.pnlPorcentagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPorcentagem;
        private System.Windows.Forms.Label lblSair;
    }
}