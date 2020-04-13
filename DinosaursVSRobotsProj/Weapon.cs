using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVSRobotsProj
{
    class Weapon
    {
        //member variables
        string WeaponType;
        int attackPower;
        bool swingAttack;
        //string Sword;
        //string Mace;
        //string Ranged;

        //constructor
        public Weapon(string WeaponType, int attackPower)
        {
            this.WeaponType = WeaponType;
            this.attackPower = attackPower;
        }

        //member methods
        public void swingSword()
        {
            //list & possible ifelse statement?
            swingAttack = true;
        }
    }
}
