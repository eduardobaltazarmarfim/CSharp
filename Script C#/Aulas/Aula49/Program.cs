using System;

namespace Aula49
{
    class Mat{

        public static double pi=3.14;

        public static int dobro(int n1){

            return n1*2;

        }

    }
    class Program
    {
        static void Main()
        {
            double vp1=Mat.pi;
            
            Console.Write(Mat.dobro(10));

        }
    }
}
