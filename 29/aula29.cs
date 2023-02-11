using System;

namespace Curso
{
    public class Jogador{

        public int energia;
        public bool vivo;
        public string nome;

        public Jogador(string n){
            energia=100;
            vivo=false;
            nome=n;
        }

        ~Jogador(){
            Console.WriteLine("Jogador foi destruído.");
        }

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
        public void Nome(){
            Console.WriteLine("Nome do jogador: {0}",nome);
        }


    }
    class Aula29{
        static void Main(){
            Jogador j1 = new Jogador("Bruno");
            j1.Vivo();
            j1.Energia();
            j1.Nome();
        }


    }


    
}