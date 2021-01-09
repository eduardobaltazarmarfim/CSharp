using System;

namespace Aula50
{

    delegate int operacao(int n1,int n2);
    class Mat{

        public static int soma(int n1,int n2){

            return n1+n2;

        }

        public static int mult(int n1,int n2){

            return n1*n2;
        }
        
    }

    class Program
    {
        static void Main()
        {   

            int res;

            operacao cp1=new operacao(Mat.soma);

            res=cp1(10,15);

            Console.WriteLine(res);

            cp1=new operacao(Mat.mult);

            res=cp1(15,20);

            Console.WriteLine(res);
        }
    }
}
