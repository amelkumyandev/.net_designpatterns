namespace BuilderPattern.Builders
{
    public class WoodenHouseBuilder: IHouseBuilder
    {
        private House house = new House();

        public WoodenHouseBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.house = new House();
        }

        public void BuildFoundation()
        {
            this.house.AddPart("Wooden Foundation");
        }

        public void BuildWalls()
        {
            house.AddPart("Wooden Walls");
        }

        public void BuildRoof()
        {
            house.AddPart("Wooden Roof");
        }

        public void BuildWindows()
        {
            house.AddPart("Wooden Windows");
        }

        public House GetHouse()
        {
            House result = this.house;
            this.Reset();
            return result;
        }

    }
}
