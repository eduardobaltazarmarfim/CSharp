using System;

namespace Aula38
{

    class Base{

        public Base(){

            Console.WriteLine("Construtor da Classe Base");

        }

        virtual public void info(){

            Console.WriteLine("Base");
        }

    }

    class Derivada:Base{

        public Derivada(){

            Console.WriteLine("Construtor da classe derivada");

        }

        override public void info(){

            Console.WriteLine("Derivada");

        }        

    }

    class Derivada1:Derivada{

        public Derivada1(){

            Console.WriteLine("Construtor da classe derivada1");

        }

        override public void info(){

            Console.WriteLine("Derivada1");

        }

    }    
    class Program
    {
        static void Main(string[] args)
        {   
            Base Ref;
            Derivada1 c1=new Derivada1();
            Derivada c2=new Derivada();

            Ref=c2;

            Ref.info();
           
        }
    }
}
