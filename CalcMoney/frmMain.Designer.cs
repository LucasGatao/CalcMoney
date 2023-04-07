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
            this.SuspendLayout();
            // 
            // btnDivida
            // 
            this.btnDivida.Location = new System.Drawing.Point(60, 58);
            this.btnDivida.Name = "btnDivida";
            this.btnDivida.Size = new System.Drawing.Size(107, 23);
            this.btnDivida.TabIndex = 0;
            this.btnDivida.Text = "Quitar Boleto";
            this.btnDivida.UseVisualStyleBackColor = true;
            this.btnDivida.Click += new System.EventHandler(this.btnDivida_Click);
            // 
            // btnInvesti
            // 
            this.btnInvesti.Location = new System.Drawing.Point(60, 29);
            this.btnInvesti.Name = "btnInvesti";
            this.btnInvesti.Size = new System.Drawing.Size(107, 23);
            this.btnInvesti.TabIndex = 0;
            this.btnInvesti.Text = "Investimento";
            this.btnInvesti.UseVisualStyleBackColor = true;
            this.btnInvesti.Click += new System.EventHandler(this.btnInvesti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Versão 0.1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(235, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvesti);
            this.Controls.Add(this.btnDivida);
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
    }
}

