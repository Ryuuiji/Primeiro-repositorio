using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Olá, digite o numero da tabuada que deseja: ");
            int nume = Convert.ToInt32 (Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(nume + " x " + i + " = " + (nume * i));
            }
        }
    }
}
