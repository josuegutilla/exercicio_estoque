using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_estoque_classes
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
            double valorTo = Preco * Quantidade;

            return valorTo;
        }

        public void AddProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " 
                + Preco + ", " 
                + Quantidade 
                + " unidades, Total: $ " 
                + ValorTotalEmEstoque();
        }
    }
}
