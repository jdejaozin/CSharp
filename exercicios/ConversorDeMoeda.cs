using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios
{
    class ConversorDeMoeda
    {
        public static double IOF = 6 / 100.0;

        public static double Conversao(double cotacao, double valorComprado)
        {
            return (cotacao * valorComprado) + ((cotacao * valorComprado) *IOF);
        }
    }
}
