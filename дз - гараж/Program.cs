using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static дз___гараж.garage;

namespace дз___гараж
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Garage garage = new Garage();
            string sym;
            do
            {               
                if (count == 0) { Console.WriteLine("Welcome! \n choose action: "); }
                else { Console.WriteLine("\nchoose action: "); }      
                
                Console.WriteLine("1 - add auto, 2 - delete auto by id, 3 - view all");
                sym = Console.ReadLine();

                switch (sym)
                {
                    case "1":
                        string brand, model;
                        Console.WriteLine("Enter brand: ");
                        brand = Console.ReadLine();
                        if (brand == "Lamborghini")
                        {
                            Console.WriteLine("Enter model: ");
                            model = Console.ReadLine();
                            if (model == "Aventador")
                            {
                                Aventador aventador = new Aventador();
                                garage.AddAuto(aventador);
                                Console.WriteLine("Added successfully");
                                Console.WriteLine($"id - {aventador.Id}");
                            }
                            else { Console.WriteLine("you can only add Aventador"); }
                        }
                        

                        if (brand == "Ferrari")
                        {
                            Console.WriteLine("Enter model: ");
                            model = Console.ReadLine();
                            if (model == "488 Spider")
                            {
                                Spider spider  = new Spider();
                                garage.AddAuto(spider);
                                Console.WriteLine("Added successfully");
                                Console.WriteLine($"id - {spider.Id}");
                            }
                            else { Console.WriteLine("you can only add 488 Spider"); }
                        }
                        

                        if (brand == "Mazda")
                        {
                            Console.WriteLine("Enter model: ");
                            model = Console.ReadLine();
                            if (model == "Miata")
                            {
                                Miata miata = new Miata();
                                garage.AddAuto(miata);
                                Console.WriteLine("Added successfully");
                                Console.WriteLine($"id - {miata.Id}");
                            }
                            else { Console.WriteLine("you can only add Miata"); }
                        }
                        
                        break;

                    case "2":
                        Console.WriteLine("Enter id: ");
                        int input;
                        int.TryParse(Console.ReadLine(), out input);
                        garage.EraseAuto(input);
                        Console.WriteLine("Deleted successfully");
                        break;

                    case "3":
                        foreach (var item in garage.List)
                        {
                            Console.WriteLine(item.Id + " - " + item.Name);

                        }
                        break;
                }
                count++;
            } while (sym != "q");
        }
    }
}