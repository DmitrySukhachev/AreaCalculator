using AreaCalculator;

namespace AreaCalculatorTest
{
    public class CircleTest
    {
		[Fact]
		public void NegativeRadiusTest()
		{
			Assert.Throws<Exception>(() => new Circle(-2d));
		}

		[Fact]
		public void ZeroRadiusTest()
		{
			Assert.Throws<Exception>(() => new Circle(0d));
		}

		[Fact]
		public void GetSquareTest()
		{
			var radius = 3;
			var circle = new Circle(radius);
			var expectedValue = Math.PI * Math.Pow(radius, 2d);
			var square = circle.GetSquare();

			Assert.Equal(expectedValue, square);
		}
	}
}