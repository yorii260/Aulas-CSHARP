
using System;

namespace Calculadora
{
    class Program
    {
        public static void Main()
        {
            int[] notas = new int[10];
            string[] alunos = new string[3];
            int i = 0;
            string aluno = "";
            int nota = 0;
            int c = 0;
            bool t = true;
            for (int x = 0; x <= 9; x++)
            {
                if (c == 4)
                {
                    t = true;
                }
                if (t == false)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a {0}. nota do aluno {1}: ", c, alunos[i - 1]);
                    nota = Convert.ToInt32(Console.ReadLine());
                    notas[x - 1] = nota;
                    c++;

                }
                if (
                    x == 3 | x == 6 | x == 10 | x == 0
                )
                {
                    Console.Clear();
                    Console.WriteLine("- Digite o nome do seu {0}. aluno(a): ", i + 1);
                    aluno = Console.ReadLine();
                    alunos[i] = aluno;
                    c = 1;
                    i++;
                    t = false;

                }


            }


            Console.Clear();

            Console.WriteLine("Eo resultado final foi o seguinte:\n\n- {0}:\n1. Nota: {1}\n2. Nota: {2}\n3. Nota: {3}\n\n{4}:\n1. Nota: {5}\n2. Nota: {6}\n3. Nota: {7}\n\n{8}:\n1 Nota: {9}\n2. Nota: {10}\n3. Nota: {11}",
            alunos[0],

            notas[0],
            notas[1],
            notas[2],

            alunos[1],

            notas[3],
            notas[4],
            notas[5],

            alunos[2],

            notas[6],
            notas[7],
            notas[8]
            );

            int aluno1 = (notas[0] + notas[1] + notas[2]) / 3;
            int aluno2 = (notas[3] + notas[4] + notas[5]) / 3;
            int aluno3 = (notas[6] + notas[7] + notas[8]) / 3;

            int Aprovado = 6;
            int Reprovado = 3;
            int Rec = 5;

            string aluno1_status = "";
            string aluno2_status = "";
            string aluno3_status = "";
            if (aluno1 >= Aprovado) { aluno1_status = "Aprovado"; } else if (aluno1 <= Rec) { aluno1_status = "Recuperação"; } else if (aluno1 <= Reprovado) { aluno1_status = "Reprovado"; }
            if (aluno2 >= Aprovado) { aluno2_status = "Aprovado"; } else if (aluno2 <= Rec) { aluno2_status = "Recuperação"; } else if (aluno2 <= Reprovado) { aluno2_status = "Reprovado"; }
            if (aluno3 >= Aprovado) { aluno3_status = "Aprovado"; } else if (aluno3 <= Rec) { aluno3_status = "Recuperação"; } else if (aluno3 <= Reprovado) { aluno3_status = "Reprovado"; }

            Console.WriteLine("\n\nAs notas finais dos respectivos alunos foram:\n{0}: {1} | {2}\n{3}: {4} | {5}\n{6}: {7} | {8}",

            alunos[0],
            aluno1,
            aluno1_status,

            alunos[1],
            aluno2,
            aluno2_status,

            alunos[2],
            aluno3,
            aluno3_status


            );
        }
    }


}