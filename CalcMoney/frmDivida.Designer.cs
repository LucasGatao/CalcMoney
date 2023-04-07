namespace CalcMoney
{
    partial class frmDivida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDivida));
            this.IblIni = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtValorIni = new System.Windows.Forms.TextBox();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.lblQuantia = new System.Windows.Forms.Label();
            this.nudParcelas = new System.Windows.Forms.NumericUpDown();
            this.lblQuito = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValParcela = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAtraso = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.txtAtraso = new System.Windows.Forms.TextBox();
            this.chkAtraso = new System.Windows.Forms.CheckBox();
            this.grpAtraso = new System.Windows.Forms.GroupBox();
            this.nudAtraso = new System.Windows.Forms.NumericUpDown();
            this.lblAtraso2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).BeginInit();
            this.grpAtraso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtraso)).BeginInit();
            this.SuspendLayout();
            // 
            // IblIni
            // 
            this.IblIni.AutoSize = true;
            this.IblIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblIni.Location = new System.Drawing.Point(26, 9);
            this.IblIni.Name = "IblIni";
            this.IblIni.Size = new System.Drawing.Size(183, 24);
            this.IblIni.TabIndex = 0;
            this.IblIni.Text = "Valor inicial do gasto";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(26, 33);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(24, 16);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "R$";
            // 
            // txtValorIni
            // 
            this.txtValorIni.Location = new System.Drawing.Point(57, 33);
            this.txtValorIni.Name = "txtValorIni";
            this.txtValorIni.Size = new System.Drawing.Size(130, 20);
            this.txtValorIni.TabIndex = 1;
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(26, 56);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(125, 24);
            this.lblTaxa.TabIndex = 0;
            this.lblTaxa.Text = "Taxa de juros";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(110, 81);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(19, 16);
            this.lblB.TabIndex = 0;
            this.lblB.Text = "%";
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(29, 80);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(75, 20);
            this.txtTaxa.TabIndex = 1;
            // 
            // lblQuantia
            // 
            this.lblQuantia.AutoSize = true;
            this.lblQuantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantia.Location = new System.Drawing.Point(26, 103);
            this.lblQuantia.Name = "lblQuantia";
            this.lblQuantia.Size = new System.Drawing.Size(211, 24);
            this.lblQuantia.TabIndex = 0;
            this.lblQuantia.Text = "Quantidade de parcelas";
            this.lblQuantia.Click += new System.EventHandler(this.lblQuantia_Click);
            // 
            // nudParcelas
            // 
            this.nudParcelas.Location = new System.Drawing.Point(29, 130);
            this.nudParcelas.Name = "nudParcelas";
            this.nudParcelas.Size = new System.Drawing.Size(61, 20);
            this.nudParcelas.TabIndex = 2;
            // 
            // lblQuito
            // 
            this.lblQuito.AutoSize = true;
            this.lblQuito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuito.Location = new System.Drawing.Point(309, 103);
            this.lblQuito.Name = "lblQuito";
            this.lblQuito.Size = new System.Drawing.Size(160, 24);
            this.lblQuito.TabIndex = 0;
            this.lblQuito.Text = "Quantia total paga";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(299, 127);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(39, 25);
            this.lblD.TabIndex = 0;
            this.lblD.Text = "R$";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(344, 127);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(24, 25);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(27, 277);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValParcela
            // 
            this.lblValParcela.AutoSize = true;
            this.lblValParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValParcela.Location = new System.Drawing.Point(309, 33);
            this.lblValParcela.Name = "lblValParcela";
            this.lblValParcela.Size = new System.Drawing.Size(148, 24);
            this.lblValParcela.TabIndex = 0;
            this.lblValParcela.Text = "Valor da Parcela";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(299, 57);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(39, 25);
            this.lblC.TabIndex = 0;
            this.lblC.Text = "R$";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcela.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblParcela.Location = new System.Drawing.Point(344, 57);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(24, 25);
            this.lblParcela.TabIndex = 0;
            this.lblParcela.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Versão 0.1";
            // 
            // lblAtraso
            // 
            this.lblAtraso.AutoSize = true;
            this.lblAtraso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtraso.Location = new System.Drawing.Point(6, 16);
            this.lblAtraso.Name = "lblAtraso";
            this.lblAtraso.Size = new System.Drawing.Size(144, 24);
            this.lblAtraso.TabIndex = 0;
            this.lblAtraso.Text = "Juros por atraso";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(90, 41);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(19, 16);
            this.lblE.TabIndex = 0;
            this.lblE.Text = "%";
            // 
            // txtAtraso
            // 
            this.txtAtraso.Location = new System.Drawing.Point(9, 40);
            this.txtAtraso.Name = "txtAtraso";
            this.txtAtraso.Size = new System.Drawing.Size(75, 20);
            this.txtAtraso.TabIndex = 1;
            // 
            // chkAtraso
            // 
            this.chkAtraso.AutoSize = true;
            this.chkAtraso.Location = new System.Drawing.Point(129, 135);
            this.chkAtraso.Name = "chkAtraso";
            this.chkAtraso.Size = new System.Drawing.Size(68, 17);
            this.chkAtraso.TabIndex = 5;
            this.chkAtraso.Text = "Atrasou?";
            this.chkAtraso.UseVisualStyleBackColor = true;
            this.chkAtraso.CheckedChanged += new System.EventHandler(this.chkAtraso_CheckedChanged);
            // 
            // grpAtraso
            // 
            this.grpAtraso.Controls.Add(this.lblAtraso2);
            this.grpAtraso.Controls.Add(this.lblAtraso);
            this.grpAtraso.Controls.Add(this.lblE);
            this.grpAtraso.Controls.Add(this.txtAtraso);
            this.grpAtraso.Controls.Add(this.nudAtraso);
            this.grpAtraso.Location = new System.Drawing.Point(30, 156);
            this.grpAtraso.Name = "grpAtraso";
            this.grpAtraso.Size = new System.Drawing.Size(207, 115);
            this.grpAtraso.TabIndex = 6;
            this.grpAtraso.TabStop = false;
            this.grpAtraso.Text = "grpAtraso";
            this.grpAtraso.Visible = false;
            // 
            // nudAtraso
            // 
            this.nudAtraso.Location = new System.Drawing.Point(9, 89);
            this.nudAtraso.Name = "nudAtraso";
            this.nudAtraso.Size = new System.Drawing.Size(61, 20);
            this.nudAtraso.TabIndex = 2;
            // 
            // lblAtraso2
            // 
            this.lblAtraso2.AutoSize = true;
            this.lblAtraso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtraso2.Location = new System.Drawing.Point(5, 62);
            this.lblAtraso2.Name = "lblAtraso2";
            this.lblAtraso2.Size = new System.Drawing.Size(131, 24);
            this.lblAtraso2.TabIndex = 0;
            this.lblAtraso2.Text = "Dias de Atraso";
            // 
            // frmDivida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 316);
            this.Controls.Add(this.grpAtraso);
            this.Controls.Add(this.chkAtraso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudParcelas);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtValorIni);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblQuantia);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.lblValParcela);
            this.Controls.Add(this.lblQuito);
            this.Controls.Add(this.IblIni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDivida";
            this.Text = "Quitar o boleto";
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).EndInit();
            this.grpAtraso.ResumeLayout(false);
            this.grpAtraso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtraso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblIni;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtValorIni;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label lblQuantia;
        private System.Windows.Forms.NumericUpDown nudParcelas;
        private System.Windows.Forms.Label lblQuito;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValParcela;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAtraso;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.TextBox txtAtraso;
        private System.Windows.Forms.CheckBox chkAtraso;
        private System.Windows.Forms.GroupBox grpAtraso;
        private System.Windows.Forms.Label lblAtraso2;
        private System.Windows.Forms.NumericUpDown nudAtraso;
    }
}