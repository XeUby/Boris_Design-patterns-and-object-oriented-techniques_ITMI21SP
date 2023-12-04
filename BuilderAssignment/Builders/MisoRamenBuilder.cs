using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    // Concrete builder for creating Miso Ramen
    internal class MisoRamenBuilder : IRamenBuilder
    {
        // Instance of the RamenBowl being constructed
        private RamenBowl ramen = new RamenBowl();

        // Set the type of broth for Miso Ramen
        public void settingBroth()
        {
            ramen.Broth = BrothType.Miso;
        }

        // Set the type of noodle for Miso Ramen
        public void settingNoodle()
        {
            ramen.Noodle = NoodleType.Udon;
        }

        // Add specific toppings for Miso Ramen
        public void addTopping()
        {
            ramen.Topping.Add(Topping.GreenOnions);
        }

        // Add extra components for Miso Ramen
        public void addExtra()
        {
            ramen.Extra.Add(Extra.Corn);
        }

        // Return the completed Miso Ramen bowl
        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
