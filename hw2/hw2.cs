using System;

namespace HelloWorld
{
    class Program
    {
        int fun(int *k){
            *k += 4;
            return 3*(*k) - 1;
        }

        static void Main(string[] args)
        {
            int i = 10, j = 10, sum1, sum2;
            sum1 = (i/2) + fun(&i);
            sum2 = fun(&j) + (j/2);
            Console.WriteLine("Hello Wld!");
        }
    }
}