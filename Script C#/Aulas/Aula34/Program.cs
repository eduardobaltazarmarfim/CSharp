using System;

namespace Aula34
{
    class Veiculo{

        public int rodas;
        public int velmax;
        private bool ligado;

        public void ligar(){

            ligado=true;
            
        }

        public void desligar(){

            ligado=false;

        }

        public bool getligado(){

            return ligado;

        }

    }

    class Carro:Veiculo{

        public string nome;
        public string cor;
        public Carro(string nome, string cor){

            desligar();
            rodas=4;
            velmax=120;
            this.nome=nome;
            this.cor=cor;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            Carro vc =new Carro("Ferrare","Vermelho");

            if(vc.getligado()){

             Console.WriteLine("A carro usado é {0} a cor dele é {1} ele tem {2} rodas ele está {3}, andando à {4} Km",vc.nome,vc.cor,vc.rodas,vc.velmax); 

            }else{

                Console.WriteLine("Carro desligado");

            }

        }
    }
}
