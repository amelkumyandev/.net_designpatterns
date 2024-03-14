using BuilderPattern.Builders;
using BuilderPattern.workers;

var engineer = new ConstructionEngineer(new WoodenHouseBuilder());
engineer.BuildMinimalViableHouse();
var house = engineer.GetHouse();
house.ShowHause();

// Switch to a different builder
engineer.SetBuilder(new GlassHouseBuilder());
engineer.BuildFullFeaturedHouse();
house = engineer.GetHouse();
house.ShowHause();