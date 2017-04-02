using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Rectangle : Shape
    {
        private float width;
        private float length;

        public Rectangle(float width, float length)
        {
            this.width = width;
            this.length = length;
        }

        public override string GetName()
        {
            return "Прямоугольник";
        }

        public override float GetArea()
        {
            return width * length;
        }

        public override float GetPerimeter()
        {
            return width + length;
        }
    }
}
