namespace Abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRIANDO O OBJETO (INSTANCIAÇÃO)
            Carro Fusca = new Carro();
            Fusca.Marca = "Volkswagen";
            Fusca.Modelo = "Fusca";
            Fusca.Ano = 1975;
            Fusca.Cor = "Azul";

            Carro carroVizinho = new Carro();
            carroVizinho.Marca = "Fiat";
            carroVizinho.Modelo = "Uno";
            carroVizinho.Ano = 2010;
            carroVizinho.Cor = "Prata";



            Console.WriteLine("Informações do meu carro:");
            Fusca.ExibirInformacoes();

            Console.WriteLine("Informações do carro do vizinho:");
            carroVizinho.ExibirInformacoes();

            //exercicio 1
            Produto item1 = new Produto();
            item1.Nome = "Caderno";
            item1.Preco = 11.90;
            item1.QuantidadeEmEstoque = 5;

            Produto item2 = new Produto();
            item2.Nome = "Caneta";
            item2.Preco = 0.50;
            item2.QuantidadeEmEstoque = 20;

            Console.WriteLine("Informações do produto 1:");
            item1.ExibirInfo();

            Console.WriteLine("Informações do produto 2:");
            item2.ExibirInfo();
            item2.ExibirInfo();

            Console.ReadKey();

        }
    }
}
