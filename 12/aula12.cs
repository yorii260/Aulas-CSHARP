using System;

namespace Curso
{
    class Aula12
    {
        static void Main()
        {
            int nota01, nota02, nota03, resultado;

            Console.WriteLine("Digite a 1a nota do aluno(a): ");
            nota01=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2a nota do aluno(a): ");
            nota02=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 3a nota do aluno(a): ");
            nota03=int.Parse(Console.ReadLine());

            resultado=(nota01+nota02+nota03)/3;

            if (resultado >= 7) {
                Console.WriteLine("--------------- Aluno Aprovado --------------");
            }else{
                Console.WriteLine("--------------- Aluno Reprovado --------------");

            }
            Console.WriteLine(
                "A média final do seu aluno(a) é de: {0}",resultado
            );
        }
    }
}