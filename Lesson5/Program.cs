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

            Shape[] shapes = new Shape[] { rect, cir, sec, tri };
            foreach(Shape sh in shapes)
            {
                Console.WriteLine(sh.GetName());
                Console.WriteLine(sh.GetArea());
                Console.WriteLine(sh.GetPerimeter() + "\n");
            }
            
            //Console.WriteLine(rect.GetName());
            //Console.WriteLine(rect.GetArea());
            //Console.WriteLine(rect.GetPerimeter() + "\n");

            //Console.WriteLine(cir.GetName());
            //Console.WriteLine(cir.GetArea());
            //Console.WriteLine(cir.GetPerimeter() + "\n");

            //Console.WriteLine(sec.GetName());
            //Console.WriteLine(sec.GetArea());
            //Console.WriteLine(sec.GetPerimeter() + "\n");

            //Console.WriteLine(tri.GetName());
            //Console.WriteLine(tri.GetArea());
            //Console.WriteLine(tri.GetPerimeter() + "\n");

            Console.ReadLine();
        }
        // Структура записывается в поле класса - boxing
        // Поле класса типа значения пишется в лок. переиенную (стек) - unboxing
        // Эти операции считаются ресурсозатратными
    }
}
