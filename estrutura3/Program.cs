using System;

namespace estrutura3
{
    class Program
    {
        static int pontos = 0, buraco = 0, mina = 0, monstro = 0;
        static string PedirNome()
        {
            Console.WriteLine("Qual seu nome, bravo herói?");
            return Console.ReadLine();
        }
        static int CairBuraco(string name,int vida)
        {
            buraco++;
            Console.WriteLine($"{name} se espatifou ao cair em um buraco\n");
            return vida-1;
        }
        static int PisarMina(string name, int vida)
        {
            mina++;
            Console.WriteLine($"{name} ficou em pedaços ao pisar em uma mina\n");
            return vida-1;
        }
        static int Devorado(string name, int vida)
        {
            monstro++;
            Console.WriteLine($"{name} foi devorado por um monstro\n");
            return vida-1;
        }
        static void Placar(string name)
        {
            Console.WriteLine($"fim de jogo para {name}\nPontuação:{pontos}\nMortes por queda:{buraco}\nMortes por explosão:{mina}\nMortes por monstros:{monstro}");
        }
        static void Seguro(string name)
        {
            pontos++;
            Console.WriteLine($"{name} se safou dos perigos na aventura");
        }
        static void Main(string[] args)
        {
            int vidas = 5;
            string nome = PedirNome();
            while (vidas > 0)
            {
                Random rnd = new Random();
                int possibilidade = rnd.Next(1, 10);
                switch (possibilidade)
                {
                    case 1:
                        {
                            vidas = CairBuraco(nome,vidas);
                            break;
                        }
                    case 2:
                        {
                            vidas = PisarMina(nome,vidas);
                            break;
                        }
                    case 3:
                        {
                            vidas = Devorado(nome,vidas);
                            break;
                        }
                    default:
                        {
                            Seguro(nome);
                            break;
                        }
                }
            }
            Placar(nome);
        }
    }
}
