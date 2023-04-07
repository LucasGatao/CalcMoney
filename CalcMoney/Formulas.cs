using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public double juros_simples(double valor_inicial, double taxa, int meses)
        {
            double final;

            final = valor_inicial * (1 + taxa * meses);
            return final;
        }
        public double juros_composto(double valor_inicial, double taxa, int meses) 
        {
            double final;

            final = valor_inicial * power((1 + taxa), meses);
            return final;
        }

        public double parcelas(double valor_inicial, double taxa, int quantia)
        {
            double valor_final;

            valor_final = (valor_inicial / quantia) * (1 + taxa);

            return valor_final;
        }

    }
}
