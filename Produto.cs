using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Abstracao
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int QuantidadeEmEstoque;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome:{Nome}");
            Console.WriteLine($"Preco: R$ {Preco}");
            Console.WriteLine($"Quantidade em estoque: {QuantidadeEmEstoque}");
            Console.WriteLine("-----------------------");
        }
    }


}

