namespace OOP8.Model.Figures
{
    internal class Line : IFigure
    {
        public void Draw(Graphics graphics, Pen pen, Tuple<Point, Point> points, SolidBrush solidBrush)
        {
            graphics.DrawLine(pen, points.Item1, points.Item2);
        }

        public override string ToString()
        {
            return "Линия";
        }
    }
}
