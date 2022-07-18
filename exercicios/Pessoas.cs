using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios
{
    class Pessoas
    {
        //Se eu colocar como struct não da certo fazer a comparação no if
        public string Nome { get; set; }
        public string Email { get; set; }

        public Pessoas(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + ", E-mail: " + Email;
        }
    }
}
