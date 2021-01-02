using System;

namespace Aula39
{

    abstract class Veiculo{

        protected int vlmax;
        protected int vlatual;

        protected bool ligado;

        public Veiculo(){

            ligado=false;
            vlatual=0;

        }

        public void setligado(bool ligado){

            this.ligado=ligado;

        }

        abstract public void aceleracao(int mult);

        public int getvlatual(){

            return vlatual;
        }

    }

    class Carro:Veiculo{
        
        public Carro(){

            vlmax=120;

        }

        override public void aceleracao(int mult){

            vlatual+=mult*10;

            Console.WriteLine("Sua velocidade é {0}",vlatual);

        }

    }
    class Program
    {
        static void Main()
        {
            Reiniciar:

            Console.Clear();

            char resp;
            int num;

            Carro carro1=new Carro();

            Console.Write("Digite sua aceleração: ");
            num=Convert.ToInt32(Console.ReadLine());

            carro1.aceleracao(num);

            Console.Write("Deseja executar novamente?[s/n] ");
            resp=Convert.ToChar(Console.ReadLine());

            if(resp=='s'){

                goto Reiniciar;

            }else{

                Console.WriteLine("Processo finalizado!");
            }           
            
        }
    }
}
