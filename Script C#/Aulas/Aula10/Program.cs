using System;

namespace Aula10
{
    class Program
    {   
        enum Semana{Dom,Seg,Ter,Qua,Qui,Sex,Sáb};
        static void Main()
        {
           int ds= (int)Semana.Dom;
           Console.Write(ds);
        }
    }
}
