using System;
using System.Collections.Generic;

namespace Aula57
{
    class Program
    {
        static void Main()
        {
            
            List<string> carro=new List<string>();
            string[] carros2=new string[10];

            carro.Add("Gol");
            carro.Add("Ferrare");
            carro.Add("Fiat");
            carro.Add("Gipe");

            string c="Fiat";
            int pos=0;

            pos=carro.IndexOf(c);
            Console.Write(pos);

        }
    }
}
