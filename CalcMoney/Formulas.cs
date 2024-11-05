using System;
using System.Windows.Forms;

namespace CalcMoney
{
    public class Formulas
    {
        public double power(double bass, int potencia)
        {
            double result;
            double a = bass;
            for (int i = 1; i < potencia; i++)
            {
                a *= bass;
            }
            result = a;
            return result;
        }

        public double juros_simples(double valor_inicial, double add, double taxa, int meses)
        {
            double final;

            final = valor_inicial * (1 + taxa * meses);
            return final;
        }
        public double juros_composto(double valor_inicial, double add, double taxa, int meses, bool ano, double creuu = 0) 
        {
            double final;
            double taxa_real = (1 + taxa) * (1 - creuu);
            if (ano == false)
            {
                ///final = (valor_inicial + (meses - 1) * add) * power(taxa_real, meses);
                int i = 0;
                double value = valor_inicial;
                while (i < meses)
                {
                    value = Math.Round((value * (1 + taxa)) * 100) / 100;
                    i += 1;
                }
                final = value;
                return final;
            }
            else
            {
                MessageBox.Show("Essa função ainda não é suportada :/", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }
        }

        public double parcelas(double valor_inicial, double taxa, int quantia)
        {
            double valor_final;

            valor_final = (valor_inicial / quantia) * (1 + taxa);

            return valor_final;
        }

    }
}
