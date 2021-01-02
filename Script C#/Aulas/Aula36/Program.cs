using System;

namespace Aula36
{

    class Veiculo{

        public int velatual;

        private int velmax;

        protected bool ligado;

        public Veiculo(int velmax){

            velatual=0;
            this.velmax=velmax;
            ligado=false;

        }

        public int getvlmax(){

            return velmax;

        }

        public string getligado(){

            return (ligado?"sim":"não");

        }

    } 

    class Carro:Veiculo{

        public string nome;

        public Carro(string nome,int vml):base(vml){

            this.nome=nome;
            ligado=true;

        }

    }

    class Program
    {
        static void Main()
        {
            Carro c1=new Carro("Ferrare",120);

            Console.WriteLine("{0} {1} {2}",c1.nome,c1.getvlmax(),c1.getligado());
        }
    }
}
