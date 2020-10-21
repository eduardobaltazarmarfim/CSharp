using System;

namespace Aula28
{

    public class Jogador{

        public int energia=100;
        public bool vivo=true;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1=new Jogador();
            j1.energia=150;
            Console.Write(j1.energia);
        }
    }
}
