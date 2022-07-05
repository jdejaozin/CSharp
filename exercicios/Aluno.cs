using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exercicios
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public void Aprovado()
        {
            Console.WriteLine("Aluno: " + Nome);
            Console.WriteLine("Nota final: " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if(NotaFinal() >= 60)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine($"Faltaram {(60 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)} pontos");
            }
        }


    }
}
