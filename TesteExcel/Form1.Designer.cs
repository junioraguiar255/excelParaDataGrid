namespace TesteExcel
{
    partial class Form1
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
            this.tabela = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cboMuda = new System.Windows.Forms.ComboBox();
            this.txtPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(22, 13);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(651, 202);
            this.tabela.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = ".....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cboMuda
            // 
            this.cboMuda.FormattingEnabled = true;
            this.cboMuda.Location = new System.Drawing.Point(40, 245);
            this.cboMuda.Name = "cboMuda";
            this.cboMuda.Size = new System.Drawing.Size(535, 21);
            this.cboMuda.TabIndex = 2;
            this.cboMuda.SelectedIndexChanged += new System.EventHandler(this.CboSheet_SelectedIndexChanged);
            // 
            // txtPath
            // 
            this.txtPath.AutoSize = true;
            this.txtPath.Location = new System.Drawing.Point(342, 292);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(35, 13);
            this.txtPath.TabIndex = 3;
            this.txtPath.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.cboMuda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboMuda;
        private System.Windows.Forms.Label txtPath;
    }
}

