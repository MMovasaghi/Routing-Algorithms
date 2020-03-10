using System;
using System.Collections.Generic;
using System.Text;

namespace FindRoute
{
    static class AlgorithmBase
    {
        public static bool ProblemSolved(int x, int y)
        {
            if (SearchBases.map[x - 1][y] == 'D')
                return true;
            if (SearchBases.map[x][y + 1] == 'D')
                return true;
            if (SearchBases.map[x + 1][y] == 'D')
                return true;
            if (SearchBases.map[x][y - 1] == 'D')
                return true;

            return false;
        }
        
    }
}
