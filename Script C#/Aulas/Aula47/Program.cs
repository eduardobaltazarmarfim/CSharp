using System;

namespace Aula47
{

    class cal{

        public int somar(params int[]num){
            
            int res=0;

            for(int i=0;i<num.Length;i++){

                res+=num[i];

            }

            return res;

        }

        public double somar(params double[]num){

            double res=0;

            for(int i=0;i<num.Length;i++){

                res+=num[i];
            }

            return res;

        }
      
    }
    class Program
    {
        static void Main()
        {   
            var num,res;
            int cont=1;
            char resp='s';

            Console.Clear();
                        
            cal calcular=new cal();

            while(resp=='s'){
                
                Console.Write("Digite {0}ª valor: ",cont);
                num=Convert.ToDouble(Console.ReadLine());

                Console.Write("Deseja inserir mais um número?[s/n] ");
                resp=Convert.ToChar(Console.ReadLine());

                res=calcular.somar(num);


            }

            Console.WriteLine("A soma dos valores é {0}",res);                       
                        
        }
    }
}
