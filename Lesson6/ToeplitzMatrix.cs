using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class ToeplitzMatrix : Matrix
    {
        private int[] firstRow;
        private int[] firstCol;

        public override int this[uint col, uint row]
        {
            get
            {
                uint minIndx = Math.Min(col, row);
                col -= minIndx;
                row -= minIndx;
                if (col > 0 || (col == 0 && row == 0))
                    return firstRow[col];
                return firstCol[row - 1];
            }

            set
            {
                uint minIndx = Math.Min(col, row);
                col -= minIndx;
                row -= minIndx;

                if (col > 0 || (col == 0 && row == 0))
                {
                    firstRow[col] = value;
                    return;
                }
                firstCol[row - 1] = value;
                return;
            }
        }

        public ToeplitzMatrix(uint colCount, uint rowCount) : base(colCount, rowCount)
        { }

        protected override void InitData()
        {
            firstRow = new int[ColCount];
            firstCol = new int[RowCount - 1];
        }

        public override Matrix Sum(Matrix otherMatrix)
        {
            ToeplitzMatrix tMatrix = otherMatrix as ToeplitzMatrix;
            if (tMatrix == null)
                return base.Sum(otherMatrix);

            ToeplitzMatrix sumRes = new ToeplitzMatrix(ColCount, RowCount);
            for (int col = 0; col < ColCount; col++)
            {
                sumRes.firstRow[col] = firstRow[col] + tMatrix.firstRow[col];
            }

            for (int row = 0; row < RowCount - 1; row++)
            {
                sumRes.firstCol[row] = firstCol[row] + tMatrix.firstCol[row];
            }
            return sumRes;
        }
    }
}
