using System;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor,pos=0,x=0;

            int[] num=new int[10];

            Console.Clear();
                        
            while(pos<num.Length){

                
                Console.Write("Digite o {0}º valor: ",(++x));
                valor=int.Parse(Console.ReadLine());

                num[pos]=valor;

                pos++;

            }

            Console.Write("Valor digitados: ");

            for(int i=0;i<num.Length;i++){

                if(i<=8){

                    Console.Write("{0}, ",(num[i]));
                    
                }else{

                    Console.Write("{0}",(num[i]));

                }

                
            }
        }
    }
}
