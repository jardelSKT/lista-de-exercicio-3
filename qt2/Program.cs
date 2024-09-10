using System;

namespace PontuacaoMissaoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite o número de missões completadas: ");
            int numeroMissões = int.Parse(Console.ReadLine());

            
            int pontuacaoTotal = 0;

            
            for (int i = 1; i <= numeroMissões; i++)
            {
                
                Console.Write($"Digite o nível de dificuldade da missão {i} (Fácil, Médio, Difícil): ");
                string dificuldade = Console.ReadLine().Trim().ToLower();

                
                Console.Write($"Digite o número de inimigos derrotados na missão {i}: ");
                int inimigosDerrotados = int.Parse(Console.ReadLine());

               
                int pontosPorInimigo = 0;
                switch (dificuldade)
                {
                    case "fácil":
                        pontosPorInimigo = 50;
                        break;
                    case "médio":
                        pontosPorInimigo = 100;
                        break;
                    case "difícil":
                        pontosPorInimigo = 150;
                        break;
                    default:
                        Console.WriteLine("Nível de dificuldade desconhecido. Pontuação padrão de 0 pontos será aplicada.");
                        pontosPorInimigo = 0;
                        break;
                }

                
                int pontuacaoMissao = pontosPorInimigo * inimigosDerrotados;
                pontuacaoTotal += pontuacaoMissao;
            }

            
            Console.WriteLine($"\nPontuação total obtida: {pontuacaoTotal} pontos");
        }
    }
}
