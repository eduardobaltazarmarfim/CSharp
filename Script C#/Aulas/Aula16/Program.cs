using System;

namespace Aula16
{
    class Program
    {
        static void Main()
        {
            int num;
            char resp;

            inicio:

            Console.Clear();

            Console.WriteLine("Escolha um opção:\n1-Ônibus\n2-Avião\n3-Carro\n4-Moto");
            Console.Write("Escolha um opção: ");
            num=int.Parse(Console.ReadLine());

            switch(num){

                case 1:

                    Console.Write("Ônibus");
                    break;

                case 2:

                    Console.Write("Avião");
                    break;

                case 3:

                    Console.Write("Carro");
                    break;

                case 4:

                    Console.Write("Moto");
                    break;

            }

            Console.Write("\nDeseja executar o programa novamente?[s/n]: ");
            resp=char.Parse(Console.ReadLine());

            if(resp=='s' || resp=='S'){

                goto inicio;

            }else{

                Console.Clear();
                Console.Write("Processo finalizado com sucesso!");
            }

        }
    }
}
