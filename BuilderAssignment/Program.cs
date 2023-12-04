using BuilderAssignment.Builders;
using BuilderAssignment.Models;
using System.ComponentModel.DataAnnotations;

namespace BuilderAssignment
{
    internal class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Create an instance of RamenChef to prepare different types of ramen
            RamenChef chef = new RamenChef();

            // Prepare Miso Ramen using MisoRamenBuilder
            RamenBowl misoRamen = chef.PrepareRamen(new MisoRamenBuilder());
            
            // Display information about the finished Miso Ramen
            RamenBowl.FinishedBowlOfRamen(misoRamen);
            Console.WriteLine(RamenBowl.FinishedBowlOfRamen(misoRamen));

            // Prepare shoyu Ramen using shoyuRamenBuilder
            RamenBowl shoyuRamen = chef.PrepareRamen(new shoyuRamenBuilder());
            
            // Display information about the finished shoyu Ramen
            RamenBowl.FinishedBowlOfRamen(shoyuRamen);
            Console.WriteLine(RamenBowl.FinishedBowlOfRamen(shoyuRamen));

            // Prepare shio Ramen using shioRamenBuilder 
            RamenBowl shioRamen = chef.PrepareRamen(new shioRamenBuilder());
            
            // Display information about the finished shio Ramen
            RamenBowl.FinishedBowlOfRamen(shioRamen);
            Console.WriteLine(RamenBowl.FinishedBowlOfRamen(shioRamen));
        }
    }
}
