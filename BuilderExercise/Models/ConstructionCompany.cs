namespace BuilderExercise.Models
{
    /// <summary>
    /// Director
    /// </summary>
    public class ConstructionCompany
    {
        public House ConstructHouse(HouseBuilder builder)
        {
            builder.BuildFoundation();
            builder.BuildWalls();
            builder.BuildRoof();
            return builder.GetHouse();
        }
    }
}
