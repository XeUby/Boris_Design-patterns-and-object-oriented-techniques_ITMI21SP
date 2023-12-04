using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    // Interface for building a ramen bowl
    public interface IRamenBuilder
    {
        // Set the type of broth for the ramen
        void settingBroth();

        // Set the type of noodle for the ramen
        void settingNoodle();

        // Add toppings to the ramen
        void addTopping();

        // Add extra components to the ramen
        void addExtra();

        // Get the completed ramen bowl
        RamenBowl GetRamen();
    }
}
