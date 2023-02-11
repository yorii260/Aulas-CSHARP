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
    static public class Jogadora{
        static string nome;
        static int idade;
        static bool vivo;

        static public void info(string n, int idd, bool v){
            nome=n;
            idade=idd;
            vivo=v;
        }

        static public void Inicializar(){
            info("Bruna",33,true);
            Console.WriteLine("Nome: {0}\nIdade: {1} anos\nStatus: {2}",nome,idade,vivo);
        }

    }
    class Aula31{
        static void Main(){
            Jogador j1 = new Jogador("Bruno");
            j1.Vivo();
            j1.Energia();
            j1.Nome();
            Console.Clear();
            Jogadora.Inicializar();
        }


    }

    


    
}