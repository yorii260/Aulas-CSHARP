using System;

namespace Curso
{
    public class Jogador{

        public int energia=100;
        public bool vivo=true;

        public void Energia(){
            if(vivo==false){energia=0;}
            Console.WriteLine("Energia do jogador é: {0}",energia);
        }
        public void Vivo(){
            string v;
            if (vivo==true){
                v ="Vivo";
            }else{
                v="Morto";
            }

            Console.WriteLine("O jogador está  {0}.", v);
        }


    }
    class Aula28{
        static void Main(){
            Jogador j1 = new Jogador();
            j1.Vivo();
            j1.Energia();
        }


    }


    
}