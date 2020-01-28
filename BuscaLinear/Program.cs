using System;

namespace BuscaLinear
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro[] carros =
            {
                new Carro("Ferrari", 500_000),
                new Carro("Hilux", 150_000),
                new Carro("Gol", 40_000),
                new Carro("Onix", 40_000),
                new Carro("Mobi", 30_000)
            };

            ImprimeCarros(carros, "Carros");

            int posicaoEncontrada = Busca(carros, 0, carros.Length, 150_000);

            if(posicaoEncontrada >= 0)
            {
                Console.WriteLine
                    ($"Carro com Preço igual à { carros[posicaoEncontrada].Preco.ToString("C") } está na posição: { posicaoEncontrada }");
            }
            else
            {
                Console.WriteLine("Preço não encontrado");
            }


            Console.ReadKey();
        }

        private static int Busca(Carro[] carros, int de, int ate, decimal preco)
        {
            for (int atual = de; atual < ate; atual++)
            {
                if(carros[atual].Preco == preco)
                {
                    return atual;
                }
            }

            return -1;
        }

        private static void ImprimeCarros(Carro[] carros, string titulo)
        {
            Console.WriteLine(titulo);
            Console.WriteLine();
            foreach (var carro in carros)
            {
                Console.WriteLine(carro.ToString());
            }
            Console.WriteLine();
        }
    }
}
