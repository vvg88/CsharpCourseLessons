﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Triangle : Shape
    {
        private float sideA;
        private float sideB;
        private float sideC;

        public Triangle(float sideA, float sideB, float sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override string GetName()
        {
            return "Треугольник";
        }

        public override float GetArea()
        {
            float halfPerimeter = GetPerimeter() / 2;
            return (float)Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        }

        public override float GetPerimeter()
        {
            return sideA + sideB + sideC;
        }
    }
}
