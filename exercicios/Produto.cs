using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exercicios
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //Por padrão do C# quando vai colocar algum variável de parâmetro de entrada de função é minusculo
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
            //A diferença aqui
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quantidade + " unidades, Total: $ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
