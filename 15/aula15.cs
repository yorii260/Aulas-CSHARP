using System;

namespace Curso{

    class Aula015
    {
        public static void Main()
        {
            int tempo;
            char escolha;
            string transporte;

            Console.WriteLine(
                "Voô selecionado: Rio Branco/AC to Santa Catarina/FLO\n\n- Selecione o meio de transporte:\n(A) - Carro\n(B) - Avião\n(C) - Ônibus"
            );

            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'A':
                    transporte = "Carro";
                    tempo = 480;
                    break;
                case 'B':
                    transporte = "Avião";
                    tempo = 50;
                    break;
                case 'C':
                    transporte = "Ônibus";
                    tempo = 660;
                    break;
                default:
                    tempo = 0;
                    transporte = "Não Selecionado.";
                    break;
            }

            float convert = tempo/60;

            if (tempo == 0)
            {
                Console.WriteLine(
                    "Você não selecionou uma opção válida."
                );
            }else{ 
                Console.WriteLine(
                    "Você selecionou {0} como seu meio de transporte.\nTempo: {1} horas.", transporte, convert
                );
            }


        }
    }
}