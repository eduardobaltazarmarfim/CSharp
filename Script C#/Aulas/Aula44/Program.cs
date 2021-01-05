using System;

namespace Aula44
{

    struct Carro{

        public string marca;
        public string modelo;
        public string cor;

        public Carro(string marca,string modelo,string cor){

            this.marca=marca;
            this.modelo=modelo;
            this.cor=modelo;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro c1=new Carro("Honda","HRV","Prata");

            
            Console.Write(c1.marca);
        }
    }
}
