using System.Drawing;

namespace OOP8.Extensions
{
    public static class GraphicsExtensions
    {
        public static void DrawCircle(this Graphics graphics, Pen pen, Tuple<Point, Point> points, SolidBrush solidBrush)
        {
            var startX = Math.Min(points.Item1.X, points.Item2.X);
            var startY = Math.Min(points.Item1.Y, points.Item2.Y);
            var width = Math.Abs(points.Item1.X - points.Item2.X);
            var height = Math.Abs(points.Item1.Y - points.Item2.Y);

            Rectangle rectangle = new Rectangle(startX, startY, width, height);
            graphics.DrawEllipse(pen, rectangle);
            graphics.FillEllipse(solidBrush, rectangle);
        }

        public static void DrawRectangle(this Graphics graphics, Pen pen, Tuple<Point, Point> points, SolidBrush solidBrush)
        {
            var startX = Math.Min(points.Item1.X, points.Item2.X);
            var startY = Math.Min(points.Item1.Y, points.Item2.Y);
            var width = Math.Abs(points.Item1.X - points.Item2.X);
            var height = Math.Abs(points.Item1.Y - points.Item2.Y);

            Rectangle rectangle = new Rectangle(startX, startY, width, height);
            graphics.DrawRectangle(pen, rectangle);
            graphics.FillRectangle(solidBrush, rectangle);
        }
    }
}
