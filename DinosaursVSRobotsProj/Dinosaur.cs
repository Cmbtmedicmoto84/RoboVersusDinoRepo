using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVSRobotsProj
{
    class Dinosaur
    {
        //member variables
        string DinoType;
        int healthLevel;
        int energyLevel;
        int attackPower;

        //constructor
        public Dinosaur(string DinoType, int healthLevel, int energyLevel)
        {
            this.DinoType = DinoType;
            this.healthLevel = healthLevel;
            this.energyLevel = energyLevel;

        }

        //member methods
        public void Attack()
        {
            //
        }


    }
}
