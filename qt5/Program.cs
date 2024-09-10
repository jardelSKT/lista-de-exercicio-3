using System;

namespace CalculadoraRecompensasApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Digite o número de dias consecutivos logados: ");
            int diasConsecutivos = int.Parse(Console.ReadLine());

           
            Console.Write("Digite a recompensa inicial em moedas no primeiro dia: ");
            int recompensaInicial = int.Parse(Console.ReadLine());

            
            Console.Write("Digite o incremento da recompensa a cada dia consecutivo: ");
            int incrementoDiario = int.Parse(Console.ReadLine());

           
            int totalMoedas = 0;
            int recompensaAtual = recompensaInicial;

            
            for (int i = 1; i <= diasConsecutivos; i++)
            {
                totalMoedas += recompensaAtual;
                recompensaAtual += incrementoDiario;
            }

           
            Console.Write("Deseja considerar bônus por marcos de dias? (Sim/Não): ");
            string consideraBonus = Console.ReadLine().Trim().ToLower();

            if (consideraBonus == "sim")
            {
               
                Console.Write("A cada quantos dias consecutivos há um bônus? ");
                int marcosDeDias = int.Parse(Console.ReadLine());

                Console.Write("Qual é o valor do bônus em moedas? ");
                int bonus = int.Parse(Console.ReadLine());

               
                int numeroBonuses = diasConsecutivos / marcosDeDias;
                totalMoedas += numeroBonuses * bonus;
            }

            
            Console.WriteLine($"\nTotal de moedas acumuladas: {totalMoedas}");
        }
    }
}
