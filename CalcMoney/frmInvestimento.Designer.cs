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
            this.lblVersInvest = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComparar = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblSem = new System.Windows.Forms.Label();
            this.gpbTipoInvest = new System.Windows.Forms.GroupBox();
            this.gpbCreuEmpresa = new System.Windows.Forms.GroupBox();
            this.rdbMensal = new System.Windows.Forms.RadioButton();
            this.rdbAnual = new System.Windows.Forms.RadioButton();
            this.txtCreu = new System.Windows.Forms.TextBox();
            this.lblPorcento2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnos)).BeginInit();
            this.gpbTipoInvest.SuspendLayout();
            this.gpbCreuEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorIni
            // 
            this.lblValorIni.AutoSize = true;
            this.lblValorIni.BackColor = System.Drawing.Color.Transparent;
            this.lblValorIni.Font = new System.Drawing.Font("Liberation Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorIni.Location = new System.Drawing.Point(71, 75);
            this.lblValorIni.Name = "lblValorIni";
            this.lblValorIni.Size = new System.Drawing.Size(75, 16);
            this.lblValorIni.TabIndex = 2;
            this.lblValorIni.Text = "Valor inicial";
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.BackColor = System.Drawing.Color.Transparent;
            this.lblTaxa.Font = new System.Drawing.Font("Liberation Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(71, 113);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(86, 16);
            this.lblTaxa.TabIndex = 2;
            this.lblTaxa.Text = "Taxa de juros";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTempo.Font = new System.Drawing.Font("Liberation Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(71, 319);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(142, 16);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo do investimento";
            // 
            // nudMeses
            // 
            this.nudMeses.Location = new System.Drawing.Point(74, 361);
            this.nudMeses.Name = "nudMeses";
            this.nudMeses.Size = new System.Drawing.Size(61, 20);
            this.nudMeses.TabIndex = 3;
            // 
            // nudAnos
            // 
            this.nudAnos.Location = new System.Drawing.Point(152, 361);
            this.nudAnos.Name = "nudAnos";
            this.nudAnos.Size = new System.Drawing.Size(61, 20);
            this.nudAnos.TabIndex = 4;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.Transparent;
            this.lblAno.Location = new System.Drawing.Point(161, 345);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(31, 13);
            this.lblAno.TabIndex = 7;
            this.lblAno.Text = "Anos";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.BackColor = System.Drawing.Color.Transparent;
            this.lblMeses.Location = new System.Drawing.Point(89, 345);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(38, 13);
            this.lblMeses.TabIndex = 7;
            this.lblMeses.Text = "Meses";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Location = new System.Drawing.Point(74, 383);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 29);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
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
            this.rdbSimples.Location = new System.Drawing.Point(6, 19);
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
            this.rdbComposto.Location = new System.Drawing.Point(76, 19);
            this.rdbComposto.Name = "rdbComposto";
            this.rdbComposto.Size = new System.Drawing.Size(72, 17);
            this.rdbComposto.TabIndex = 1;
            this.rdbComposto.TabStop = true;
            this.rdbComposto.Text = "Composto";
            this.rdbComposto.UseVisualStyleBackColor = true;
            // 
            // txtValorIni
            // 
            this.txtValorIni.Location = new System.Drawing.Point(92, 93);
            this.txtValorIni.Name = "txtValorIni";
            this.txtValorIni.Size = new System.Drawing.Size(85, 20);
            this.txtValorIni.TabIndex = 0;
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(74, 132);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(53, 20);
            this.txtJuros.TabIndex = 1;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.BackColor = System.Drawing.Color.Transparent;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(244, 150);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(33, 24);
            this.lblR.TabIndex = 12;
            this.lblR.Text = "R$";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.BackColor = System.Drawing.Color.Transparent;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(293, 150);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(20, 24);
            this.lblResposta.TabIndex = 13;
            this.lblResposta.Text = "0";
            // 
            // lblPorcento
            // 
            this.lblPorcento.AutoSize = true;
            this.lblPorcento.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcento.Location = new System.Drawing.Point(133, 132);
            this.lblPorcento.Name = "lblPorcento";
            this.lblPorcento.Size = new System.Drawing.Size(21, 18);
            this.lblPorcento.TabIndex = 12;
            this.lblPorcento.Text = "%";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(62, 94);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(24, 16);
            this.lblMoney.TabIndex = 12;
            this.lblMoney.Text = "R$";
            // 
            // lblVersInvest
            // 
            this.lblVersInvest.AutoSize = true;
            this.lblVersInvest.BackColor = System.Drawing.Color.Transparent;
            this.lblVersInvest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVersInvest.Location = new System.Drawing.Point(0, 414);
            this.lblVersInvest.Name = "lblVersInvest";
            this.lblVersInvest.Size = new System.Drawing.Size(58, 13);
            this.lblVersInvest.TabIndex = 14;
            this.lblVersInvest.Text = "Versão 0.4";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Liberation Serif", 11.25F);
            this.lblAdd.Location = new System.Drawing.Point(74, 159);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(143, 16);
            this.lblAdd.TabIndex = 15;
            this.lblAdd.Text = "Valor adiconado a mais";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(92, 181);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 20);
            this.txtAdd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "R$";
            // 
            // lblComparar
            // 
            this.lblComparar.AutoSize = true;
            this.lblComparar.BackColor = System.Drawing.Color.Transparent;
            this.lblComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComparar.Location = new System.Drawing.Point(243, 207);
            this.lblComparar.Name = "lblComparar";
            this.lblComparar.Size = new System.Drawing.Size(215, 29);
            this.lblComparar.TabIndex = 16;
            this.lblComparar.Text = "SEM PAGAR MAIS";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.BackColor = System.Drawing.Color.Transparent;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(244, 248);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(33, 24);
            this.lblS.TabIndex = 12;
            this.lblS.Text = "R$";
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.BackColor = System.Drawing.Color.Transparent;
            this.lblSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSem.Location = new System.Drawing.Point(293, 248);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(20, 24);
            this.lblSem.TabIndex = 13;
            this.lblSem.Text = "0";
            // 
            // gpbTipoInvest
            // 
            this.gpbTipoInvest.BackColor = System.Drawing.Color.Transparent;
            this.gpbTipoInvest.Controls.Add(this.rdbSimples);
            this.gpbTipoInvest.Controls.Add(this.rdbComposto);
            this.gpbTipoInvest.Location = new System.Drawing.Point(65, 12);
            this.gpbTipoInvest.Name = "gpbTipoInvest";
            this.gpbTipoInvest.Size = new System.Drawing.Size(200, 46);
            this.gpbTipoInvest.TabIndex = 17;
            this.gpbTipoInvest.TabStop = false;
            this.gpbTipoInvest.Text = "Tipo de investimento";
            // 
            // gpbCreuEmpresa
            // 
            this.gpbCreuEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.gpbCreuEmpresa.Controls.Add(this.rdbMensal);
            this.gpbCreuEmpresa.Controls.Add(this.rdbAnual);
            this.gpbCreuEmpresa.Controls.Add(this.txtCreu);
            this.gpbCreuEmpresa.Controls.Add(this.lblPorcento2);
            this.gpbCreuEmpresa.Location = new System.Drawing.Point(69, 211);
            this.gpbCreuEmpresa.Name = "gpbCreuEmpresa";
            this.gpbCreuEmpresa.Size = new System.Drawing.Size(162, 73);
            this.gpbCreuEmpresa.TabIndex = 18;
            this.gpbCreuEmpresa.TabStop = false;
            this.gpbCreuEmpresa.Text = "Porcentagem da empresa";
            // 
            // rdbMensal
            // 
            this.rdbMensal.AutoSize = true;
            this.rdbMensal.Location = new System.Drawing.Point(64, 19);
            this.rdbMensal.Name = "rdbMensal";
            this.rdbMensal.Size = new System.Drawing.Size(59, 17);
            this.rdbMensal.TabIndex = 0;
            this.rdbMensal.TabStop = true;
            this.rdbMensal.Text = "Mensal";
            this.rdbMensal.UseVisualStyleBackColor = true;
            // 
            // rdbAnual
            // 
            this.rdbAnual.AutoSize = true;
            this.rdbAnual.Location = new System.Drawing.Point(6, 19);
            this.rdbAnual.Name = "rdbAnual";
            this.rdbAnual.Size = new System.Drawing.Size(52, 17);
            this.rdbAnual.TabIndex = 0;
            this.rdbAnual.TabStop = true;
            this.rdbAnual.Text = "Anual";
            this.rdbAnual.UseVisualStyleBackColor = true;
            // 
            // txtCreu
            // 
            this.txtCreu.Location = new System.Drawing.Point(13, 41);
            this.txtCreu.Name = "txtCreu";
            this.txtCreu.Size = new System.Drawing.Size(53, 20);
            this.txtCreu.TabIndex = 1;
            // 
            // lblPorcento2
            // 
            this.lblPorcento2.AutoSize = true;
            this.lblPorcento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcento2.Location = new System.Drawing.Point(72, 43);
            this.lblPorcento2.Name = "lblPorcento2";
            this.lblPorcento2.Size = new System.Drawing.Size(21, 18);
            this.lblPorcento2.TabIndex = 12;
            this.lblPorcento2.Text = "%";
            // 
            // frmInvestimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalcMoney.Properties.Resources.Fundo_04;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 427);
            this.Controls.Add(this.gpbCreuEmpresa);
            this.Controls.Add(this.gpbTipoInvest);
            this.Controls.Add(this.lblComparar);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblVersInvest);
            this.Controls.Add(this.lblSem);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblPorcento);
            this.Controls.Add(this.lblS);
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInvestimento";
            this.Text = "Investimento";
            ((System.ComponentModel.ISupportInitialize)(this.nudMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnos)).EndInit();
            this.gpbTipoInvest.ResumeLayout(false);
            this.gpbTipoInvest.PerformLayout();
            this.gpbCreuEmpresa.ResumeLayout(false);
            this.gpbCreuEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblVersInvest;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComparar;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblSem;
        private System.Windows.Forms.GroupBox gpbTipoInvest;
        private System.Windows.Forms.GroupBox gpbCreuEmpresa;
        private System.Windows.Forms.RadioButton rdbMensal;
        private System.Windows.Forms.RadioButton rdbAnual;
        private System.Windows.Forms.TextBox txtCreu;
        private System.Windows.Forms.Label lblPorcento2;
    }
}