using System;
using System.Collections;

namespace Stos_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack liczby = new Stack();

            liczby.Push(10);
            liczby.Push(11);
            liczby.Push(2);
            liczby.Push(7);

            foreach(int liczba in liczby)
            {
                Console.WriteLine(liczba);
            }

            while (liczby.Count != 0)
            {
                int liczba = (int)liczby.Pop();
                Console.WriteLine(liczba+" została usunięta ze stosu");
            }

            Console.ReadKey();
        }
    }
}
