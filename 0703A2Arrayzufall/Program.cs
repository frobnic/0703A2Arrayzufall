using System;

namespace _0703A2Arrayzufall
{
    class Program
    {
        static void FillArrayWithRandomNumbers(int[] TheArray)
        {
            Random zufall = new Random();

            for (int i = 0; i < TheArray.Length; i++)
                TheArray[i] = zufall.Next(0, 100);
        }

        static int SUM(int[] TheArray)
        {
            int a = 0;

            foreach (int b in TheArray)
            {
                a += b;
            }

            return a;
        }

        static double AVG(int[] TheArray)
        {
            int a = 0, i = 0;

            foreach (int b in TheArray)
            {
                a += b;
                i++;
            }

            return ((double)a / (double)i);
        }

        static void PrintArray(int[] TheArray)
        {
            foreach (int a in TheArray)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] zahlen;
            int anzahl;

            Console.Write("Wieviele Zahlen möchten Sie generieren? (1-100)");
            anzahl = int.Parse(Console.ReadLine());

            zahlen = new int[anzahl];

            FillArrayWithRandomNumbers(zahlen);

            Console.WriteLine();

            PrintArray(zahlen);

            Console.WriteLine();
            Console.WriteLine("Die Summer der Zahlen beträgt {0}", SUM(zahlen));
            Console.WriteLine("Das geometrische Mittel der Zahlen ist {0}", AVG(zahlen));
            Console.WriteLine();

        }
    }
}
