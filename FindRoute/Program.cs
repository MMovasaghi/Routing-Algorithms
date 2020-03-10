using System;

namespace FindRoute
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchBases.SetSource();
            SearchBases.SetDestination();
            SearchBases.PrintMap();

            Console.Write("Enter which find way do you want: \n1. DFS\n2. BFS\n3. A*\nYour Choise : ");
            string input = Console.ReadLine();
            if(input == "1")
            {
                Console.Clear();
                SearchBases.PrintMap();
                Console.WriteLine("\t\t:::::: Algorithm : DFS ::::::");
                Console.WriteLine("\nPress any key to start the algorithm");
                DFS dFS = new DFS();
                Console.ReadKey();
                dFS.FindWay();
            }
            else if(input == "2")
            {
                Console.Clear();
                SearchBases.PrintMap();
                Console.WriteLine("\t\t:::::: Algorithm : BFS ::::::");
                Console.WriteLine("\nPress any key to start the algorithm");
                BFS bFS = new BFS();
                Console.ReadKey();
                bFS.FindWay();
            }

            Console.ReadKey();
        }
    }
}
