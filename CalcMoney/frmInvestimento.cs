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
    public partial class frmInvestimento : Form
    {
        
        public frmInvestimento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Formulas novaformula = new Formulas();
            
            decimal valor_final = 0;
            int data = 0;
            data = Convert.ToInt16(nudMeses.Text) + (12 * Convert.ToInt16(nudAnos.Text));
            double porcento = Convert.ToDouble(txtJuros.Text) / 100;

            try
            {
                if (rdbComposto.Checked == true)
                {
                    valor_final = (decimal)novaformula.juros_composto(Convert.ToDouble(txtValorIni.Text), porcento, data);
                }
                else
                {
                    valor_final = (decimal)novaformula.juros_simples(Convert.ToDouble(txtValorIni.Text), porcento, data);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            lblResposta.Text = Convert.ToString(valor_final);
        }
    }
}
