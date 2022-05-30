namespace OOP8.Model.PointAdders
{
    internal class FillerPointer : PointSetter
    {
        private FiguresHistory _figuresHistory;
        
        public FillerPointer(Drawing drawing, FiguresHistory figuresHistory) : base(drawing)
        {
            _figuresHistory = figuresHistory;
        }

        public override void PointCreate(Point point)
        {
            var figureToChangeColor = _figuresHistory.Find(point);
            if (figureToChangeColor == null)
            {
                return;
            }
            figureToChangeColor.SetBrush(Draw.Brush);
            _figuresHistory.Draw();
        }
    }
}
