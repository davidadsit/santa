using System;

namespace Santa
{
    internal class Program
    {
        private static void Add()
        {
            throw new NotImplementedException();
        }

        private static void Help()
        {
            Console.Out.WriteLine("Commands:");
            Console.Out.WriteLine("  add");
            Console.Out.WriteLine("  remove");
            Console.Out.WriteLine("  update");
            Console.Out.WriteLine("  help");
        }

        private static void Main(string[] args)
        {
            Console.Out.WriteLine("Santa, Inc.");
            Console.Out.WriteLine("Welcome to The Digital Naughty & Nice List");
            Console.Out.WriteLine("");

            var command = "help";
            do
            {
                switch (command)
                {
                    case "add":
                        Add();
                        break;
                    case "update":
                        Update();
                        break;
                    case "remove":
                        Remove();
                        break;
                    default:
                        Help();
                        break;
                }

                Console.Out.WriteLine("");
                Console.Out.Write("Enter a command: ");
                command = Console.In.ReadLine()?.Split(" ")[0].ToLower() ?? "help";
            } while (command != "exit");

            Console.WriteLine("Thank you for using The Digital Naughty & Nice List");
            Console.WriteLine("");
        }

        private static void Remove()
        {
            throw new NotImplementedException();
        }

        private static void Update()
        {
            throw new NotImplementedException();
        }
    }
}