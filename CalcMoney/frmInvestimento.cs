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
            // prepara as variaveis
            Formulas novaformula = new Formulas();
            
            bool anual = true;
            decimal valor_final = 0;
            decimal valor_sem = 0;
            int data = 0;
            double creu = 0;
            if (txtCreu.Text.Length > 0 )
            {
                creu = Convert.ToDouble(txtCreu.Text) / 100;
            }   
            data = Convert.ToInt16(nudMeses.Text) + (12 * Convert.ToInt16(nudAnos.Text));
            double porcento = Convert.ToDouble(txtJuros.Text) / 100;
            // Faz os ifs elses
            try
            {
                if (rdbAnual.Checked == true)
                {
                    anual = true;
                }
                else
                {
                    anual = false;
                }
                if (rdbComposto.Checked == true)
                {
                    valor_final = (decimal)novaformula.juros_composto(Convert.ToDouble(txtValorIni.Text), Convert.ToDouble(txtAdd.Text), porcento, data, anual, creu);
                    valor_sem = (decimal)novaformula.juros_composto(Convert.ToDouble(txtValorIni.Text), 0, porcento, data, anual, creu);
                }
                else
                {
                    valor_final = (decimal)novaformula.juros_simples(Convert.ToDouble(txtValorIni.Text), Convert.ToDouble(txtAdd.Text), porcento, data);
                    valor_sem = (decimal)novaformula.juros_simples(Convert.ToDouble(txtValorIni.Text), 0, porcento, data);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            lblResposta.Text = Convert.ToString(valor_final);
            lblSem.Text = Convert.ToString(valor_sem);
        }
    }
}
