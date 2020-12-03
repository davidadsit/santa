using System;

namespace Santa
{
    internal class Program
    {
        private static ChildRepository childRepository = new ChildRepository();

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
                    case "nice":
                        PrintNiceList();
                        break;
                    case "naughty":
                        PrintNaughtyList();
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

        private static void PrintNaughtyList()
        {
            throw new NotImplementedException();
        }

        private static void PrintNiceList()
        {
            var niceChildren = new NiceQuery(childRepository).Execute();
            Console.Out.WriteLine("");
            Console.Out.WriteLine("The Nice List");
            foreach (var niceChild in niceChildren)
            {
                Console.Out.WriteLine($"{niceChild.Name} is in {niceChild.Location} and wants {niceChild.Gift}");
            }
        }

        private static void Add()
        {
            Console.Out.WriteLine("");
            Console.Out.WriteLine("Execute Child");
            Console.Out.Write("Enter the name: ");
            var name = Console.In.ReadLine();
            Console.Out.Write("Enter the location: ");
            var location = Console.In.ReadLine();
            Console.Out.Write("Enter the preferred gift: ");
            var gift = Console.In.ReadLine();
            Console.Out.Write("Are they Nice? [Y] ");
            var nice = Console.In.ReadLine() + "Y";
            var disposition = nice.ToLowerInvariant().Substring(0, 1) == "y" ? Disposition.Nice : Disposition.Naughty;
            new AddChildCommand(childRepository).Execute(new Child(name, location, gift, disposition));

        }

        private static void Help()
        {
            Console.Out.WriteLine("Commands:");
            Console.Out.WriteLine("  add");
            Console.Out.WriteLine("  remove");
            Console.Out.WriteLine("  update");
            Console.Out.WriteLine("  nice");
            Console.Out.WriteLine("  naughty");
            Console.Out.WriteLine("  help");
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