using System;

namespace wizard
{
    public class Ninja : Human
    {
        public Ninja(string person) : base(person)
        {
        }

        public Ninja(string person, int str, int intel, int dex, int hp) : base(person, str, intel, dex, hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = 175;
            health = hp;
        }
        public void Steal(object target) {
            Human enemy = target as Human;
            if(enemy != null) {
                attack(enemy);
                health += 10;
            }
        }
        public void get_away(object obj) 
        {
            Ninja lifeforce = obj as Ninja;
            if(lifeforce == null)
            {
                Console.WriteLine("Too late! You're dead!");
            }
            else
            {
                lifeforce.health -= 15;
            }
        }
    }
}