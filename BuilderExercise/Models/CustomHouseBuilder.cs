namespace BuilderExercise.Models
{
    public class CustomHouseBuilder : HouseBuilder
    {
        public override void BuildFoundation()
        {
            Console.WriteLine("Choose a foundation type:");
            Console.WriteLine("1: Wooden Piles");
            Console.WriteLine("2: Concrete Foundation");

            string foundation;

            switch (Console.ReadLine())
            {
                case "1":
                    foundation = "Wooden Piles";
                    break;
                case "2":
                    foundation = "Concrete Foundation";
                    break;
                default:
                    Console.WriteLine("Invalid choice! Using default: Wooden Piles.");
                    foundation = "Wooden Piles";
                    break;
            }

            house.Foundation = foundation;
        }

        public override void BuildWalls()
        {
            Console.WriteLine("Choose wall type:");
            Console.WriteLine("1: Wood and Glass");
            Console.WriteLine("2: Brick Walls");

            string wallsType;

            switch (Console.ReadLine())
            {
                case "1":
                    wallsType = "Wood and Glass";
                    break;
                case "2":
                    wallsType = "Brick Walls";
                    break;
                default:
                    Console.WriteLine("Invalid choice! Using default: Wood and Glass.");
                    wallsType = "Wood and Glass";
                    break;
            }

            house.Walls = wallsType;
        }

        public override void BuildRoof()
        {
            Console.WriteLine("Choose roof type:");
            Console.WriteLine("1: Wooden Roof");
            Console.WriteLine("2: Tile Roof");

            string roofType;

            switch (Console.ReadLine())
            {
                case "1":
                    roofType = "Wooden Roof";
                    break;
                case "2":
                    roofType = "Tile Roof";
                    break;
                default:
                    Console.WriteLine("Invalid choice! Using default: Wooden Roof.");
                    roofType = "Wooden Roof";
                    break;
            }

            house.Roof = roofType;
        }

        public override void BuildGarage()
        {
            // Garage
            Console.WriteLine("Would you like a garage? (yes/no)");
            house.HasGarage = Console.ReadLine().ToLower() == "yes";
        }

        public override void BuildSwimmingPool()
        {
            Console.WriteLine("Would you like a swimming pool? (yes/no)");
            house.HasSwimmingPool = Console.ReadLine().ToLower() == "yes";
        }

        public override void BuildGarden()
        {
            Console.WriteLine("Would you like a garden? (yes/no)");
            house.HasGarden = Console.ReadLine().ToLower() == "yes";
        }
    }
}
