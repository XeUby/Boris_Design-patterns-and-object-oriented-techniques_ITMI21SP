using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    // Concrete builder for creating Shoyu Ramen
    internal class ShoyuRamenBuilder : IRamenBuilder
    {
        // Instance of the RamenBowl being constructed
        private RamenBowl ramen = new RamenBowl();

        // Set the type of broth for Shoyu Ramen
        public void settingBroth()
        {
            ramen.Broth = BrothType.Shoyu;
        }

        // Set the type of noodle for Shoyu Ramen
        public void settingNoodle()
        {
            ramen.Noodle = NoodleType.Soba;
        }

        // Add specific toppings for Shoyu Ramen
        public void addTopping()
        {
            ramen.Topping.Add(Topping.BambooShoots);
            ramen.Topping.Add(Topping.Seaweed);
        }

        // Shoyu Ramen doesn't have extra components, set extras to null
        public void addExtra()
        {
            ramen.Extra = null;
        }

        // Return the completed Shoyu Ramen bowl
        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}

}
