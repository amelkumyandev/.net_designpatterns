namespace BuilderPattern.Builders
{
    public class GlassHouseBuilder : IHouseBuilder
    {
        private House house = new House();

        public GlassHouseBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.house = new House();
        }

        public void BuildFoundation()
        {
            this.house.AddPart("Glass Foundation");
        }

        public void BuildWalls()
        {
            this.house.AddPart("Glass Walls");
        }

        public void BuildRoof()
        {
            this.house.AddPart("Glass Roof");
        }

        public void BuildWindows()
        {
            this.house.AddPart("Glass Windows");
        }

        public House GetHouse()
        {
            House result = this.house;
            this.Reset();
            return result;
        }
    }
}
