using System;

namespace Aula09
{
    class Program
    {
        static void Main()
        {
            int num;
            
            Console.Write("Digite um valor inteiro: ");
            num=int.Parse(Console.ReadLine());

            num>>=1;

            Console.Write(num);
        }
    }
}
