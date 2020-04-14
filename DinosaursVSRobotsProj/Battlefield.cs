using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVSRobotsProj
{
    class Battlefield
    {
        //member variables
        public string dinoType;
        public string robotName;
        int robotHealth;
        int dinosaurHealth;
        Random random = new Random();

        //constructor
        public Battlefield()
        {
            robotHealth = 5;
            dinosaurHealth = 5;
        }


        ////member methods
        public int attackRoll()
        {
            int turnRoll = random.Next(1, 2);
            return turnRoll;
        }

        public void WhosTurn(int robotRoll, int dinoRoll)
        {
            if (robotRoll < dinoRoll)
            {
                Console.WriteLine(dinoType + " bites " + robotName + " !!!");
                robotHealth--;
            }
            else if (dinoRoll < robotRoll)
            {
                Console.WriteLine(robotName + " slashes" + dinoType + " accross his body!!!");
                dinosaurHealth--;
            }
            else
            {
                Console.WriteLine("Attacks were blocked!");
            }

        }




        public void RunBattle()
        {
            while(dinosaurScore > robotScore)
            {
                int dinoRoll = attackRoll();
                int robotRoll = attackRoll();
                WhosTurn(dinoRoll, robotRoll);
            }
        }
        
    }
}
