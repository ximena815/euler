using System;

namespace euler
{
    class Program
    {
        static double Factorial(double valor)
        {
            double total = 1;
            for (int cont = 1; cont <= valor;cont++)
            {
                total *= cont;
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular a Euler");
            double x = 3;
            double euler = 0;
            int n = 100;

            
            for (int i=0;i <= n; i++)
            {
               euler += (Math.Pow(x, i) / Factorial(i));
            }
            Console.WriteLine("Euler >:3..........." + euler);
        }

    }
}
