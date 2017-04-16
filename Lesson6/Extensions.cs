using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public static class Extensions
    {
        public static void FillMatrixRandom(this Matrix matrix)
        {
            if (matrix == null)
                return;
            for (uint col = 0; col < matrix.ColCount; col++)
            {
                for (uint row = 0; row < matrix.RowCount; row++)
                {
                    matrix[col, row] = random.Next(0, 100);
                }
            }
        }

        static Random random = new Random();
    }
}
