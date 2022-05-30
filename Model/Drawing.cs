using OOP8.Model.Factories;
using OOP8.Model.Figures;

namespace OOP8.Model
{
    internal class Drawing
    {
        private IFigure _type = null;
        private Pen _pen = new Pen(Color.Empty, 3);
        public Tuple<Point, Point> Points = new Tuple<Point, Point>(Point.Empty, Point.Empty);
        private SolidBrush _solidBrush = new SolidBrush(Color.Empty);
        private Graphics _graphics;

        public Drawing(Graphics graphics)
        {
            _graphics = graphics;
        }

        public Drawing(Tuple<Point, Point> points, SolidBrush brush, Pen pen, IFigure figure, Graphics graphics)
        {
            Points = points;
            _solidBrush = brush;
            _pen = pen;
            _type = figure;
            _graphics = graphics;
        }

        public IFigure Type => _type;
        public Drawing Copy => new Drawing(Points, new SolidBrush(_solidBrush.Color), _pen, _type, _graphics);
        public SolidBrush Brush => _solidBrush;
        public Tuple<string, string> Info
        {
            get
            {
                string colorInfo;
                if (_type.GetType() == typeof(Line))
                {
                    colorInfo = _pen.Color.ToString();
                }
                else
                {
                    colorInfo = _solidBrush.Color.ToString();
                }

                return Tuple.Create(_type.ToString(), colorInfo);
            }
        }

        public void Draw()
        {
            _type.Draw(_graphics, _pen, Points, _solidBrush);
        }

        internal bool Check(Point point)
        {
            var minX = Math.Min(Points.Item1.X, Points.Item2.X);
            var maxX = Math.Max(Points.Item1.X, Points.Item2.X);

            var minY = Math.Min(Points.Item1.Y, Points.Item2.Y);
            var maxY = Math.Max(Points.Item1.Y, Points.Item2.Y);

            return point.X >= minX && point.X <= maxX && point.Y >= minY && point.Y <= maxY;
        }

        internal void SetBrush(object sender)
        {
            var box = (ComboBox)sender;

            var color = (Color)box.SelectedItem;
            _solidBrush.Color = color;
        }

        internal void SetBrush(SolidBrush solidBrush)
        {
            _solidBrush = solidBrush;
        }

        public void SetPenColor(object sender)
        {
            var box = (ComboBox)sender;
            var color = (Color)box.SelectedItem;
            _pen.Color = color;
        }

        internal void SetFigure(int index)
        {
            FigureFactory figureFactory = new FigureFactory();
            _type = figureFactory.GetFigure(index);
        }
    }
}
