using System;

namespace Curso
{
    class Veiculo{ // Classe Base

        public int VelMax=0;
        private bool ligado;

        private int rodas;

        public Veiculo(int rodas){
            this.rodas = rodas;
        }
        public void Ligar(){
            ligado=true;
        }
        public void Desligar(){
            ligado=false;
        }

        public string getStatus(){
            return (ligado?"O carro está ligado":"O carro está desligado");
        }
        public int getRodas(){
            return rodas;
            
        }
    }

    class Carro:Veiculo{ // Herdou a classe base.
        public string nome;
        public string cor;

        public Carro(string nome, string cor, int VelMax):base(rodas: 4){ // Classe Derivada
            Ligar();
            this.nome=nome;
            this.cor=cor;
            this.VelMax=VelMax;
        }
    }
    
    public class Aula35{
        static void Main(){
            Carro c1 = new Carro(nome: "Supra",cor: "Preto", VelMax: 360);
            Console.WriteLine("Nome: {0}\nCor: {1}\nRodas: {2}\nEstado: {3}\nVel. Máxima: {4}",
            c1.nome,
            c1.cor,
            c1.getRodas(),
            c1.getStatus(),
            c1.VelMax);
        }
    }
}