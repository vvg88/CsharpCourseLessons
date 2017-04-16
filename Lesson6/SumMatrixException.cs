using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class TwoMatrixOperationException : Exception
    {
        public Matrix FirstMatrix { get; private set; }

        public Matrix SecondMatrix { get; private set; }

        public override string Message
        {
            get
            {
                string firstMtrxInfo = FirstMatrix != null ? $"{FirstMatrix.ColCount}x{FirstMatrix.RowCount}" : "не задана";
                string secndMtrxInfo = SecondMatrix != null ? $"{SecondMatrix.ColCount}x{SecondMatrix.RowCount}" : "не задана";

                return base.Message + $" (первая матрица {firstMtrxInfo}, вторая матрица {secndMtrxInfo})";
            }
        }

        public TwoMatrixOperationException(string message, Matrix firstMtrx, Matrix scndMatrix) : base(message)
        {
            FirstMatrix = firstMtrx;
            SecondMatrix = scndMatrix;
        }


    }
}
