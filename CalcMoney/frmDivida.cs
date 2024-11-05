using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMoney
{
    public partial class frmDivida : Form
    {
        Formulas novaFormula = new Formulas();
        public frmDivida()
        {
            InitializeComponent();
        }

        private void chkAtraso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtraso.Checked == true)
            {
                grpAtraso.Visible = true;
                lblParcela.ForeColor = Color.Red;
                lblResultado.ForeColor = Color.Red;
            }
            else
            {
                grpAtraso.Visible = false;
                lblParcela.ForeColor = Color.Black;
                lblResultado.ForeColor = Color.Black;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double parcelas = 0;
            int quantia = Convert.ToInt16(nudParcelas.Text);
            double total;

            parcelas = novaFormula.parcelas(Convert.ToDouble(txtValorIni.Text), (Convert.ToDouble(txtTaxa.Text) / 100), quantia);

            if (chkAtraso.Checked == true)
            {
                parcelas = parcelas * (1 + (Convert.ToDouble(txtAtraso.Text) / 3000) * Convert.ToDouble(nudAtraso.Text));

                total = parcelas * quantia;

                lblResultado.Text = total.ToString();
                lblParcela.Text = parcelas.ToString();
            }
            else
            {
                total = parcelas * quantia;

                lblResultado.Text = total.ToString();
                lblParcela.Text = parcelas.ToString();
            }
        }
    }
}
