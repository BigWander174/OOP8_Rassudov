namespace OOP8.Model.PointAdders
{
    internal class Pointers
    {
        private PointSetter[] _pointsSetters;
        private PointSetter _current;
        private RadioButton[] _radioButtons;

        public Pointers(Drawing drawing, Creator creator, FiguresHistory figuresHistory, params RadioButton[] radioButtons)
        {
            _pointsSetters = new PointSetter[]
            {
                new DrawerPointer(drawing, creator),
                new FillerPointer(drawing, figuresHistory)
            };

            _radioButtons = radioButtons;

            _current = _pointsSetters[0];
        }

        public void Set(object element)
        {
            var button = (RadioButton)element;

            var index = Array.IndexOf(_radioButtons, button);
            _current = _pointsSetters[index];
        }

        public void Work(Point point)
        {
            _current.PointCreate(point);
        }
    }
}
