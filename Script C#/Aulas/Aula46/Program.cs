using System;

namespace Aula46
{
    class Galinha{

        private string nomegalinha;
        private int numovo;

        public Galinha(string nomegalinha){

            this.nomegalinha=nomegalinha;
            numovo=0;

        }

        public Ovo botar(){

            numovo+=1;
          
            return new Ovo(numovo,nomegalinha);
        }

    }

    class Ovo{

        private int num;
        private string nomegalinha;
        public Ovo(int num,string nomegalinha){

            this.num=num;
            this.nomegalinha=nomegalinha;

            Console.WriteLine("Galinha {0} quantidade de ovos {1}",this.nomegalinha,this.num);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Galinha g1=new Galinha("Benedita");
            Galinha g2=new Galinha("Sabrina");

            g1.botar();
            g2.botar();
        }
    }
}
