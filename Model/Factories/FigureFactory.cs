namespace OOP8.Model.Factories
{
    internal class FigureFactory
    {
        public IFigure GetFigure(int index)
        {
            switch (index)
            {
                case 0:
                    return new Figures.Line();
                case 1:
                    return new Figures.Ellipse();
                case 2:
                    return new Figures.Rectangle();
            }

            return null;
        }
    }
}
