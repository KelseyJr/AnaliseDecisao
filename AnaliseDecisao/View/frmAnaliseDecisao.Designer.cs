namespace AnaliseDecisao3.View
{
    partial class frmAnaliseDecisao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInvestimentoCenario = new System.Windows.Forms.DataGridView();
            this.lblAnaliseDecisao = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvIncerteza = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaximax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgLaplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaximin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgHuswicz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIncertezaArrependimento = new System.Windows.Forms.DataGridView();
            this.dgvVMERisco = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVMERisco_VME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPerdaEsperadaPonderada = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAnaliseIncerteza = new System.Windows.Forms.Button();
            this.pnlAnaliseIncerteza = new System.Windows.Forms.Panel();
            this.btnAnaliseRisco = new System.Windows.Forms.Button();
            this.pnlAnaliseRisco = new System.Windows.Forms.Panel();
            this.lblVEIP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaxVME = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestimentoCenario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncerteza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncertezaArrependimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVMERisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerdaEsperadaPonderada)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlAnaliseIncerteza.SuspendLayout();
            this.pnlAnaliseRisco.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvestimentoCenario
            // 
            this.dgvInvestimentoCenario.AllowUserToAddRows = false;
            this.dgvInvestimentoCenario.AllowUserToDeleteRows = false;
            this.dgvInvestimentoCenario.AllowUserToResizeColumns = false;
            this.dgvInvestimentoCenario.AllowUserToResizeRows = false;
            this.dgvInvestimentoCenario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvestimentoCenario.Location = new System.Drawing.Point(19, 42);
            this.dgvInvestimentoCenario.MultiSelect = false;
            this.dgvInvestimentoCenario.Name = "dgvInvestimentoCenario";
            this.dgvInvestimentoCenario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInvestimentoCenario.Size = new System.Drawing.Size(672, 142);
            this.dgvInvestimentoCenario.TabIndex = 0;
            this.dgvInvestimentoCenario.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvestimentoCenario_CellEndEdit);
            this.dgvInvestimentoCenario.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvestimentoCenario_ColumnHeaderMouseDoubleClick);
            // 
            // lblAnaliseDecisao
            // 
            this.lblAnaliseDecisao.AutoSize = true;
            this.lblAnaliseDecisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnaliseDecisao.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAnaliseDecisao.Location = new System.Drawing.Point(12, 9);
            this.lblAnaliseDecisao.Name = "lblAnaliseDecisao";
            this.lblAnaliseDecisao.Size = new System.Drawing.Size(296, 20);
            this.lblAnaliseDecisao.TabIndex = 1;
            this.lblAnaliseDecisao.Text = "Tabela de Investimentos e Cenários";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(784, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(41, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvIncerteza
            // 
            this.dgvIncerteza.AllowUserToAddRows = false;
            this.dgvIncerteza.AllowUserToDeleteRows = false;
            this.dgvIncerteza.AllowUserToResizeColumns = false;
            this.dgvIncerteza.AllowUserToResizeRows = false;
            this.dgvIncerteza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncerteza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncerteza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dgvMaximax,
            this.dvgLaplace,
            this.dgvMaximin,
            this.dvgHuswicz});
            this.dgvIncerteza.Location = new System.Drawing.Point(3, 3);
            this.dgvIncerteza.MultiSelect = false;
            this.dgvIncerteza.Name = "dgvIncerteza";
            this.dgvIncerteza.ReadOnly = true;
            this.dgvIncerteza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvIncerteza.Size = new System.Drawing.Size(640, 104);
            this.dgvIncerteza.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgvMaximax
            // 
            this.dgvMaximax.HeaderText = "Maximax";
            this.dgvMaximax.Name = "dgvMaximax";
            this.dgvMaximax.ReadOnly = true;
            this.dgvMaximax.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaximax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dvgLaplace
            // 
            this.dvgLaplace.HeaderText = "Maximin";
            this.dvgLaplace.Name = "dvgLaplace";
            this.dvgLaplace.ReadOnly = true;
            this.dvgLaplace.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgLaplace.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvMaximin
            // 
            this.dgvMaximin.HeaderText = "Laplace";
            this.dgvMaximin.Name = "dgvMaximin";
            this.dgvMaximin.ReadOnly = true;
            this.dgvMaximin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaximin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dvgHuswicz
            // 
            this.dvgHuswicz.HeaderText = "Huswicz";
            this.dvgHuswicz.Name = "dvgHuswicz";
            this.dvgHuswicz.ReadOnly = true;
            this.dvgHuswicz.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgHuswicz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvIncertezaArrependimento
            // 
            this.dgvIncertezaArrependimento.AllowUserToAddRows = false;
            this.dgvIncertezaArrependimento.AllowUserToDeleteRows = false;
            this.dgvIncertezaArrependimento.AllowUserToResizeColumns = false;
            this.dgvIncertezaArrependimento.AllowUserToResizeRows = false;
            this.dgvIncertezaArrependimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncertezaArrependimento.Location = new System.Drawing.Point(3, 126);
            this.dgvIncertezaArrependimento.MultiSelect = false;
            this.dgvIncertezaArrependimento.Name = "dgvIncertezaArrependimento";
            this.dgvIncertezaArrependimento.ReadOnly = true;
            this.dgvIncertezaArrependimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvIncertezaArrependimento.Size = new System.Drawing.Size(640, 104);
            this.dgvIncertezaArrependimento.TabIndex = 4;
            // 
            // dgvVMERisco
            // 
            this.dgvVMERisco.AllowUserToAddRows = false;
            this.dgvVMERisco.AllowUserToDeleteRows = false;
            this.dgvVMERisco.AllowUserToResizeColumns = false;
            this.dgvVMERisco.AllowUserToResizeRows = false;
            this.dgvVMERisco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVMERisco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVMERisco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dgvVMERisco_VME});
            this.dgvVMERisco.Location = new System.Drawing.Point(3, 8);
            this.dgvVMERisco.MultiSelect = false;
            this.dgvVMERisco.Name = "dgvVMERisco";
            this.dgvVMERisco.ReadOnly = true;
            this.dgvVMERisco.Size = new System.Drawing.Size(640, 104);
            this.dgvVMERisco.TabIndex = 5;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 99.8325F;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dgvVMERisco_VME
            // 
            this.dgvVMERisco_VME.FillWeight = 100.1675F;
            this.dgvVMERisco_VME.HeaderText = "VME";
            this.dgvVMERisco_VME.Name = "dgvVMERisco_VME";
            this.dgvVMERisco_VME.ReadOnly = true;
            this.dgvVMERisco_VME.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVMERisco_VME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvPerdaEsperadaPonderada
            // 
            this.dgvPerdaEsperadaPonderada.AllowUserToAddRows = false;
            this.dgvPerdaEsperadaPonderada.AllowUserToDeleteRows = false;
            this.dgvPerdaEsperadaPonderada.AllowUserToResizeColumns = false;
            this.dgvPerdaEsperadaPonderada.AllowUserToResizeRows = false;
            this.dgvPerdaEsperadaPonderada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerdaEsperadaPonderada.Location = new System.Drawing.Point(3, 126);
            this.dgvPerdaEsperadaPonderada.MultiSelect = false;
            this.dgvPerdaEsperadaPonderada.Name = "dgvPerdaEsperadaPonderada";
            this.dgvPerdaEsperadaPonderada.ReadOnly = true;
            this.dgvPerdaEsperadaPonderada.Size = new System.Drawing.Size(640, 104);
            this.dgvPerdaEsperadaPonderada.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnAnaliseIncerteza);
            this.flowLayoutPanel1.Controls.Add(this.pnlAnaliseIncerteza);
            this.flowLayoutPanel1.Controls.Add(this.btnAnaliseRisco);
            this.flowLayoutPanel1.Controls.Add(this.pnlAnaliseRisco);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 190);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(806, 255);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnAnaliseIncerteza
            // 
            this.btnAnaliseIncerteza.Location = new System.Drawing.Point(3, 3);
            this.btnAnaliseIncerteza.Name = "btnAnaliseIncerteza";
            this.btnAnaliseIncerteza.Size = new System.Drawing.Size(774, 23);
            this.btnAnaliseIncerteza.TabIndex = 0;
            this.btnAnaliseIncerteza.Text = "Análise de Incerteza";
            this.btnAnaliseIncerteza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaliseIncerteza.UseVisualStyleBackColor = true;
            this.btnAnaliseIncerteza.Click += new System.EventHandler(this.btnAnaliseIncerteza_Click);
            // 
            // pnlAnaliseIncerteza
            // 
            this.pnlAnaliseIncerteza.AutoScroll = true;
            this.pnlAnaliseIncerteza.Controls.Add(this.dgvIncerteza);
            this.pnlAnaliseIncerteza.Controls.Add(this.dgvIncertezaArrependimento);
            this.pnlAnaliseIncerteza.Location = new System.Drawing.Point(3, 32);
            this.pnlAnaliseIncerteza.Name = "pnlAnaliseIncerteza";
            this.pnlAnaliseIncerteza.Size = new System.Drawing.Size(774, 234);
            this.pnlAnaliseIncerteza.TabIndex = 1;
            // 
            // btnAnaliseRisco
            // 
            this.btnAnaliseRisco.Location = new System.Drawing.Point(3, 272);
            this.btnAnaliseRisco.Name = "btnAnaliseRisco";
            this.btnAnaliseRisco.Size = new System.Drawing.Size(774, 23);
            this.btnAnaliseRisco.TabIndex = 0;
            this.btnAnaliseRisco.Text = "Análise de Risco";
            this.btnAnaliseRisco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaliseRisco.UseVisualStyleBackColor = true;
            this.btnAnaliseRisco.Click += new System.EventHandler(this.btnAnaliseRisco_Click);
            // 
            // pnlAnaliseRisco
            // 
            this.pnlAnaliseRisco.AutoScroll = true;
            this.pnlAnaliseRisco.Controls.Add(this.lblVEIP);
            this.pnlAnaliseRisco.Controls.Add(this.label3);
            this.pnlAnaliseRisco.Controls.Add(this.lblMaxVME);
            this.pnlAnaliseRisco.Controls.Add(this.label1);
            this.pnlAnaliseRisco.Controls.Add(this.dgvPerdaEsperadaPonderada);
            this.pnlAnaliseRisco.Controls.Add(this.dgvVMERisco);
            this.pnlAnaliseRisco.Location = new System.Drawing.Point(3, 301);
            this.pnlAnaliseRisco.Name = "pnlAnaliseRisco";
            this.pnlAnaliseRisco.Size = new System.Drawing.Size(774, 234);
            this.pnlAnaliseRisco.TabIndex = 2;
            // 
            // lblVEIP
            // 
            this.lblVEIP.AutoSize = true;
            this.lblVEIP.Location = new System.Drawing.Point(705, 33);
            this.lblVEIP.Name = "lblVEIP";
            this.lblVEIP.Size = new System.Drawing.Size(41, 13);
            this.lblVEIP.TabIndex = 14;
            this.lblVEIP.Text = "lblVEIP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "VEIP:";
            // 
            // lblMaxVME
            // 
            this.lblMaxVME.AutoSize = true;
            this.lblMaxVME.Location = new System.Drawing.Point(733, 8);
            this.lblMaxVME.Name = "lblMaxVME";
            this.lblMaxVME.Size = new System.Drawing.Size(35, 13);
            this.lblMaxVME.TabIndex = 12;
            this.lblMaxVME.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "MaxVME:";
            // 
            // frmAnaliseDecisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(839, 460);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblAnaliseDecisao);
            this.Controls.Add(this.dgvInvestimentoCenario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaliseDecisao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnaliseDecisao";
            this.Load += new System.EventHandler(this.frmAnaliseDecisao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestimentoCenario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncerteza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncertezaArrependimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVMERisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerdaEsperadaPonderada)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlAnaliseIncerteza.ResumeLayout(false);
            this.pnlAnaliseRisco.ResumeLayout(false);
            this.pnlAnaliseRisco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvestimentoCenario;
        private System.Windows.Forms.Label lblAnaliseDecisao;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvIncerteza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaximax;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgLaplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaximin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgHuswicz;
        private System.Windows.Forms.DataGridView dgvIncertezaArrependimento;
        private System.Windows.Forms.DataGridView dgvVMERisco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVMERisco_VME;
        private System.Windows.Forms.DataGridView dgvPerdaEsperadaPonderada;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAnaliseIncerteza;
        private System.Windows.Forms.Panel pnlAnaliseIncerteza;
        private System.Windows.Forms.Button btnAnaliseRisco;
        private System.Windows.Forms.Panel pnlAnaliseRisco;
        private System.Windows.Forms.Label lblVEIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaxVME;
        private System.Windows.Forms.Label label1;
    }
}