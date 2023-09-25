namespace BuilderExercise.Models
{
    public class House
    {
        public string Foundation { get; set; }
        public string Walls { get; set; }
        public string Roof { get; set; }
        public bool HasGarage { get; set; }
        public bool HasSwimmingPool { get; set; }
        public bool HasGarden { get; set; }

        public override string ToString()
        {
            return $"Foundation: {Foundation}, Walls: {Walls}, Roof: {Roof}, " +
                   $"Garage: {(HasGarage ? "Yes" : "No")}, " +
                   $"Swimming Pool: {(HasSwimmingPool ? "Yes" : "No")}, " +
                   $"Garden: {(HasGarden ? "Yes" : "No")}";
        }
    }
}
