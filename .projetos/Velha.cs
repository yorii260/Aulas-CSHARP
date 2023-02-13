using System;

namespace Advinhar
{
    class MainProgram
    {
        public static void Main(){
            MenuGame game = new MenuGame("Hard");
            game.setEventLoop();
            
        }
    }

    class MenuGame
    {
        public int rodadas;
        public string esc;
        public MenuGame(string difficult)
        {
            esc=difficult;
            if (esc == "Hard"){this.rodadas=30;} else if(esc == "Easy"){this.rodadas = 60;} else{this.rodadas = 40;}
            Console.WriteLine("Você escolheu {0} como dificuldade.\nRodadas: {1}\n", esc, this.rodadas);
        }

        public int setDiffcult()
        {
            Random r = new Random();
            if(esc == "Hard")
            {
                return r.Next(100);
            }
            else if(esc == "Easy") 
            {
                return r.Next(20);
            }
            else
            {
                return r.Next(50);
            }
        }

        public void setEventLoop()
        {
            int z = 0;
            ini:
            for(int y = 0; y < rodadas; y++)
            {
                Console.WriteLine("Bora! tente advinhar, você tem {0} chances, digite: ",rodadas-y);
                z = int.Parse(Console.ReadLine());

                if(z == setDiffcult())
                {
                    Console.Clear();
                    string x;
                    Console.WriteLine("Boa! você acertou! hehe, que tal tentar novamente?\n[S/N]\n: ");
                    x = Console.ReadLine();

                    if (x == "S")
                    {
                        Console.Clear();
                        goto ini;
                    }else
                    {
                        break;
                    }
                
                }else 
                {
                    Console.Clear();
                    Console.WriteLine("Uuh! errou, tente novamente :)\n");
                }
                
            }
            Console.Clear();
            Console.WriteLine("Baah, que triste, suas rodadas acabaram, tente novamente!");
        }
    }
}



