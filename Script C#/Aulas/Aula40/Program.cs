using System;

namespace Aula40
{

    sealed class Veiculo{

        public string nome;

        public Veiculo(){

            nome="Eduardo";
            
        }

    }


    class Program
    {
        static void Main()
        {
            Veiculo c1=new Veiculo();

            Console.WriteLine(c1.nome);
        }
    }
}
