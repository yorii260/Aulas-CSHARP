using System;

namespace Curso
{
    class Veiculo{ // Classe Base

        public int VelMax=0;
        public bool ligado;

        public int rodas;

        public void Ligar(){
            ligado=true;
        }

        public void desligar(){
            ligado=false;
        }

        public string getStatus(){
            if(ligado==true){return "Carro Ligado.";}else{return "Carro Desligado";}
        }
    }

    class Carro:Veiculo{ // Herdou a classe base.
        public string nome;
        public string cor;

        public Carro(string nome, string cor, int VelMax){ // Classe Derivada
            desligar();
            rodas=4;
            this.nome=nome;
            this.cor=cor;
            this.VelMax=VelMax;
        }
    }
    
    public class Aula34{
        static void Main(){
            Carro c1 = new Carro(nome: "Supra",cor: "Preto", VelMax: 360);
            Console.WriteLine("Nome: {0}\nCor: {1}\nRodas: {2}\nEstado: {3}\nVel. Máxima: {4}",
            c1.nome,
            c1.cor,
            c1.rodas,
            c1.getStatus(),
            c1.VelMax);
        }
    }
}