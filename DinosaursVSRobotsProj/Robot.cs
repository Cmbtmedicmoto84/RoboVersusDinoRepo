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
        int health;
        string powerLevel;
        Weapon weapon; //
        

        //constructor
        public Robot(string name)  
        {
            this.name = name;
            health = ;
            powerLevel = "";
            attackPower = "";
        }

        //member methods
                //public void ChooseRobotName()
                //{
                //    Console.WriteLine("Please choose your Robot name: ");
                //}
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
