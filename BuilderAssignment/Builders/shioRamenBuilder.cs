using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    // Concrete builder for creating Shio Ramen
    internal class ShioRamenBuilder : IRamenBuilder
    {
        // Instance of the RamenBowl being constructed
        private RamenBowl ramen = new RamenBowl();

        // Set the type of broth for Shio Ramen
        public void settingBroth()
        {
            ramen.Broth = BrothType.ShioTonkotsu; 
        }

        // Set the type of noodle for Shio Ramen
        public void settingNoodle()
        {
            ramen.Noodle = NoodleType.Thin;
        }

        // Add specific toppings for Shio Ramen
        public void addTopping()
        {
            ramen.Topping.Add(Topping.ChashuPork);
            ramen.Topping.Add(Topping.GreenOnions);
        }

        // Add extra components for Shio Ramen
        public void addExtra()
        {
            ramen.Extra.Add(Extra.ExtraSpice);
        }

        // Return the completed Shio Ramen bowl
        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}

