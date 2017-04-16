using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(5, 5);
            matrix1.FillMatrixRandom();
            Console.WriteLine(matrix1);

            Matrix matrix2 = new Matrix(5, 5);
            matrix2.FillMatrixRandom();
            Console.WriteLine(matrix2);

            Matrix tMatrix1 = new ToeplitzMatrix(5, 5);
            tMatrix1.FillMatrixRandom();
            Console.WriteLine(tMatrix1);

            Matrix tMatrix2 = new ToeplitzMatrix(5, 5);
            tMatrix2.FillMatrixRandom();
            Console.WriteLine(tMatrix2);

            try
            {
                //Matrix matrix3 = matrix1.Sum(tMatrix1);
                Console.WriteLine(tMatrix1.Sum(tMatrix2));
            }
            catch (TwoMatrixOperationException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
