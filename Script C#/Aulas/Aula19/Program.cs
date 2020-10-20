using System;

namespace Aula19
{
    class Program
    {
        static void Main()
        {   

            int[] num=new int[10];

            int i,x=0;

            for(i=0;i<10;i++){

                num[x]=i;

                x++;
            }

            for(i=0;i<10;i++){

                Console.WriteLine(num[i]);
            }
  
        }
    }
}
