using System;

namespace Aula41
{

    class Carro{

        private int vlmax;

        public int vm{

            get{

                return vlmax;

            }set{

                if(value<0){

                    vlmax=0;
                }else if(value>100){

                    vlmax=100;
                }else{

                    vlmax=value;
                }

            }
        }
        public Carro(){

            vm=150;

        }

    }
    class Program
    {
        static void Main()
        {
            Carro c1=new Carro();

            c1.vm=50;

            Console.WriteLine("Velocidade {0}",c1.vm);
        }
    }
}
