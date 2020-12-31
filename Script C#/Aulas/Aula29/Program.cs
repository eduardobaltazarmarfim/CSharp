using System;

namespace Aula29
{

    public class Jogador{

        public int energia;
        public bool vivo;
        public string nome;
        public Jogador(string n){

            nome=n;
            energia=100;
            vivo=true;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            string nome;

            Console.WriteLine("Digite seu nome: ");
            nome=Console.ReadLine();

            Jogador j1=new Jogador(nome);
            Jogador j2=new Jogador("Maira");
                        
            j1.energia=150;
            Console.WriteLine("O nome do jogador 1 {0} ele tem {1} vidas",j1.nome,j1.energia);
            Console.Write("O nome do jogador 2 {0} e ele está {1}",j2.nome,j2.vivo);
          }
    }
}
