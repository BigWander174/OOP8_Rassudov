using OOP8.Model.Figures;

namespace OOP8.Model
{
    internal class FiguresHistory
    {
        private List<Drawing> _drawings = new List<Drawing>();

        public FiguresHistory(Creator creator)
        {
            creator.OnNewFigureAdd += Add;
            creator.FigureRemoved += Remove; 
        }

        internal void Add(Drawing drawing)
        {
            _drawings.Add(drawing);
        }

        internal void Remove(int index)
        {
            _drawings.RemoveAt(index);
        }

        public void Draw()
        {
            foreach (var drawing in _drawings)
            {
                drawing.Draw();
            }
        }

        internal Drawing? Find(Point point)
        {
            return _drawings.Where(drawing => drawing.Type.GetType() != typeof(Line)).LastOrDefault(drawing => drawing.Check(point));
        }
    }
}
