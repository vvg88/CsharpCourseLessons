using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    abstract class Shape
    {
        public abstract string Name
        {
            get;
        }

        public abstract float GetArea();

        public abstract float GetPerimeter();
    }
}