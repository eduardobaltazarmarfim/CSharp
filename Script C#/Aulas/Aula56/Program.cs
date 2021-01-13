using System;
using System.Collections.Generic;

namespace Aula56
{
    class Program
    {
        static void Main()
        {
            LinkedList<string> transporte=new LinkedList<string>();

            transporte.AddFirst("Carro");
            transporte.AddFirst("Ônibus");
            transporte.AddFirst("Trêm");
            transporte.AddFirst("Avião");
            transporte.AddFirst("Moto");

            transporte.AddLast("Bicicleta");

            LinkedListNode<string> texto;
            
            texto=transporte.FindLast("Trêm");

            transporte.AddAfter(texto,"Patinete");

            transporte.AddBefore(texto,"Skite");
                       
            foreach(string v in transporte){

                Console.WriteLine(v);

            }

            Console.WriteLine(transporte.Count);
        }
    }
}
