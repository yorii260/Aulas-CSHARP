using System;

namespace Curso 
{
    class Aula22
    {
        public static void Main() 
        {
            int[] i = new int[3]{1,2,3};

            foreach(int x in i){
                object value = Console.WriteLine(x+1);
            }
        }
    }
}