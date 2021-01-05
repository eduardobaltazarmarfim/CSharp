using System;

namespace Aula45
{
    struct Carro{

        public string marca;

        public void info(){

            Console.WriteLine("Marca {0}",marca);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros=new int[10];

            Carro[] c1=new Carro[4];

            c1[0].marca="HRV";
            c1[1].marca="GOL";
            c1[2].marca="BMW";
            c1[3].marca="FIAT";

            for(int i=0;i<c1.Length;i++){

                c1[i].info();
            }
        }
    }
}
