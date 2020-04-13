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
        public string dinoType;
        public int healthLevel;
        public int energyLevel;
        public int attackPower;

        //constructor
        public Dinosaur()
        {
            dinoType = "Velociraptor";
            healthLevel = 100;
            energyLevel = 100;
            attackPower = 60;
        }
    }
}
