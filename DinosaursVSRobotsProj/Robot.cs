using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVSRobotsProj
{
    class Robot
    {
        //member variables
        string name;
        double health;
        string powerLevel;
        string Weapon;
        string WeaponType;
        string attackPower;

        //constructor
        public Robot()
        {
            name = "";
            powerLevel = "";
            attackPower = "";

        }

        //member methods
        public void ChooseRobotName()
        {
            Console.WriteLine("Please choose your Robot name: ");
        }
        public void ChooseRobotWeaponType()
        {
            Console.WriteLine("Please choose a Weapon type: ");
        }
        public void ChooseWeapon()
        {
            //could add it to method above in ifelse statement?? with lists of weapon & weapon type
            Console.WriteLine("Please choose a Weapon: ");
        }

    }
}
