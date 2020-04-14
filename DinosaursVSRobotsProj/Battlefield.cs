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
        int robotRoll;
        int dinoRoll;
        int robotHealth;
        int dinosaurHealth;
        Fleet crimson = new Fleet();
        Herd raptor = new Herd();
        Random random = new Random();

        //constructor
        public Battlefield()
        {
            string raptor;
            string crimson;
            
            robotHealth = 5;
            dinosaurHealth = 5;
        }


        ////member methods
        public int attackRoll(string roll)
        {
            int turnRoll = random.Next(1, 9);
            for(int i = 5; i > 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine();
                }
            }
            return turnRoll;
        }

        public void whosTurn(string raptor, string crimson)
        {
            if (dinoRoll > robotRoll)
            {
                Console.WriteLine(raptor + " bites " + crimson + " !!!");
                robotHealth--;
                return;
            }
            else if (dinoRoll < robotRoll)
            {
                Console.WriteLine(crimson + " slashes" + raptor + " accross his body!!!");
                dinosaurHealth--;
                return;
            }
            else
            {
                Console.WriteLine("Attacks were blocked!");
            }
        }
        



        public void RunBattle()
        {
            if(dinosaurHealth > 1 && robotHealth > 1)
            {
                return;
            }
            else if(dinosaurHealth < 1 && robotHealth < 1)
            {
                
            }
        }
    }
}
