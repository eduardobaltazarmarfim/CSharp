using System;

namespace Aula30
{

    public class Jogador{

        public string nome;
        public int vidas;

        public void info(){

            Console.WriteLine("Nome do jogador {0} e quantidade de vidas {1}",nome,vidas);
        }

        public Jogador(){

            nome="Eduardo";
            vidas=10;
        }

        public Jogador(string n){

            nome=n;
            vidas=3;
        }

        public Jogador(string n,int num){

            nome=n;
            vidas=num;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            Jogador j1=new Jogador();
            Jogador j2=new Jogador("Maira");
            Jogador j3=new Jogador("Eduardo",100);
                             
            j1.info();
            j2.info();
            j3.info();
  
          }
    }
}
