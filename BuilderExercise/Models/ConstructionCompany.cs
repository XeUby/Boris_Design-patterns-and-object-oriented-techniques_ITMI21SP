namespace BuilderExercise.Models
{
    /// <summary>
    /// Director
    /// </summary>
    public class ConstructionCompany
    {
        /// <summary>
        /// Contruct wooden house
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public House ConstructWoodenHouse(HouseBuilder builder)
        {
            builder.BuildFoundation();
            builder.BuildWalls();
            builder.BuildRoof();
            return builder.GetHouse();
        }

        /// <summary>
        /// Used to construct brick houses with garage
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public House ConstrutcBrickHouse(HouseBuilder builder)
        {
            builder.BuildFoundation();
            builder.BuildWalls();
            builder.BuildRoof();
            builder.BuildGarage();
            return builder.GetHouse();
        }

        /// <summary>
        /// Used to construct custom houses
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public House ConstructCustomHouse(HouseBuilder builder)
        {
            builder.BuildFoundation();
            builder.BuildWalls();
            builder.BuildRoof();
            builder.BuildGarage();
            builder.BuildGarden();
            builder.BuildSwimmingPool();
            return builder.GetHouse();
        }
    }
}
