namespace BuilderPattern
{
    public interface IHouseBuilder
    {
        void BuildFoundation();
        void BuildWalls();
        void BuildRoof();
        void BuildWindows();
        House GetHouse();
    }
}
