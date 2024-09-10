using System;

namespace ColetaDeItensApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random random = new Random();

            
            Console.Write("Digite o número total de baús que deseja abrir: ");
            int totalBaús = int.Parse(Console.ReadLine());

            
            Console.Write("Digite o número de tipos diferentes de baús no jogo: ");
            int tiposDeBaús = int.Parse(Console.ReadLine());

           
        
            int itensRarosTotais = 0;

            
            int[] baúsPorTipo = new int[tiposDeBaús];

          
            int[] itensRarosPorTipo = new int[tiposDeBaús];

            
        
            for (int i = 0; i < tiposDeBaús; i++)
            {
                Console.Write($"Digite o número de baús do Tipo {ConvertirTipoParaLetra(i)} que deseja abrir: ");
                baúsPorTipo[i] = int.Parse(Console.ReadLine());

                int itensRarosTipoAtual = 0;
                for (int j = 0; j < baúsPorTipo[i]; j++)
                {
                    int itensRaros;
                    switch (i)
                    {
                        case 0:
                            itensRaros = random.Next(0, 4); 
                            break;
                        case 1: 
                            itensRaros = random.Next(1, 6);
                            break;
                        case 2: 
                            itensRaros = random.Next(2, 7); 
                            break;
                        default:
                            itensRaros = 0;
                            break;
                    }

                    itensRarosTipoAtual += itensRaros;
                }

                itensRarosPorTipo[i] = itensRarosTipoAtual;
                itensRarosTotais += itensRarosTipoAtual;

                Console.WriteLine($"Tipo {ConvertirTipoParaLetra(i)}: {baúsPorTipo[i]} baús, Itens raros: {itensRarosTipoAtual}");
            }

            // Exibir o total de itens raros obtidos
            Console.WriteLine($"\nTotal de itens raros obtidos: {itensRarosTotais}");
        }

       
        static char ConvertirTipoParaLetra(int index)
        {
            switch (index)
            {
                case 0: return 'A';
                case 1: return 'B';
                case 2: return 'C';
                default: return 'X';
            }
        }
    }
}
