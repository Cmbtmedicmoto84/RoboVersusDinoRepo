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
        string robotName;
        int health;
        string weaponNameClass;
        int powerLevel;
        Weapon weapon;


        //constructor
        public Robot(string robotName, int health, int powerLevel)  
        {
            this.robotName = robotName;
            this.health = health;
            this.powerLevel = powerLevel;
        }
        public void PrintRobotSpecs(List<string> name)
        {
            foreach(string robotName in name)
            {
                Console.WriteLine(name);
            }
        }

        //member methods
                //public void ChooseRobotName()
                //{
                //    Console.WriteLine("Please choose your Robot name: ");
                //}
        public void RobotAttack()
        {
            
        }
        public void ChooseWeapon()
        {
            //could add it to method above in ifelse statement?? with lists of weapon & weapon type
            Console.WriteLine("Please choose a Weapon: ");
        }

    }
}
