using BuilderExercise.Models;

namespace BuilderExercise
{
    public abstract class HouseBuilder
    {
        protected House house = new House();

        public abstract void BuildFoundation();
        public abstract void BuildWalls();
        public abstract void BuildRoof();
        public abstract void BuildGarage();
        public abstract void BuildSwimmingPool();
        public abstract void BuildGarden();

        public House GetHouse()
        {
            return house;
        }
    }
}
