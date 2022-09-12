using AreaCalculator;

namespace AreaCalculatorTest
{
    public class TriangleTest
    {
		[Fact]
		public void CreateTriangleTest()
		{
			double a = 3d, b = 4d, c = 5d;

			var triangle = new Triangle(a, b, c);

			Assert.NotNull(triangle);
		}

		[Fact]
		public void CreateNotTriangleTest()
		{
			Assert.Throws<Exception>(() => new Triangle(2, 1, 6));
		}

		[Theory]
		[InlineData(0, 0, 0)]
		[InlineData(-3, 2, 1)]
		[InlineData(1, -5, 2)]
		[InlineData(2, 3, -1)]
		
		public void CreateTriangleWithWrongSidesTest(double a, double b, double c)
		{
			Assert.Throws<Exception>(() => new Triangle(a, b, c));
		}

		[Theory]
		[InlineData(7, 8, 11)]
		[InlineData(2, 2, 2 + 2e-7)]
		public void NotRightTriangle(double a, double b, double c)
		{
			var triangle = new Triangle(a, b, c);
			
			var isRight = triangle.IsRightTriangle();
			
			Assert.False(isRight);
		}

		[Theory]
		[InlineData(6, 8, 10)]
		[InlineData(12, 5, 13.000000001)]
		public void IsRightTriangle(double a, double b, double c)
		{
			var triangle = new Triangle(a, b, c);
			
			var isRight = triangle.IsRightTriangle();
			
			Assert.True(isRight);
		}

		[Fact]
		public void GetSquareTest()
		{
			double a = 13d, b = 14d, c = 15d;
			double result = 84d;
			var triangle = new Triangle(a, b, c);

			var square = triangle?.GetSquare();

			Assert.NotNull(square);
			Assert.Equal(result, square);
		}
	}
}
