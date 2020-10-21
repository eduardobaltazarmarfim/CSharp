using System;

namespace Aula27
{
    class Program
    {
        static void Main(string[] args)
        {
            
            soma(0,15,20);
        }

        static void soma(params int[] dados){

            int res=0;
          
            if(dados.Length<1){

                Console.Write("Não tem dados para ser calculado!");
            
            }else{

                for(int i=0;i<dados.Length;i++){

                    res+=dados[i];
                }

            }

            Console.Write("O resultado Total dos dados é {0}",res);

        }
    }
}
