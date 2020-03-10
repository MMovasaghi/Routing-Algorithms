using System;
using System.Collections.Generic;
using System.Text;

namespace FindRoute
{
    static class SearchBases
    {
        public static char[][] map =
                              { "############################################################0".ToCharArray(),
                                "#                                                          #1".ToCharArray(),
                                "# ############# ######## #####################   #######  ##2".ToCharArray(),
                                "# ###### ## ### ######## ########## ##########   #######  ##3".ToCharArray(),
                                "# ###### ## ### ######## ########## ##########   #######  ##4".ToCharArray(),
                                "# ###### ## ### ######## ########## ########################5".ToCharArray(),
                                "# ###### ## ############ ########## ####                   #6".ToCharArray(),
                                "# ######    ##           ########## ############### ###### #7".ToCharArray(),
                                "# ######### ## ######### ########## ######## ## # # #   ## #8".ToCharArray(),
                                "#       ### ## #########                  ## ## # # # # ## #9".ToCharArray(),
                                "####### ###           ################### ## ## # # # # ## #0".ToCharArray(),
                                "# ##### ######################### ####### ## ## # # # # ## #1".ToCharArray(),
                                "#                            #### #######    ## #     # ## #2".ToCharArray(),
                                "####### #################### #### ####### ##### ########## #3".ToCharArray(),
                                "####### ###               ## #### ##                       #4".ToCharArray(),
                                "#       ### ################ #### ## ############## ###### #5".ToCharArray(),
                                "# #########                  ####    ##             ###### #6".ToCharArray(),
                                "#       ################################################## #7".ToCharArray(),
                                "# #####                                                    #8".ToCharArray(),
                                "############################################################9".ToCharArray(),
                                "012345678901234567890123456789012345678901234567890123456780 ".ToCharArray(),};
        public static int[] Source = { 1, 1 };
        public static int[] Destination = { 1, 58 };
        public static void PrintMap()
        {            
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 61; j++)
                {
                    if (i == 20 || j == 60)
                        Console.ForegroundColor = ConsoleColor.White;
                    else if(i == Source[0] && j == Source[1])
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if (i == Destination[0] && j == Destination[1])
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Blue;


                    Console.Write(map[i][j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void SetSource(int x = 1, int y = 1)
        {
            map[x][y] = 'S';
            Source[0] = x;
            Source[1] = y;
        }
        public static void SetDestination(int x = 18, int y = 58)
        {
            map[x][y] = 'D';
            Destination[0] = x;
            Destination[1] = y;
        }
    }
}
