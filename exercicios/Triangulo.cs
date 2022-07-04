using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios
{
    class Triangulo
    {
        //O public permite que seja acessado em outro arquivo
        public double A;
        public double B;
        public double C;

        public double AreaTriangulo()
        {
            double p = (A + B + C) / 2.0;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
