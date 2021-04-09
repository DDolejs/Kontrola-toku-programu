using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrola_toku_programu
{
    class Program
    {   private static int For(int x, int n) 
        {
            int output = 1;            
            for (int i = 1; i <= n; i++)
            {
                int operation = x*i / factorial_Recursion(i);
                if (i % 2 == 0)
                {
                    operation = operation * -1;
                }
                output += operation;
            }
            return output;
        }
        private static int While(int x, int n) 
        {
            int output = 1;
            int i = 1;
            while (i<= n)
            {
                int operation = x*i / factorial_Recursion(i);
                if (i % 2 == 0)
                {
                    operation = operation * -1;
                }
                output += operation;
                i++;
            }
            return output;
        }
        private static int Do_while(int x, int n) 
        {
            int output = 1;
            int i = 1;
            do
            {
                int operation = x*i / factorial_Recursion(i);
                if (i % 2 == 0)
                {
                    operation = operation * -1;
                }
                output += operation;
                i++;
            } while (i<=n);
            return output;
        }
        private static int Recurent(int x, int n,int i =1, int output = 1)
        {
            int operation = x * n / factorial_Recursion(n);
            if (n == 0)
            {
                return output;
            }
            else if (n%2==0)
            {
                operation = operation * -1;
            }
            output += operation;
            if (i <= n) return output;

            else  return Recurent(x, n ,i++, output);

        }
        private static int factorial_Recursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial_Recursion(number - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte číslo N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(For(x,n));
            Console.WriteLine(While(x,n));
            Console.WriteLine(Do_while(x,n));
            Console.WriteLine(Recurent(x,n));
            Console.ReadLine();
        }
    }
}
