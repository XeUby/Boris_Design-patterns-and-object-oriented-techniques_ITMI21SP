using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Models
{
    // Represents a bowl of ramen with various components
    public class RamenBowl
    {
        // Properties representing different components of the ramen bowl
        public BrothType Broth { get; set; }
        public NoodleType Noodle { get; set; }
        public List<Topping> Topping { get; set; } = new List<Topping>();
        public List<Extra> Extra { get; set; } = new List<Extra>();

        // Method to generate a string describing the finished bowl of ramen
        public static string FinishedBowlOfRamen(RamenBowl ramen)
        {
            // Start with a base description
            string description = "This bowl of ramen contains:";

            // Check if Broth is specified and add to the description
            if (!string.IsNullOrEmpty(ramen.Broth.ToString()))
            {
                description += $" Broth: {ramen.Broth} \n";
            }

            // Check if Noodle is specified and add to the description
            if (!string.IsNullOrEmpty(ramen.Noodle.ToString()))
            {
                description += $" Noodles: {ramen.Noodle}\n";
            }

            // Check if Toppings are specified and add to the description
            if (ramen.Topping != null && ramen.Topping.Count > 0)
            {
                description += " Toppings: ";
                foreach (var topping in ramen.Topping)
                {
                    description += $"{topping}, ";
                }
                description = description.TrimEnd(',', ' ') + "\n";
            }

            // Check if Extras are specified and add to the description
            if (ramen.Extra != null && ramen.Extra.Count > 0)
            {
                description += " Extras: ";
                foreach (var extra in ramen.Extra)
                {
                    description += $"{extra}, ";
                }
                description = description.TrimEnd(',', ' ') + "\n";
            }

            // Return the final description of the ramen bowl
            return description;
        }
    }
}

