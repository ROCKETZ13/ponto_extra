namespace WindowsFormsApp1
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
            this.lbl_escolha = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.cbo_comida = new System.Windows.Forms.ComboBox();
            this.btn_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_escolha
            // 
            this.lbl_escolha.AutoSize = true;
            this.lbl_escolha.Location = new System.Drawing.Point(22, 15);
            this.lbl_escolha.Name = "lbl_escolha";
            this.lbl_escolha.Size = new System.Drawing.Size(101, 13);
            this.lbl_escolha.TabIndex = 0;
            this.lbl_escolha.Text = "escolha sua comida";
            this.lbl_escolha.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(12, 55);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(121, 39);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "if";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // cbo_comida
            // 
            this.cbo_comida.FormattingEnabled = true;
            this.cbo_comida.Location = new System.Drawing.Point(160, 12);
            this.cbo_comida.Name = "cbo_comida";
            this.cbo_comida.Size = new System.Drawing.Size(98, 21);
            this.cbo_comida.TabIndex = 2;
            this.cbo_comida.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(149, 55);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(121, 39);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "switch";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 114);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.cbo_comida);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.lbl_escolha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_escolha;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.ComboBox cbo_comida;
        private System.Windows.Forms.Button btn_2;
    }
}

