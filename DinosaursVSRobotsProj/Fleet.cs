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

        public RobotToFight(string robotName, int healthLevel, int powerLevel, int weaponAP)
        {
            this.robotName = robotName;
            healthLevel = 100;
            powerLevel = 100;
            weaponAP = 55;
        }


    }
}
