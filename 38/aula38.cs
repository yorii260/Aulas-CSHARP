using System;

class Base{

    public Base(){
        Console.WriteLine("Construtor da classe base.");
    }

    virtual public void Info(){
        Console.WriteLine("Base");
    }
}

class Derivado:Base{

    public Derivado(){
        Console.WriteLine("Construtor da classe derivada.");
    }
    override public void Info(){
        Console.WriteLine("Derivado");
    }
}
class Derivado2:Derivado{

    public Derivado2(){
        Console.WriteLine("Construtor da classe Derivada2.");
    }
}

namespace Curso{

    class Aula38{
        static void Main(){
            Base Ref;
            Derivado2 d = new Derivado2();

            Ref=d;
            d.Info();
            Ref.Info();
        }
    }
}