using System;

namespace Aula52
{

    class Area{

        public static float quadrado(float n1,float n2){
                
            if(n1==0||n2==0){

                    throw new Exception("Base de valor invalida!");
            }else{

                return n1*n2;

            }
            

        }
    }
    class Program
    {
        static void Main()
        {

            float area=0;
            
            try{

                area=Area.quadrado(0f,0f);
                Console.WriteLine(area);

            }catch(Exception erro){

                Console.WriteLine("ERRO: {0}",erro.Message);

            }
            
            
        }
    }
}
