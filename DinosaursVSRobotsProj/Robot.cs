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
        Weapon weapon;


        //constructor
        //public void NamesOf()
        //{
        //    NameTheRobot(robotName);
        //}
        public string NameTheRobot(string robotName) /*, int health, int powerLevel) */ 
        {
            //health = 100;
            //powerLevel = 100;
            string TheRobotName = "Crimson Warrior";
            string result;
            result = TheRobotName;
            Console.WriteLine("Welcome" + result);
            Console.ReadLine();
            return TheRobotName;
        }
        //public string Weapon(string weaponType)
        //{
        //    Console.WriteLine("weapon of choice, ");
        //    return getWeapon;
        //}
        

        
        //public string PrintRobotSpecs(List<string> name)
        //{
        //    foreach(string robotName in name)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}

        //member methods
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
