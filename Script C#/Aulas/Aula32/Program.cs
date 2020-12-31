using System;

namespace Aula32
{

    public class dados{

        public int v1;
        public int v2;

        public dados(int v1,int v2){

            this.v1=v1;
            this.v2=v2;

        }

        public int soma(){

            return v1+v2;
            
        }

    }
    class Program
    {
        static void Main()
        {   

            int num;        
            dados c=new dados(5,10);

            num=c.soma();

            Console.Write(num);

        }
    }
}
