using System;
using System.Diagnostics;

namespace FindRoute
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                SearchBases.CleanMaps();
                Console.Write("Enter which find way do you want: \n1. DFS\n2. BFS\n3. A*\nYour Choise : ");
                string input = Console.ReadLine();
                Console.Write("\nChose Map:\n1. Plain\n2. With Wall\n3. HI map\n4. With Cage\nYour Choise : ");
                string mapSelect = Console.ReadLine();

                //show map
                Console.Clear();
                SearchBases.ChoseMap(mapSelect);
                SearchBases.PrintMap();

                //chose the location of start
                Console.WriteLine("\n\n");
                Console.Write("Start Location:\nX = ");
                int start_x = int.Parse(Console.ReadLine());
                Console.Write("Y = ");
                int start_y = int.Parse(Console.ReadLine());
                SearchBases.SetSource(start_x, start_y);
                Console.Clear();
                SearchBases.PrintMap();

                //chose the location of end
                Console.WriteLine("\n\n");
                Console.Write("End Location:\nX = ");
                int end_x = int.Parse(Console.ReadLine());
                Console.Write("Y = ");
                int end_y = int.Parse(Console.ReadLine());
                SearchBases.SetDestination(end_x, end_y);


                // show map to start the algorithm
                Console.Clear();
                SearchBases.ChoseMap(mapSelect);
                SearchBases.SetSource(start_x, start_y);
                SearchBases.SetDestination(end_x, end_y);
                SearchBases.PrintMap();

                Stopwatch stopWatch = new Stopwatch();

                if (input == "1")
                {                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t:::::: Algorithm : DFS ::::::");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress any key to start the algorithm...");
                    Console.ReadKey();

                    // show map to start the algorithm
                    Console.Clear();
                    SearchBases.ChoseMap(mapSelect);
                    SearchBases.SetSource(start_x, start_y);
                    SearchBases.SetDestination(end_x, end_y);
                    SearchBases.PrintMap();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t:::::: Algorithm : DFS ::::::");
                    Console.ForegroundColor = ConsoleColor.White;

                    DFS dFS = new DFS();
                    stopWatch.Start();
                    int count = dFS.FindWay();
                    stopWatch.Stop();

                    long time = (stopWatch.ElapsedMilliseconds) - (20 * count);

                    Console.SetCursorPosition(0, 24);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($">> Time: {time} ms");
                    Console.WriteLine($">> Stack Operation: {dFS.stackOperation}");
                    Console.WriteLine($">> Node Visit: {dFS.NodeVisited}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress any key to go back to menu...");
                    Console.ReadKey();

                }
                else if (input == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t:::::: Algorithm : BFS ::::::");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress any key to start the algorithm...");
                    Console.ReadKey();

                    // show map to start the algorithm
                    Console.Clear();
                    SearchBases.ChoseMap(mapSelect);
                    SearchBases.SetSource(start_x, start_y);
                    SearchBases.SetDestination(end_x, end_y);
                    SearchBases.PrintMap();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t:::::: Algorithm : BFS ::::::");
                    Console.ForegroundColor = ConsoleColor.White;

                    BFS bFS = new BFS();
                    stopWatch.Start();
                    int count = bFS.FindWay();
                    stopWatch.Stop();

                    long time = (stopWatch.ElapsedMilliseconds) - (20 * count);

                    Console.SetCursorPosition(0, 23);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($">> Time: {time} ms");
                    Console.WriteLine($">> Stack Operation: {bFS.queueOperation}");
                    Console.WriteLine($">> Node Visit: {bFS.NodeVisited}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress any key to go back to menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
