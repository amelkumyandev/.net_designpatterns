namespace BuilderPattern.workers
{
    public class ConstructionEngineer
    {
        private IHouseBuilder builder;

        public ConstructionEngineer(IHouseBuilder builder)
        {
            this.builder = builder;
        }

        public void SetBuilder(IHouseBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildMinimalViableHouse()
        {
            builder.BuildFoundation();
            builder.BuildRoof();
        }

        public void BuildFullFeaturedHouse()
        {
            builder.BuildFoundation();
            builder.BuildWalls();
            builder.BuildRoof();
            builder.BuildWindows();
        }

        public House GetHouse() => builder.GetHouse();

    }
}
