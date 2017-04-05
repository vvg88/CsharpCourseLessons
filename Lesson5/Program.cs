using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10.5f, 50);
            Circle cir = new Circle(50f);
            Sector sec = new Sector(30f, 50f);
            Triangle tri = new Triangle(10f, 20f, 30f);

            //Shape[] shapes = new Shape[] { rect, cir, sec, tri };
            //foreach(Shape sh in shapes)
            //{
            //    Console.WriteLine(sh.Name);
            //    Console.WriteLine("Радиус: " + (sh as IGetableRadius)?.GetRadius());
            //    Console.WriteLine(sh.GetArea());
            //    Console.WriteLine(sh.GetPerimeter() + "\n");
            //}
            //IReadOnlyList

            List<Shape> shps = new List<Shape>(new Shape[] {
                new Rectangle(10.5f, 50),
                new Circle(50f),
                new Sector(30f, 50f),
                new Triangle(10f, 20f, 30f)
            });

            IEnumerator<Shape> enumerator = shps.GetEnumerator();
            Shape shp;
            while (enumerator.MoveNext())
            {
                shp = enumerator.Current;
                Console.WriteLine(shp.Name);
                Console.WriteLine("Радиус: " + (shp as IGetableRadius)?.GetRadius());
                Console.WriteLine(shp.GetArea());
                Console.WriteLine(shp.GetPerimeter() + "\n");
            }
            Console.ReadLine();
        }
        // Структура записывается в поле класса - boxing
        // Поле класса типа значения пишется в лок. переиенную (стек) - unboxing
        // Эти операции считаются ресурсозатратными
    }
}
