using System;

namespace Curso{
    class Aula26{
        public static void Main(){
            int d1,d2,quoc,rr;
            d1=10;
            d2=5;
            quoc=divide(d1,d2, out rr);
            Console.WriteLine("{0}/{1}: {2}\nResto: {3}",d1,d2,quoc,rr);

        }
        static int somar(int i, int y){
            return i+y;
        }

        static int divide(int dd, int dv, out int resto){
            int q;
            q=dd/dv;
            resto=dd%dv;
            return q;
        }

    }
}
