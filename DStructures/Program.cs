using System;
namespace DStructures;

class Program
{
    static void Main(string[] args)
    {
        
        int[] meuArray = {};
        Console.WriteLine("Digite os elemento que deseja no array, separados por espaço: ");
        string[] entrada = Console.ReadLine().Split(' ');
        meuArray = new int[entrada.Length];
        for (int i = 0; i < entrada.Length; i++)
        {
            meuArray[i] = int.Parse(entrada[i]);
        }

        Console.WriteLine("Digite o valor que deseja procurar: ");
        int valorProcurado = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite 1 para busca linear ou 2 para busca binária: ");
        int opcao = int.Parse(Console.ReadLine());
        if (opcao == 1)
        {
            LinearSearch busca = new LinearSearch();
            int resultado = busca.BuscaLinear(meuArray, valorProcurado);
            if (resultado == -1)
            {
                Console.WriteLine("O valor procurado não está no array.");
            }
            else
            {
                Console.WriteLine("O valor procurado está na posição " + resultado);
            }
        }
        else if (opcao == 2)
        {
            BinarySearch busca = new BinarySearch();
            int resultado = busca.BuscaBinaria(meuArray, valorProcurado);
            if (resultado == -1)
            {
                Console.WriteLine("O valor procurado não está no array.");
            }
            else
            {
                Console.WriteLine("O valor procurado está na posição " + resultado);
            }
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }   
    }
}