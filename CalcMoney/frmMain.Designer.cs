namespace CalcMoney
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDivida = new System.Windows.Forms.Button();
            this.btnInvesti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDivida
            // 
            this.btnDivida.Location = new System.Drawing.Point(12, 58);
            this.btnDivida.Name = "btnDivida";
            this.btnDivida.Size = new System.Drawing.Size(125, 23);
            this.btnDivida.TabIndex = 0;
            this.btnDivida.Text = "Quitar Boleto";
            this.btnDivida.UseVisualStyleBackColor = true;
            this.btnDivida.Click += new System.EventHandler(this.btnDivida_Click);
            // 
            // btnInvesti
            // 
            this.btnInvesti.Location = new System.Drawing.Point(12, 29);
            this.btnInvesti.Name = "btnInvesti";
            this.btnInvesti.Size = new System.Drawing.Size(125, 23);
            this.btnInvesti.TabIndex = 0;
            this.btnInvesti.Text = "Investimento";
            this.btnInvesti.UseVisualStyleBackColor = true;
            this.btnInvesti.Click += new System.EventHandler(this.btnInvesti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Liberation Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Versão 0.4";
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Location = new System.Drawing.Point(12, 87);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(125, 23);
            this.btnEmprestimo.TabIndex = 0;
            this.btnEmprestimo.Text = "Simlular empréstimo";
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CalcMoney.Properties.Resources.Fundo_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(235, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvesti);
            this.Controls.Add(this.btnEmprestimo);
            this.Controls.Add(this.btnDivida);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Liberation Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "CalcMoney";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDivida;
        private System.Windows.Forms.Button btnInvesti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmprestimo;
    }
}

