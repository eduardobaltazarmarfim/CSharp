using System;

namespace Aula43
{

    public interface Veiculo{
        
        void ligar();
        void desligar();
        void info();
    }

    public interface Combate{

        void disparar();

    }

    class Carro:Veiculo,Combate{

        public bool ligado;
        private int municao;
        public Carro(){
            

        }

        public int setmunicao{

            get{

                return municao;

            }set{

                municao=value;

            }
        }

        public void ligar(){

            ligado=true;
        }

        public void desligar(){

            ligado=false;
        }

        public void disparar(){

            
        }

        public void info(){


        }

    }
    class Program
    {
        static void Main()
        {
            Carro c1=new Carro();

            c1.setmunicao=20;

            Console.WriteLine("Munição {0}",c1.setmunicao);
                        
        }
    }
}
