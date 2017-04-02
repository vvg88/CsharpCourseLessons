using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Sector : Shape
    {
        private float rad;
        private float angleGrad;

        public Sector (float rad, float angleGrad)
        {
            this.rad = rad;
            this.angleGrad = angleGrad;
        }

        public override string GetName()
        {
            return "Сектор";
        }

        public override float GetArea()
        {
            return (float)Math.PI * angleGrad * rad * rad / 2 / 360;
        }

        public override float GetPerimeter()
        {
            return 2 * rad + angleGrad * rad * (float)Math.PI / 180;
        }
    }
}
