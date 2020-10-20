using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("Olá Eduardo");
            if(args.GetLength(0)>0){

                Console.WriteLine(args.GetValue(0));

            }else{

                Console.WriteLine("Sem parâmetro definido!");
            }
            
        }
    }
}
