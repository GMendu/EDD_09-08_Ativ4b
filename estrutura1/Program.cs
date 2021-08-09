using System;

namespace estrutura1
{
    class Program
    {
        static int PlacarP;
        static int PlacarM;
        static string Menu()
        {
            Console.WriteLine("\n╔════════════════════════════╗\n║       CARA ou COROA        ║\n╠════════════════════════════╣\n║ digite 1 para JOGAR        ║\n║ digite 2 para ver o PLACAR ║\n║ digite 3 para FIM          ║\n╚════════════════════════════╝");
            return Console.ReadLine();
        }

        static void Jogar()
        {
            int palpite, moeda;
            Console.WriteLine("quer jogar CARA(0) ou COROA(1)?");
            palpite = int.Parse(Console.ReadLine());
            Random aleat = new Random();
            moeda = aleat.Next(0,2);
            Console.WriteLine(moeda);
            if (palpite == 0)
            {
                Console.WriteLine("Você escolheu cara");
                if (palpite == moeda)
                {
                    Console.WriteLine("A moeda caiu em cara.\nvitória do jogador");
                    PlacarP += 1;
                }
                else
                {
                    Console.WriteLine("A moeda caiu em coroa.\nderrota do jogador");
                    PlacarM += 1;
                }
            }
            if (palpite == 1)
            {
                Console.WriteLine("Você escolheu coroa");
                if (palpite == moeda)
                {
                    Console.WriteLine("A moeda caiu em coroa.\nvitória do jogador");
                    PlacarP += 1;
                }
                else
                {
                    Console.WriteLine("A moeda caiu em cara.\nderrota do jogador");
                    PlacarM += 1;
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Placar()
        {
            Console.WriteLine($"\n╔════════════════════════════════════╗\n║ O placar do jogador foi: {PlacarP}         ║\n║ O jogador errou {PlacarM} palpites         ║\n╚════════════════════════════════════╝");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            string escolha = "0";
            while (escolha != "3")
            {
                escolha = Menu();

                switch (escolha)
                {
                    case "1":
                        {
                            Jogar();
                            break;
                        }
                    case "2":
                        {
                            Placar();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("fim de jogo");
                            break;
                        }
                }
            }
        }
    }
}
