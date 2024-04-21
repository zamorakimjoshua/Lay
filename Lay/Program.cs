using BL;
using Models;
using System;

namespace UI
{
    internal class Program
    {
        public static void Description(Beach beach)
        {
            Console.WriteLine("YOUR BEACH INFO:");
            Console.WriteLine(beach.name);
            Console.WriteLine(beach.place);
            Console.WriteLine(beach.description);
        }

        static void Main(string[] args)
        {
            Service services = new Service();
            Console.WriteLine("1.Boracay");
            Console.WriteLine("2.Alona Beach");
            Console.WriteLine("3.El Nido");
            Console.WriteLine("4.Saud Beach ");
            Console.WriteLine("5.Coron");
            Console.Write("Please enter number to view beach: ");
            int chosenBeach = Convert.ToInt32(Console.ReadLine());
            switch (chosenBeach)
            {
                case 1:
                    Description(services.GetBeach("Boracay"));
                    break;
                case 2:
                    Description(services.GetBeach("Alona Beach"));
                    break;
                case 3:
                    Description(services.GetBeach("El Nido"));
                    break;
                case 4:
                    Description(services.GetBeach("Saud Beach"));
                    break;
                case 5:
                    Description(services.GetBeach("Coron"));
                    break;

                default:
                    Console.WriteLine("Error. Try again.");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
