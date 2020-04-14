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
        int healthLevel;
        int energyLevel;
        int attackPower;

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
        public void DinoToFight(string dinoType, int energyLevel, int attackPower, int healthLevel)
        {
            this.dinoType = dinoType;
            this.healthLevel = healthLevel;
            this.energyLevel = energyLevel;
            this.attackPower = attackPower;
            Console.WriteLine(dinoType, healthLevel, energyLevel, attackPower);

        }
        //public int HealthLevel { get => healthLevel; set => healthLevel = value; }
    }
}
