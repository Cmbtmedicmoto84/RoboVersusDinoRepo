using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVSRobotsProj
{
    class Fleet
    {
        public string robotName;
        public int healthLevel;
        public int powerLevel;
        public int weaponAP;
        //Weapon weapon = new Weapon(); //what is with this line?!?!?!

        public Fleet()
        {
            Robot crimson = new Robot("Crimson Warrior");
            Robot destroyer = new Robot("Destroyer");
            List<Robot> robots = new List<Robot>();

            robots.Add(crimson);
            robots.Add(destroyer);

            foreach (Robot robot in robots)
            {
                Console.WriteLine("Name: {robot.robotName");
            }

            Weapon longsword = new Weapon("Long Sword");
            List<Weapon> weapons = new List<Weapon>();

            weapons.Add(longsword);

            foreach (Weapon weapon in weapons)
            {
                Console.WriteLine("Selected weapon: {weapon.weaponName}");
            }
        }
        
        public void RobotToFight(string robotName, int healthLevel, int powerLevel, int weaponAP)
        {
            this.robotName = robotName;
            healthLevel = 100;
            powerLevel = 100;
            weaponAP = 55;
        }


    }
}
