using System;

namespace Aula08
{
    class Program
    {
        static void Main()
        {
            int n1,n2,res;
            
            Console.Write("Digite o primeiro valor: ");
            n1=int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            n2=Convert.ToInt32(Console.ReadLine());

            res=n1+n2;

            Console.Write("A soma de {0} e {1} é igual à {2}",n1,n2,res);
            
        }
    }
}
