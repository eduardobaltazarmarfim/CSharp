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
            
            Console.Clear();

            double res=0,num=0;
            char resp='s';
            int cont=1;
                                    
            cal calcular=new cal();

            while(resp=='s'){

                Console.Write("Digite o {0}º valor: ",cont);
                num=Convert.ToDouble(Console.ReadLine());

                Console.Write("Deseja executar novamente?[s/n] ");
                resp=Convert.ToChar(Console.ReadLine());

                cont+=1;

                res+=calcular.somar(num);               

            }            

            Console.WriteLine("A soma dos valores é {0}",res);                       
                        
        }
    }
}
