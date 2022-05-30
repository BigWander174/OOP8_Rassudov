namespace OOP8.Model.PointAdders
{
    internal class DrawerPointer : PointSetter
    {
        private Creator _creator;
        
        public DrawerPointer(Drawing drawer, Creator creator) : base(drawer) 
        {
            _creator = creator;
        }

        public override void PointCreate(Point point)
        {
            if (Draw.Points.Item1.IsEmpty)
            {
                Draw.Points = new Tuple<Point, Point>(point, Point.Empty);
            }
            else
            {
                Draw.Points = new Tuple<Point, Point>(Draw.Points.Item1, point);
                Drawing drawing = Draw.Copy;
                _creator.OnNewFigureAdd?.Invoke(drawing.Copy);
                Draw.Points = new Tuple<Point, Point>(Point.Empty, Point.Empty);
            }
        }
    }
}
