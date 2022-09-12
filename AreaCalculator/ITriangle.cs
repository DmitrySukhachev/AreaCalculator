
namespace AreaCalculator
{
    public interface ITriangle : IFigure
    {
        double EdgeA { get; }
        double EdgeB { get; }
        double EdgeC { get; }
        bool IsTriangle(double edgeA, double edgeB, double edgeC);
        bool IsRightTriangle();
    }
}
