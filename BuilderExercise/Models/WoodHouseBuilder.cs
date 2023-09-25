namespace BuilderExercise.Models
{
    public class WoodHouseBuilder : HouseBuilder
    {
        public override void BuildFoundation()
        {
            house.Foundation = "Wooden Piles";
        }

        public override void BuildWalls()
        {
            house.Walls = "Wood and Glass";
        }

        public override void BuildRoof()
        {
            house.Roof = "Wooden Roof";
        }

        public override void BuildGarage()
        {
            house.HasGarage = true;
        }

        public override void BuildSwimmingPool()
        {
            house.HasSwimmingPool = false;
        }

        public override void BuildGarden()
        {
            house.HasGarden = true;
        }
    }
}
