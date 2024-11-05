namespace CalcMoney
{
    partial class frmEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmprestimo));
            this.lblIni = new System.Windows.Forms.Label();
            this.txtValorIni = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblParc = new System.Windows.Forms.Label();
            this.nudParcelas = new System.Windows.Forms.NumericUpDown();
            this.lblPr = new System.Windows.Forms.Label();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblParcela2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIni
            // 
            this.lblIni.AutoSize = true;
            this.lblIni.BackColor = System.Drawing.Color.Transparent;
            this.lblIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIni.Location = new System.Drawing.Point(38, 41);
            this.lblIni.Name = "lblIni";
            this.lblIni.Size = new System.Drawing.Size(211, 25);
            this.lblIni.TabIndex = 0;
            this.lblIni.Text = "Valor do Empréstimo";
            // 
            // txtValorIni
            // 
            this.txtValorIni.Location = new System.Drawing.Point(93, 69);
            this.txtValorIni.Name = "txtValorIni";
            this.txtValorIni.Size = new System.Drawing.Size(118, 20);
            this.txtValorIni.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(66, 72);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(24, 16);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "R$";
            // 
            // lblParc
            // 
            this.lblParc.AutoSize = true;
            this.lblParc.BackColor = System.Drawing.Color.Transparent;
            this.lblParc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParc.Location = new System.Drawing.Point(38, 105);
            this.lblParc.Name = "lblParc";
            this.lblParc.Size = new System.Drawing.Size(183, 25);
            this.lblParc.TabIndex = 0;
            this.lblParc.Text = "Quantas Parcelas";
            // 
            // nudParcelas
            // 
            this.nudParcelas.Location = new System.Drawing.Point(93, 133);
            this.nudParcelas.Name = "nudParcelas";
            this.nudParcelas.Size = new System.Drawing.Size(83, 20);
            this.nudParcelas.TabIndex = 2;
            // 
            // lblPr
            // 
            this.lblPr.AutoSize = true;
            this.lblPr.BackColor = System.Drawing.Color.Transparent;
            this.lblPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPr.Location = new System.Drawing.Point(12, 171);
            this.lblPr.Name = "lblPr";
            this.lblPr.Size = new System.Drawing.Size(286, 25);
            this.lblPr.TabIndex = 0;
            this.lblPr.Text = "Porcentagem do empréstimo";
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Location = new System.Drawing.Point(93, 199);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(49, 20);
            this.txtPorcentagem.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(148, 202);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(19, 16);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Versão 0.4";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.BackColor = System.Drawing.Color.Transparent;
            this.lblParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcela.Location = new System.Drawing.Point(342, 41);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(171, 25);
            this.lblParcela.TabIndex = 0;
            this.lblParcela.Text = "Valor da Parcela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "R$";
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.BackColor = System.Drawing.Color.Transparent;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(366, 98);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(114, 25);
            this.lblTot.TabIndex = 0;
            this.lblTot.Text = "Total pago";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(368, 130);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(24, 16);
            this.lbl5.TabIndex = 2;
            this.lbl5.Text = "R$";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(69, 225);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(94, 23);
            this.btnCalculo.TabIndex = 6;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(395, 130);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0";
            // 
            // lblParcela2
            // 
            this.lblParcela2.AutoSize = true;
            this.lblParcela2.BackColor = System.Drawing.Color.Transparent;
            this.lblParcela2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcela2.Location = new System.Drawing.Point(395, 76);
            this.lblParcela2.Name = "lblParcela2";
            this.lblParcela2.Size = new System.Drawing.Size(14, 16);
            this.lblParcela2.TabIndex = 2;
            this.lblParcela2.Text = "0";
            // 
            // frmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalcMoney.Properties.Resources.Fundo_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 273);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudParcelas);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblParcela2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.txtValorIni);
            this.Controls.Add(this.lblParc);
            this.Controls.Add(this.lblPr);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.lblIni);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEmprestimo";
            this.Text = "Simulador de Emprestimos";
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIni;
        private System.Windows.Forms.TextBox txtValorIni;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblParc;
        private System.Windows.Forms.NumericUpDown nudParcelas;
        private System.Windows.Forms.Label lblPr;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblParcela2;
    }
}