using System;

namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.Write("Digite um valor: ");
            valor=int.Parse(Console.ReadLine());

            Console.Write("O dobro de {0} é {1}",valor,dobrar(valor));
        }

        static int dobrar(int num){

            return num*=2;

        }
    }
}
