namespace CalcMoney
{
    partial class frmInvestimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvestimento));
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblValorIni = new System.Windows.Forms.Label();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.nudMeses = new System.Windows.Forms.NumericUpDown();
            this.nudAnos = new System.Windows.Forms.NumericUpDown();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rdbSimples = new System.Windows.Forms.RadioButton();
            this.rdbComposto = new System.Windows.Forms.RadioButton();
            this.txtValorIni = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblPorcento = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Liberation Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(71, 45);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(127, 16);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de investimento";
            // 
            // lblValorIni
            // 
            this.lblValorIni.AutoSize = true;
            this.lblValorIni.Font = new System.Drawing.Font("Liberation Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorIni.Location = new System.Drawing.Point(71, 121);
            this.lblValorIni.Name = "lblValorIni";
            this.lblValorIni.Size = new System.Drawing.Size(75, 16);
            this.lblValorIni.TabIndex = 2;
            this.lblValorIni.Text = "Valor inicial";
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Liberation Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(71, 177);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(86, 16);
            this.lblTaxa.TabIndex = 2;
            this.lblTaxa.Text = "Taxa de juros";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Liberation Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(71, 235);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(142, 16);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo do investimento";
            // 
            // nudMeses
            // 
            this.nudMeses.Location = new System.Drawing.Point(74, 274);
            this.nudMeses.Name = "nudMeses";
            this.nudMeses.Size = new System.Drawing.Size(61, 20);
            this.nudMeses.TabIndex = 4;
            // 
            // nudAnos
            // 
            this.nudAnos.Location = new System.Drawing.Point(152, 274);
            this.nudAnos.Name = "nudAnos";
            this.nudAnos.Size = new System.Drawing.Size(61, 20);
            this.nudAnos.TabIndex = 5;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(163, 258);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(31, 13);
            this.lblAno.TabIndex = 7;
            this.lblAno.Text = "Anos";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(89, 258);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(38, 13);
            this.lblMeses.TabIndex = 7;
            this.lblMeses.Text = "Meses";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(74, 315);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 29);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(241, 95);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(247, 42);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "RESULTADO";
            // 
            // rdbSimples
            // 
            this.rdbSimples.AutoSize = true;
            this.rdbSimples.Location = new System.Drawing.Point(74, 64);
            this.rdbSimples.Name = "rdbSimples";
            this.rdbSimples.Size = new System.Drawing.Size(61, 17);
            this.rdbSimples.TabIndex = 0;
            this.rdbSimples.TabStop = true;
            this.rdbSimples.Text = "Simples";
            this.rdbSimples.UseVisualStyleBackColor = true;
            // 
            // rdbComposto
            // 
            this.rdbComposto.AutoSize = true;
            this.rdbComposto.Location = new System.Drawing.Point(141, 64);
            this.rdbComposto.Name = "rdbComposto";
            this.rdbComposto.Size = new System.Drawing.Size(72, 17);
            this.rdbComposto.TabIndex = 1;
            this.rdbComposto.TabStop = true;
            this.rdbComposto.Text = "Composto";
            this.rdbComposto.UseVisualStyleBackColor = true;
            // 
            // txtValorIni
            // 
            this.txtValorIni.Location = new System.Drawing.Point(92, 139);
            this.txtValorIni.Name = "txtValorIni";
            this.txtValorIni.Size = new System.Drawing.Size(85, 20);
            this.txtValorIni.TabIndex = 2;
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(74, 196);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(53, 20);
            this.txtJuros.TabIndex = 3;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(254, 150);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(33, 24);
            this.lblR.TabIndex = 12;
            this.lblR.Text = "R$";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(293, 150);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 24);
            this.lblResposta.TabIndex = 13;
            // 
            // lblPorcento
            // 
            this.lblPorcento.AutoSize = true;
            this.lblPorcento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcento.Location = new System.Drawing.Point(133, 196);
            this.lblPorcento.Name = "lblPorcento";
            this.lblPorcento.Size = new System.Drawing.Size(21, 18);
            this.lblPorcento.TabIndex = 12;
            this.lblPorcento.Text = "%";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(62, 140);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(24, 16);
            this.lblMoney.TabIndex = 12;
            this.lblMoney.Text = "R$";
            // 
            // frmInvestimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 398);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblPorcento);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.txtValorIni);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.nudAnos);
            this.Controls.Add(this.nudMeses);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.lblValorIni);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.rdbComposto);
            this.Controls.Add(this.rdbSimples);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInvestimento";
            this.Text = "Investimento";
            ((System.ComponentModel.ISupportInitialize)(this.nudMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblValorIni;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.NumericUpDown nudMeses;
        private System.Windows.Forms.NumericUpDown nudAnos;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rdbSimples;
        private System.Windows.Forms.RadioButton rdbComposto;
        private System.Windows.Forms.TextBox txtValorIni;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblPorcento;
        private System.Windows.Forms.Label lblMoney;
    }
}