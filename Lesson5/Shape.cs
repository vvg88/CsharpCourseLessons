using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Shape
    {
        public virtual string GetName()
        {
            return "Фигура";
        }

        public virtual float GetArea()
        {
            return 0;
        }

        public virtual float GetPerimeter()
        {
            return 0;
        }
    }
}
