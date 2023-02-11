using System;

namespace Curso{
    class Aula24{
        public static void Main(){

            for(
                int i = 0;
                i<5;
                i++
            )
            {
                somar(20,22);
            }    
        }
        static void somar(int i, int y){
            Console.WriteLine("A soma de {0}+{1}: {2}",i,y,i+y);
        }
    }
}