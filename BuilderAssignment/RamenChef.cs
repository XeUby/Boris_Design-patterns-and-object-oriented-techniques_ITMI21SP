using BuilderAssignment.Builders;
using BuilderAssignment.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment
{
    public class RamenChef
    {
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            //TODO#1: Call each builder step declared in RamenBuilder class
            builder.settingBroth();
            builder.settingNoodle();
            builder.addTopping();
            builder.addExtra();
            return builder.GetRamen() ; //TODO#2: Finaly return build bowl of ramen
        }
    }
}

//In a complete implementation, i will have concrete classes that implement the IRamenBuilder interface. 
//Each concrete builder would provide its own implementation for setting up the ramen bowl according to specific recipes or preferences. 
//The RamenChef class would then use the builder to create different variations of ramen bowls.
