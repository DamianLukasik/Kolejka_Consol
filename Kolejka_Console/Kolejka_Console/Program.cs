using System;
using System.Collections;

namespace Kolejka_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue liczby = new Queue();
            Console.WriteLine("\n< kładanie na kolejkę >\n");
            foreach (int liczba in new int[4] { 9, 3, 7, 2 })
            {
                liczby.Enqueue(liczba);
                Console.WriteLine("\t" + liczba + " dodana do kolejnki");
            }
            Console.WriteLine("\n< zawartość kolejki >\n");
            foreach (int liczba in liczby)
            {
                Console.WriteLine("\t" + liczba);
            }
            Console.WriteLine("\n< zdejmowanie z kolejki >\n");
            while (liczby.Count != 0)
            {
                int liczba = (int)liczby.Dequeue();
                Console.WriteLine("\t" + liczba + " odjęta z kolejki");
            }
            Console.ReadKey();
        }
    }
}
