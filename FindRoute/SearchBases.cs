using System;
using System.Collections.Generic;
using System.Text;

namespace FindRoute
{
    static class SearchBases
    {
        public static char[][] map;
        public static char[][] map2 = 
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
        public static char[][] map1 =
                              { "############################################################0".ToCharArray(),
                                "#                                                          #1".ToCharArray(),
                                "#                                                          #2".ToCharArray(),
                                "#                                                          #3".ToCharArray(),
                                "#                                                          #4".ToCharArray(),
                                "#                                                          #5".ToCharArray(),
                                "#                                                          #6".ToCharArray(),
                                "#                                                          #7".ToCharArray(),
                                "#                                                          #8".ToCharArray(),
                                "#                                                          #9".ToCharArray(),
                                "#                                                          #0".ToCharArray(),
                                "#                                                          #1".ToCharArray(),
                                "#                                                          #2".ToCharArray(),
                                "#                                                          #3".ToCharArray(),
                                "#                                                          #4".ToCharArray(),
                                "#                                                          #5".ToCharArray(),
                                "#                                                          #6".ToCharArray(),
                                "#                                                          #7".ToCharArray(),
                                "#                                                          #8".ToCharArray(),
                                "############################################################9".ToCharArray(),
                                "012345678901234567890123456789012345678901234567890123456780 ".ToCharArray(),};
        public static char[][] map3 =
                              { "############################################################0".ToCharArray(),
                                "#                                                          #1".ToCharArray(),
                                "#                                                          #2".ToCharArray(),
                                "#              ##           ##       ######                #3".ToCharArray(),
                                "#              ##           ##         ##                  #4".ToCharArray(),
                                "#              ##           ##         ##                  #5".ToCharArray(),
                                "#              ##           ##         ##                  #6".ToCharArray(),
                                "#              ##           ##         ##                  #7".ToCharArray(),
                                "#              ##           ##         ##                  #8".ToCharArray(),
                                "#              ###############         ##                  #9".ToCharArray(),
                                "#              ##           ##         ##                  #0".ToCharArray(),
                                "#              ##           ##         ##                  #1".ToCharArray(),
                                "#              ##           ##         ##                  #2".ToCharArray(),
                                "#              ##           ##         ##                  #3".ToCharArray(),
                                "#              ##           ##         ##                  #4".ToCharArray(),
                                "#              ##           ##       ######                #5".ToCharArray(),
                                "#                                                          #6".ToCharArray(),
                                "#                                                          #7".ToCharArray(),
                                "#                                                          #8".ToCharArray(),
                                "############################################################9".ToCharArray(),
                                "012345678901234567890123456789012345678901234567890123456780 ".ToCharArray(),};
        public static char[][] map4 =
                              { "############################################################0".ToCharArray(),
                                "#                                                          #1".ToCharArray(),
                                "#                                                          #2".ToCharArray(),
                                "#                                                          #3".ToCharArray(),
                                "#                                                          #4".ToCharArray(),
                                "#               ############################               #5".ToCharArray(),
                                "#               #                          #               #6".ToCharArray(),
                                "#               #                          #               #7".ToCharArray(),
                                "#               #                          #               #8".ToCharArray(),
                                "#               #                          #               #9".ToCharArray(),
                                "#               #                          #               #0".ToCharArray(),
                                "#               #                          #               #1".ToCharArray(),
                                "#               #                          #               #2".ToCharArray(),
                                "#               ############################               #3".ToCharArray(),
                                "#                                                          #4".ToCharArray(),
                                "#                                                          #5".ToCharArray(),
                                "#                                                          #6".ToCharArray(),
                                "#                                                          #7".ToCharArray(),
                                "#                                                          #8".ToCharArray(),
                                "############################################################9".ToCharArray(),
                                "012345678901234567890123456789012345678901234567890123456780 ".ToCharArray(),};
        public static int[] Source = { 1, 1 };
        public static int[] Destination = { 1, 58 };
        public static void ChoseMap(string num)
        {
            switch (num)
            {
                case "1":
                    map = map1;
                    break;
                case "2":
                    map = map2;
                    break;
                case "3":
                    map = map3;
                    break;
                case "4":
                    map = map4;
                    break;
            }
        }
        public static void PrintMap()
        {            
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 61; j++)
                {
                    if (map[i][j] == '#')
                        Console.ForegroundColor = ConsoleColor.Blue;
                    else if(map[i][j] == 'S')
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if (map[i][j] == 'D')
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.White;


                    Console.Write(map[i][j]);
                }
                Console.Write("\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void CleanMaps()
        {
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 61; j++)
                {
                    if (map1[i][j] == 'o' || map1[i][j] == '.' || map1[i][j] == 'S' || map1[i][j] == 'D')
                        map1[i][j] = ' ';
                    if (map2[i][j] == 'o' || map2[i][j] == '.' || map2[i][j] == 'S' || map2[i][j] == 'D')
                        map2[i][j] = ' ';
                    if (map3[i][j] == 'o' || map3[i][j] == '.' || map3[i][j] == 'S' || map3[i][j] == 'D')
                        map3[i][j] = ' ';
                    if (map4[i][j] == 'o' || map4[i][j] == '.' || map4[i][j] == 'S' || map4[i][j] == 'D')
                        map4[i][j] = ' ';
                }
            }
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
