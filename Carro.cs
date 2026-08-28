using System.Threading.Channels;

namespace Abstracao
{
    public class Carro
    {
        //ATRIBUTOS
        public string Marca;
        public string Modelo;
        public int Ano;
        public string Cor;

        //metodos
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro:{Marca} {Modelo}");
            Console.WriteLine($"Cor: {Cor}, Ano: {Ano}");
            Console.WriteLine("-----------------------");
        }
    }
}
