using System;

namespace Aula18
{
    class Program
    {
        static void Main()
        {   
            //matriz
            int[,] num=new int[3,3];

            num[0,0]=11;
            num[0,1]=12;
            num[0,2]=15;
            num[1,0]=1;
            num[1,1]=50;
            num[1,2]=60;
            num[2,0]=25;
            num[2,1]=32;
            num[2,2]=6;
            
            Console.Write(num[1,2]);

        }
    }
}
