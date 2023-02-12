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

        public void setRodas(int rodas){
            if(rodas<0){
                this.rodas=0;
            }else if (rodas>10){
                this.rodas=10;
            }else{
                this.rodas=rodas;
            }
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

    class CarroDeLuxo:Carro{

        public int pessoas;
        public CarroDeLuxo():base("Limousine", "Verde", 350){
            pessoas=6;
            setRodas(5);
        }
    }
    
    public class Aula35{
        static void Main(){
            Carro c1 = new Carro(nome: "Supra",cor: "Preto", VelMax: 360);
            CarroDeLuxo c2 = new CarroDeLuxo();

            Console.WriteLine("Nome: {0}\nCor: {1}\nRodas: {2}\nEstado: {3}\nVel. Máxima: {4}",
            c1.nome,
            c1.cor,
            c1.getRodas(),
            c1.getStatus(),
            c1.VelMax);

            Console.WriteLine("\nNome: {0}\nCor: {1}\nRodas: {2}\nEstado: {3}\nVel. Máxima: {4}\nPessoas: {5}",
            c2.nome,
            c2.cor,
            c2.getRodas(),
            c2.getStatus(),
            c2.VelMax,
            c2.pessoas
            );
        }
    }
}