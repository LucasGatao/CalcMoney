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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnInvesti_Click(object sender, EventArgs e)
        {
            frmInvestimento novoinvestimento = new frmInvestimento();
            novoinvestimento.Show();
        }

        private void btnDivida_Click(object sender, EventArgs e)
        {
            frmDivida novaDivida = new frmDivida();
            novaDivida.Show();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            frmEmprestimo novoEmprestimo = new frmEmprestimo();
            novoEmprestimo.Show();
        }

    }
}
