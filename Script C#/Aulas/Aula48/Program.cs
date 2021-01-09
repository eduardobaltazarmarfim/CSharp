using System;

namespace Aula48
{

    class calc{

        public int res;

        public calc(){



        }

        public int fatorial(int n1){

            if(n1<=1){

                res=1;

            }else{
                
                res=n1*fatorial(n1-1);

            }

            return res;
            
        }

    }

    class Program
    {
        static void Main()
        {
            calc calcular=new calc();

            int num,num1;

            Console.Write("Favor informar um número para o calculo: ");
            num1=int.Parse(Console.ReadLine());

            num=calcular.fatorial(num1);

            Console.Write("O fatorial de {0} é {1}",num1,num);
            
        }
    }
}
