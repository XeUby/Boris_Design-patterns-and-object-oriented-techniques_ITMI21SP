namespace BuilderExercise.Models
{
    public class BrickHouseBuilder : HouseBuilder
    {
        public override void BuildFoundation()
        {
            house.Foundation = "Concrete Piles";
        }

        public override void BuildWalls()
        {
            house.Walls = "Brick and Glass";
        }

        public override void BuildRoof()
        {
            house.Roof = "Tile Roof";
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
