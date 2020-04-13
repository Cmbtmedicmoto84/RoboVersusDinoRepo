using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVSRobotsProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot crimson = new Robot("Crimson Warrior");
            Robot destroyer = new Robot("Destroyer");
            List<Robot> robots = new List<Robot>();

            robots.Add(crimson);
            robots.Add(destroyer);

            foreach(Robot robot in robots)
            {
                Console.WriteLine("Name: {robot.robotName");
            }
        }
        
    }
}
