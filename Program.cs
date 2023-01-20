namespace projeto_estoque_classes
{
    class program
    {
        static void Main(string[] args)
        {
            Produto produto;
            produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quant = int.Parse(Console.ReadLine());
            produto.AddProdutos(quant);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quant = int.Parse(Console.ReadLine());
            produto.RemoverProduto(quant);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

        }

    }
}
