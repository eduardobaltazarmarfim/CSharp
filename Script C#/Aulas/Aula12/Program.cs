using System;

namespace Aula12
{
    class Program
    {
        static void Main()
        {
            int num;
            
            Console.Write("Digite um nota: ");
            num=Convert.ToInt32(Console.ReadLine());

            if(num>=60){

                Console.Write("Aprovado");

            }else{

                Console.Write("Reprovado");

            }

        }
    }
}
