using System;

namespace JornadaHeroiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir o ponto de vida inicial do herói
            int vidaInicial = 100;
            int vidaFinal = vidaInicial;

            
            Console.Write("Digite o número de fases que o herói deseja jogar: ");
            int numeroFases = int.Parse(Console.ReadLine());

           
            for (int i = 1; i <= numeroFases; i++)
            {
                
                Console.Write($"Digite os pontos de vida ganhos (+) ou perdidos (-) na fase {i}: ");
                int pontosFase = int.Parse(Console.ReadLine());
                vidaFinal += pontosFase;

               
                Console.Write("O herói usou um item de cura nesta fase? (Sim/Não): ");
                string usoCura = Console.ReadLine().Trim().ToLower();

               
                if (usoCura == "sim")
                {
                    Console.Write("Digite a quantidade de pontos de cura usados: ");
                    int pontosCura = int.Parse(Console.ReadLine());
                    vidaFinal += pontosCura;
                }
            }

           
            Console.WriteLine($"\nVida Final: {vidaFinal} pontos");
        }
    }
}
