using System;

namespace ExerciciosPropostos1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            double R, A, pi = 3.14159;
            Console.WriteLine("Digite o valor do raio do círculo: ");
            R = double.Parse(Console.ReadLine());
            A = pi * Math.Pow(R, 2);
            Console.WriteLine("O valor da área do circulo é equivalente a: ");
            Console.WriteLine("A {0}", A.ToString("F4"));
        }
    }
}
