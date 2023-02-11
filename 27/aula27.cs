using System;

namespace Curso{
    class Aula27{
        public static void Main(){
            Soma(10,20,30,40,50,60,70,80,90,100);
        }

        static void Soma(params int[]n){
            int result=0;


            if(n.Length < 1 | n.Length < 2){
                Console.WriteLine("Você deve definir dois valores para realizar uma soma!");

            }else{
                foreach(int i in n){
                    result += i;
                }
                Console.WriteLine("A soma de todos os valores definidos é de: {0}",result);
            }
        
        }
    }
}