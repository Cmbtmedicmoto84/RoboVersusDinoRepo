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


        //create an attack ability (robot to dino) & (dino to robot)
        public string DinoAttackHit; //base off attack power
        public string RobotAttackHit; //base off attack power
        public string UnsuccessfulDinoHit;
        public string UnsuccessfulRobotHit;

        //constructor
        public void Run()
        {

        }
 

        ////member methods
        //public AttackContact()
        //{
        //    //amount of damage done
        //}

        //public AttackMiss()
        //{
        //    //amount of damage done, then minus damage recieved for enemy plus ifelse statement for unsuccessful attack
        //}

    }
}
