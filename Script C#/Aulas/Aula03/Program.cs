using System;

namespace Aula03
{
    class Program
    {
        static void Main()
        {

            int n1,n2,res;

            n1=10;
            n2=30;
            res=n1+n2;

            //Formatação de string

            string texto=String.Format("A soma de {0} e {1} é igual à {2}",n1,n2,res);

            Console.Write(texto);

        }
    }
}
