using System;

namespace Aula42
{

    class Carro{

        private  int[] velmax=new int[5]{80,120,160,240,390};
        
        public int this[int i]{

            get{

                return velmax[i];

            }set{

                if(value<0){

                    velmax[i]=0;
                }else if(value>100){

                    velmax[i]=100;
                }else{

                    velmax[i]=value;
                }

            }

        }

    }
    class Program
    {
        static void Main()
        {
            Carro c1=new Carro();

            Console.Write("Dados da lista: ");

            for(int i=0;i<5;i++){

                Console.Write(" {0} ",c1[i]);

            }

        }
    }
}
