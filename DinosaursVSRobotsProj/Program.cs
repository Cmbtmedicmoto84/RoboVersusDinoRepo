﻿using System;
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
            Battlefield battlefieldObject = new Battlefield();
            battlefieldObject.RunBattle();
            Console.ReadLine();
        }
        
    }
}
