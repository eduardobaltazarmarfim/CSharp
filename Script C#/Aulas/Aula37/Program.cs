using System;

namespace Aula37
{

    class Base{

        public Base(){

            Console.WriteLine("Construtor da Classe Base");

        }

    }

    class Derivada:Base{

        public Derivada(){

            Console.WriteLine("Construtor da classe derivada");

        }

    }

    class Derivada1:Derivada{

        public Derivada1(){

            Console.WriteLine("Construtor da classe derivada1");

        }

    }

    class Program
    {
        static void Main()
        {
            Derivada1 c1=new Derivada1();

        }
    }
}
