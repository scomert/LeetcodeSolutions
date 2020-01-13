using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeSolutions
{
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            if (numRows == 0) return new int[0][];

            var levels = new int[numRows][];

            levels[0] = new int[] { 1 };

            for (int i = 1; i < numRows; i++)
            {
                var prevLevel = levels[i - 1];
                var level = new int[i + 1];

                level[0] = 1;
                for (int j = 1; j < i; j++)
                {
                    level[j] = prevLevel[j - 1] + prevLevel[j];
                }

                level[i] = 1;

                levels[i] = level;
            }

            return levels;
        }
    }
}
