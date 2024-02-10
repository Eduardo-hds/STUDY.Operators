using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operadores \n");
            
            int a = 5;
            int b = 7;
            int c = 10;

            Console.WriteLine("Subtraction \n");

            Console.WriteLine("The Subtraction between {0} - {1} - {2} is equal to: {3} \n", a ,b ,c ,(a - b - c )) ;


            Console.WriteLine("Addition \n");

            Console.WriteLine("The some between {0} + {1} + {2} is equal to: {3} \n", a ,b, c, (a + b + c));


            Console.WriteLine("Multiplication \n");

            Console.WriteLine("The multiplication between {0} * {1} * {2} is equal to: {3} \n", a , b , c , (a * b * c));


            Console.WriteLine("Division \n");

            Console.WriteLine("The division between {0} / {1} is equal to: {2} \n", c , a, (c / a));


            Console.WriteLine("Logic operations \n");

            Console.Write("Is {0} > {1} ? ", a, b);
            Console.WriteLine( (a > b) + "\n");

            Console.Write("Is {0} < {1} ? ", c, a);
            Console.WriteLine((c < a) + "\n");

            Console.Write("Is {0} <= {1} ? ", b, c);
            Console.WriteLine((b <= c) + "\n");
            
            Console.Write("Is {0} >= {1} ? " , c, a);
            Console.WriteLine((c >= a) + "\n");

            Console.Write("Is {0} = {1} ? ", c, a);
            Console.WriteLine((c == a) + "\n");

            Console.Write("Is {0} diferent(!) {1} ? ", b, c);
            Console.WriteLine((b != c) + "\n");

            Console.WriteLine("The remainder of dividing {0} % {1} is: {2}. ", b, a, (b % a));

            Console.ReadKey();
        }
    }
}
