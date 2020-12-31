using System;

namespace Aula31
{

   static public class Jogador{

        static public string nome;
        static public int vidas;

        static public void info(){

            Console.WriteLine("Nome do jogador {0} e quantidade de vidas {1}",nome,vidas);
        }

        static public void iniciar(string n){

            nome=n;
            vidas=10;
        }

    }

    class inimigo
    {

        static public bool alerta;
        public string nome;

        public inimigo(string n){

            alerta=false;
            nome=n;

        }

        public void info(){

            Console.WriteLine("{0},{1}",nome,alerta);
            Console.WriteLine("---------------");
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            Jogador.iniciar("Eduardo");
            Jogador.info();

            inimigo i1=new inimigo("Eduardo");
            inimigo i2=new inimigo("Dayane");

            inimigo.alerta=true;

            i1.info();
            i2.info();
  
          }
    }
}
