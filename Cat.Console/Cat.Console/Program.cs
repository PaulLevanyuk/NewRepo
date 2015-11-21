using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\tCat for programmer");
            Console.WriteLine("Enter the Cat age");
            var cat = new Cat(Console.ReadLine());
            var catColor = new CatColor();
            string menu = "";
            do
            {
                Console.Write("Cat`s Age: {0}\nCat`s name: {1}\nCat`s Color: {2}", cat.Age, cat.Name, cat.CurrentColor);
                Console.WriteLine();
                Console.WriteLine("a. Set Health and Sick color\nb. Feed the Cat\nc. Punish the Cat\nd. Name the Cat\n");
                menu = Console.ReadLine();
                switch (menu)
                {
                        
                    case "a":
                    {
                        Console.WriteLine("Sick color:");
                        cat.Color.SickColor = Console.ReadLine();
                        Console.WriteLine("Healthy color:");
                        cat.Color.HealthyColor = Console.ReadLine();
                        break;
                    }
                    case "b":
                    {
                        cat.Feed();
                        break;
                    }
                    case "c":
                    {
                        cat.Punish();
                        break;
                    }
                    case "d":
                    {
                        Console.WriteLine("Enter the name");
                        cat.Name = Console.ReadLine();
                        break;
                    }
                  
                }
                Console.Clear();
                
                    
            } while (true);
        }
    }
}
