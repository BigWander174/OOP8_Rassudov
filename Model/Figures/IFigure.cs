namespace OOP8.Model
{
    internal interface IFigure
    {
        public void Draw(Graphics graphics, Pen pen, Tuple<Point, Point> points, SolidBrush solidBrush);
    }
}