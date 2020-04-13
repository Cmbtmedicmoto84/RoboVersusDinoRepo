using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVSRobotsProj
{
    class Herd
    {
        public string dinoType; 
        public int healthLevel;
        public int energyLevel;
        public int attackPower;

        public Herd()
        {
            Dinosaur raptor = new Dinosaur("Velociraptor");
            List<Dinosaur> dinosaurs = new List<Dinosaur>();

            dinosaurs.Add(raptor);

            foreach (Dinosaur dinosaur in dinosaurs)
            {
                Console.WriteLine("Name: {dinosaur.dinoType");
            }
        }
        public void DinoToFight(string dinoType, int healthLevel, int energyLevel, int attackPower)
        {
            this.dinoType = dinoType;
            healthLevel = 100;
            energyLevel = 100;
            attackPower = 67;
        }
    }
}
