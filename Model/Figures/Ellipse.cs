using OOP8.Extensions;

namespace OOP8.Model.Figures
{
    internal class Ellipse : IFigure
    {
        public void Draw(Graphics graphics, Pen pen, Tuple<Point, Point> points, SolidBrush solidBrush)
        {
            graphics.DrawCircle(pen, points, solidBrush);
        }

        public override string ToString()
        {
            return "Эллипс";
        }
    }
}
