using System;

namespace Aula51
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length>0){

                Console.WriteLine(args.Length);
                
                for(int i=0;i<args.Length;i++){

                    Console.WriteLine("{0}",args[i]);
                }

            }else{

                Console.WriteLine("Sem argumentos.");
            }
        }
    }
}
