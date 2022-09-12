namespace AreaCalculator
{
    public class Triangle : ITriangle
    {
        private const double accuracy = 1e-7;
        public double EdgeA { get; }

        public double EdgeB { get; }

        public double EdgeC { get; }

        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (!IsTriangle(edgeA, edgeB, edgeC)) 
                throw new Exception("Error: in a triangle, the sum of any two sides must be greater than the third!");
            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;
        }
        public bool IsTriangle(double edgeA, double edgeB, double edgeC) 
        {
            return edgeA + edgeB > edgeC && edgeA + edgeC > edgeB && edgeB + edgeC > edgeA;
        }
        public bool IsRightTriangle() 
        {
            double hypotenuse = EdgeA, cathetus1 = EdgeB, cathetus2 = EdgeC;
            if (cathetus1 - hypotenuse > 0)
                Utils.Swap(ref hypotenuse, ref cathetus1);

            if (cathetus2 - hypotenuse > 0)
                Utils.Swap(ref hypotenuse, ref cathetus2);

            return Math.Abs(Math.Pow(hypotenuse, 2) - Math.Pow(cathetus1, 2) - Math.Pow(cathetus2, 2)) < accuracy;
        }

        public double GetSquare() 
        {
            var halfPerimeter = (EdgeA + EdgeB + EdgeC) / 2d;
			var square = Math.Sqrt(halfPerimeter * (halfPerimeter - EdgeA) * (halfPerimeter - EdgeB) * (halfPerimeter - EdgeC));

			return square;
        }
    }
}
