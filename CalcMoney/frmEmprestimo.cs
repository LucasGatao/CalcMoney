using System;
using System.CodeDom;
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
    public partial class frmEmprestimo : Form
    {
        Formulas novaformula;
        public frmEmprestimo()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            novaformula = new Formulas();
            double taxa = Convert.ToDouble(txtPorcentagem.Text) / 100;

            double valorfinal = novaformula.parcelas(Convert.ToDouble(txtValorIni.Text), taxa, Convert.ToInt16(nudParcelas.Value));
            double total = valorfinal * Convert.ToInt16(nudParcelas.Text);

            lblParcela2.Text = valorfinal.ToString();
            lblTotal.Text = total.ToString();
        }
    }
}
