using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Calculadora
    {
        private double areaParedes;
        private double areaTeto;

        public double CalcularAreaParedes(double largura, double profundidade, double altura)
        {
            areaParedes = 2 * (largura + profundidade) * altura;
            return areaParedes;
        }

        public double CalcularAreaTeto(double largura, double profundidade)
        {
            areaTeto = largura * profundidade;
            return areaTeto;
        }

        public double CalcularLitragemNecessaria()
        {
            if (areaParedes == 0 && areaTeto == 0)
            {
                Console.WriteLine("Não é possível calcular as litragem para os valores informados");
                Environment.Exit(1);
            }
            return (areaParedes + areaTeto) / 10;
        }
    }
}
