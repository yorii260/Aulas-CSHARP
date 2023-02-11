using System;

namespace Curso{
    class Aula25{
        public static void Main(){

            int n=100;
            dobrar(ref n);
            Console.WriteLine(n);
        }
        static int somar(int i, int y){
            return i+y;
        }

        static void dobrar(ref int v){
            v*=2;
        }
    }
}