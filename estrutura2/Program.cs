using System;
using System.Collections.Generic;

namespace estrutura2
{
    class Program
    {
        static List<int> numeros = new List<int>();
        static string Menu()
        {
            Console.WriteLine("O que deseja realizar? (1)INSERIR, (2)CRESCENTE, (3)DECRESCENTE, (4)MAIOR, (5)MENOR e (6)SAIR; ");
            string escolha = Console.ReadLine();
            Console.Clear();
            return escolha;
        }
        static void Inserir()
        {
            for(int i=0;i<10;i++)
            {
                Console.Write($"{i+1}º número:");
                numeros.Add(int.Parse(Console.ReadLine()));
            }        
        }
        static void Imprimir()
        {
            foreach (int numero in numeros)
                Console.WriteLine(numero);
        }
        static void Maior()
        {
            int maior = -999999999;
            foreach(int numero in numeros)
            {
                if(numero > maior)
                {
                    maior = numero;
                }
            }
            Console.WriteLine($"O maior número é {maior}");
        }

        static void Menor()
        {
            int menor = 999999999;
            foreach (int numero in numeros)
            {
                if (numero < menor)
                {
                    menor = numero;
                }
            }
            Console.WriteLine($"O menor número é {menor}");
        }

        static void Main(string[] args)
        {
            string escolha = "0";
            while (escolha != "6")
            {
                escolha = Menu();

                switch (escolha)
                {
                    case "1":
                        {
                            Inserir();
                            break;
                        }
                    case "2":
                        {
                            numeros.Sort();
                            Console.WriteLine("números em ordem crescente");
                            Imprimir();
                            break;
                        }
                    case "3":
                        {
                            numeros.Reverse();
                            Console.WriteLine("números em ordem decrescente");
                            Imprimir();
                            break;
                        }
                    case "4":
                        {
                            Maior();
                            break;
                        }
                    case "5":
                        {
                            Menor();
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("fim");
                            break;
                        }
                }
            }
        }
    }
}