using System;

namespace Aula06
{
    class Program
    {
        static void Main()
        {

            double valorcompra=5.50;
            double valorvenda;
            double lucro=0.1;
            string produto="Pastel";

            valorvenda=valorcompra/(1-lucro);

            Console.WriteLine("Produto........{0,15}",produto);
            Console.WriteLine("Val. Compra........{0,15:c}",valorcompra);
            Console.WriteLine("Lucro de Venda........{0,15:p}",lucro);
            Console.WriteLine("Produto........{0,15:c}",valorvenda);


        }
    }
}
