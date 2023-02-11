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
                Console.WriteLine(somar(20,22));
            }    
        }
        static int somar(int i, int y){
            return i+y;
        }
    }
}