namespace OOP8.Model
{
    internal class Drawer
    {
        public Drawer(Creator creator)
        {
            creator.OnNewFigureAdd += CreateFigure;
        }

        public void CreateFigure(Drawing drawing)
        {
            drawing.Draw();
        }
    }
}
