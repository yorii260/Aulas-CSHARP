using System;

namespace Curso{
    
    // Classe Base
    class Veiculo
    {
        public int velActually;
        private int velMax;

        protected bool ligado;

        public Veiculo(int velMax){
            velActually=0;
            this.velMax=velMax;
            ligado=false;
        }
        public int getVelMax(){
            return velMax;
        }
        public bool getLigado(){
            return ligado;
        }

    }
   
    class Carro:Veiculo{
        public string nome;
        public Carro(string nome, int vm):base(vm){
            this.nome=nome;
            ligado=true;
        }
    }
// ----------------------------------- //
    class Aula36{
        static void Main() {

            Carro c1 = new Carro("Supra", 350);

            Console.WriteLine(
                "Nome: {0}\nVel. Atual: {1}\nVel. Max: {2}\nLigado: {3}",
                c1.nome,
                c1.velActually,
                c1.getVelMax(),
                c1.getLigado()

            );
        }
    }
}