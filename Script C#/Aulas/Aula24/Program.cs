using System;

namespace Aula24
{
    class Program
    {
        static void Main()
        {   

            string dados;
            char resp;

            inicio:

            Console.Clear();

            Console.Write("Digite um texto: ");
            dados=Console.ReadLine();
                        
            ola(dados);

            Console.Write("Deseja executar novamente?[s/n]: ");
            resp=char.Parse(Console.ReadLine());

            if(resp=='s'|| resp=='S'){

                goto inicio;

            }else{

                Console.Write("Processo finalizado com sucesso!");
            }
        }

        static void ola(string texto){
            
            Console.WriteLine(texto);

        }
    }
}
