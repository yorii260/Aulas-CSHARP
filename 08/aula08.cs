using System;

class Aula08
{
    static void Main()

    {
        int v1,v2,soma;
        Console.WriteLine("Digite um valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro valor: ");
        v2 = int.Parse(Console.ReadLine());
        soma=v1+v2;
        Console.WriteLine(
            "A soma entre {0} e {1} é igual a: {2}", v1,v2, soma
        );

        
       
    }
}

// int.Parse() Converte qualquer valor em número inteiro.
// Converter.ToInt32() Mesma coisa;