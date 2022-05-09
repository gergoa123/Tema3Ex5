using System;

namespace Tema3Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int numar;
            Console.WriteLine("introduceti numere");
            numar = int.Parse(Console.ReadLine());
            int aux = numar;
            
            suma = suma + numar;
            numar = int.Parse(Console.ReadLine());

            while (numar != aux)
            {
               
                aux = numar;
                suma = suma + numar;
                numar = int.Parse(Console.ReadLine());

            }

            suma = suma + numar;
            Console.WriteLine("suma numerelor este " + suma);
        }
    }
    
}

