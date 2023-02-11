using System;

namespace Curso 
{
    class Aula23 
    {
        public static void Main()
        {
            int[] idades = new int[5]{17,22,34,12,65};
            int[] anos = new int[5]{2022,2023,2016,2019,2015};
            int[] copy = new int[10];

            int[,] list = new int[2,5]{{1,2,3,4,5}, {1,2,3,4,5}};

            // GetUpperBound
            object value = anos.GetUpperBound(0);
            Console.WriteLine("Maior indice da array: {0}\n",value);

            // GetLowerBound

            object item = anos.GetLowerBound(0);
            Console.WriteLine("Menor índice da array: {0}\n",item);

            // GetValue

            object gvalue = idades.GetValue(2);
            Console.WriteLine("O valor da posição específicada é: {0}\n",gvalue);

            // IndexOf

            object index = Array.IndexOf(anos, 2022);
            Console.WriteLine("A posição do valor específicado é de: {0}\n",index);

            // LastIndexOf

            object last = Array.LastIndexOf(idades, 12);
            Console.WriteLine("A posição do valor específicado é de: {0}\n",last); // Lembrando que esse metódo retorna sempre o ultimo valor encontrado na array, diferente do IndexOf.

            // Reverse

            Array.Reverse(anos);
            foreach(int x in anos){Console.WriteLine(x);}
            Console.WriteLine("--------------------------------------");

            // SetValue

            idades.SetValue(32, 3);
            foreach(int c  in idades){Console.WriteLine(c);}
            Console.WriteLine("---------------------------------------");
            
            // Sort

            Array.Sort(anos);
            foreach(int x in anos){Console.WriteLine(x);}
            Console.WriteLine("---------------------------------------");

            // BinarySearch

            int searched = 2022;
            int search = Array.BinarySearch(anos, searched);
            Console.WriteLine("O valor {0} está na posição: {1}",searched,search);

            // Copy

            Array.Copy(idades, copy, idades.Length);
            foreach(int i in copy){Console.WriteLine(i);}
            Console.WriteLine("---------------------------------------");

            // CopyTo

            anos.CopyTo(copy, 2);
            foreach(int i in copy){Console.WriteLine(i);}
            Console.WriteLine("---------------------------------------");

            // GetLongLength

            object a = idades.GetLongLength(0);
            Console.WriteLine(a);





        }
    }
}