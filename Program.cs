using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KG_245079_Kartkowka
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Theater();
            // obszar zakomentowany aby nie dublować rejestrów
         //   context.Movies.Add(new Movie { name = "Avatar"});
         //   context.Movies.Add(new Movie { name = "Zorro"});
         //   context.Movies.Add(new Movie { name = "Miodowe Lata"});
         //   context.SaveChanges();
            
            // wyswietlanie tabeli
            var movies = (from s in context.Movies select s).ToList<Movie>();
            foreach (var st in movies)
            {
                Console.WriteLine("ID: {0}, Movie Name: {1}", st.id, st.name);
            }
            Console.Write("Nacisnij Enter by zakonczyc program");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            { }
        }
    }
}
