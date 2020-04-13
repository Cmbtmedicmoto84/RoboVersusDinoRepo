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
        //int health;
        string getWeapon;
        //int powerLevel;
        Weapon weapon = new Weapon();


        //constructor
        public void NameofRobot(string robotName)
        {
            this.robotName = robotName;
            robotName = "Crimson Warrior";
            string result;
            result = robotName;
            Console.WriteLine("Welcome" + result);
            Console.ReadLine();
            
        }

        //member methods
        //public string NameOfTheRobot()
        //{
        //    string result = robotName;
        //    Console.WriteLine("Welcome" + result);
        //    return result;
        //}

        public void RunDemo()
        {

        }
       
        
                //public void ChooseRobotName()
                //{
                //    Console.WriteLine("Please choose your Robot name: ");
                //}
        //public void RobotAttack()
        //{
            
        //}
        //public void ChooseWeapon()
        //{
        //    //could add it to method above in ifelse statement?? with lists of weapon & weapon type
        //    Console.WriteLine("Please choose a Weapon: ");
        //}

    }
}
