using OOP8.Model;

namespace OOP8.View
{
    internal class History
    {
        private DataGridView _target;

        public History(DataGridView dataGridView, Creator creator)
        {
            creator.OnNewFigureAdd += Add;
            creator.FigureRemoved += Remove;
            _target = dataGridView;
        }
       
        private void Add(Drawing drawing)
        {
            (string type, string color) = drawing.Info;
            _target.Rows.Add(type, color);
        }

        private void Remove(int index)
        {
            _target.Rows.RemoveAt(index);
        }
    }
}
