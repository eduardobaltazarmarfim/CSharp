using System;

namespace Aula35
{

    class Veiculo{

        public int vlmax;
        private bool ligado;

        private int rodas;

        public Veiculo(int rodas){

            this.rodas=rodas;
         
        }

        public bool getligar(){

            ligado=true;
            return ligado;

        }

        public bool getdesligar(){

            ligado=false;

            return ligado;

        }


        public int getrodas(){

            return rodas;

        }

    }


    class Carro:Veiculo{

        public Carro():base(4){

            vlmax=120;
            getligar();

        }

    }

    class Carrocombate:Carro{



    }

    class Program
    {
        static void Main()
        {
            Carrocombate c1=new Carrocombate();

            Console.WriteLine("{0} {1} {2}",c1.getrodas(),c1.getligar(),c1.vlmax);
        }
    }
}
