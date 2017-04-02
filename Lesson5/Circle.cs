using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Circle : Shape
    {
        private float radius;

        public Circle (float radius)
        {
            this.radius = radius;
        }

        public override string GetName()
        {
            return "Круг";
        }

        public override float GetArea()
        {
            return (float)Math.PI * radius * radius;
        }

        public override float GetPerimeter()
        {
            return 2 * (float)Math.PI * radius;
        }
    }
}
