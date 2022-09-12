namespace AreaCalculator
{
    public class Circle : ICircle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new Exception("Error: invalid radius!");
            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }
    }
}
