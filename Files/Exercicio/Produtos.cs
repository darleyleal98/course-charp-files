using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files.Exercicio
{
    public class Produtos
    {
        public string Name { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produtos(string name, double preco, int quantidade) 
        { 
            Name = name;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double Total() => Preco = (Preco * Quantidade);
    }
}
