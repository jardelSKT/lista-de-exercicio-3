using System;

namespace InventarioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar o número de tipos diferentes de itens
            Console.Write("Digite o número de tipos diferentes de itens que deseja armazenar: ");
            int numeroTiposDeItens = int.Parse(Console.ReadLine());

           
            int totalItens = 0;

           
            for (int i = 1; i <= numeroTiposDeItens; i++)
            {
                
                Console.Write($"Digite o nome do item {i}: ");
                string nomeItem = Console.ReadLine();

                Console.Write($"Digite a quantidade de {nomeItem}s: ");
                int quantidadeItem = int.Parse(Console.ReadLine());

               
                totalItens += quantidadeItem;
            }

           
            Console.Write("Digite a capacidade máxima do inventário: ");
            int capacidadeMaxima = int.Parse(Console.ReadLine());

           
            Console.WriteLine($"\nTotal de itens no inventário: {totalItens}");
            
            if (totalItens <= capacidadeMaxima)
            {
                Console.WriteLine("Dentro da capacidade.");
            }
            else
            {
                Console.WriteLine("Excede a capacidade.");
            }
        }
    }
}
