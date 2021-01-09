using System;

namespace Aula51
{
    class Program
    {
        static void Main(string[] args)
        {

            int res=0;

            if(args.Length>0){

                Console.WriteLine(args.Length);
                
                for(int i=0;i<args.Length;i++){

                    res+=Int32.Parse(args[i]);
                    
                }

                Console.WriteLine("{0}",res);

            }else{

                Console.WriteLine("Sem argumentos.");
            }
        }
    }
}
