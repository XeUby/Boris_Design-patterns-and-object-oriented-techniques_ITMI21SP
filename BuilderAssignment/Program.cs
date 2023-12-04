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

            // Prepare Vegan Ramen using VeganRamenBuilder
            RamenBowl veganRamen = chef.PrepareRamen(new VeganRamenBuilder());
            
            // Display information about the finished Vegan Ramen
            RamenBowl.FinishedBowlOfRamen(veganRamen);
            Console.WriteLine(RamenBowl.FinishedBowlOfRamen(veganRamen));

            // Prepare Spicy Ramen using MisoRamenBuilder (Note: It's using the wrong builder, should be SpicyRamenBuilder)
            RamenBowl spicyRamen = chef.PrepareRamen(new MisoRamenBuilder());
            
            // Display information about the finished Spicy Ramen
            RamenBowl.FinishedBowlOfRamen(spicyRamen);
            Console.WriteLine(RamenBowl.FinishedBowlOfRamen(spicyRamen));
        }
    }
}
