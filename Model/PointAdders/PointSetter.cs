namespace OOP8.Model.PointAdders
{
    internal abstract class PointSetter
    {
        protected Drawing Draw;

        public PointSetter(Drawing draw)
        {
            Draw = draw;
        }

        public abstract void PointCreate(Point point);
    }
}
