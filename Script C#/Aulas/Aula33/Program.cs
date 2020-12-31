using System;

namespace Aula33
{

    class Jogador{

        private int energia;
        private string nome;

        public Jogador(string nome){

            this.nome=nome;
            energia=100;

        }

        public int getenergia(){

            return energia;
        }

        public string getnome(){

            return nome;

        }

        public void setenergia(int energia){

            if(energia<0){

                if(this.energia-energia<0){

                    this.energia=0;

                }else{

                    this.energia+=energia;

                }

            }else if(energia>0){

                if(this.energia+energia>100){

                    this.energia=100;

                }else{

                    this.energia+=energia;

                }

            }

        }

    }

    class Program
    {        
        static void Main(string[] args)
        {
            Jogador j1=new Jogador("Eduardo");

            j1.setenergia(-50);

            Console.WriteLine("{0},{1}",j1.getnome(),j1.getenergia());
        }
    }
}
