namespace Lesson5
{
    class Sector : Circle, IGetableRadius
    {
        private float angleGrad;

        public Sector (float rad, float angleGrad) : base(rad)
        {
            this.angleGrad = angleGrad;
        }

        public override string Name
        {
            get { return "Сектор"; }
        }

        public override float GetArea()
        {
            return base.GetArea() * angleGrad / 2 / 360;
        }

        public override float GetPerimeter()
        {
            return 2 * radius + base.GetPerimeter() * angleGrad  / 360;
        }
    }
}