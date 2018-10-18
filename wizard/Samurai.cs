using System;

namespace wizard
{
    public class Samurai : Human
    {
        public Samurai(string person) : base(person)
        {
        }

        public Samurai(string person, int str, int intel, int dex, int hp) : base(person, str, intel, dex, hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = 200;
        }
        public void death_blow(object target) {
            Human enemy = target as Human;
            if(enemy != null) {
                if(enemy.health < 50) {
                    enemy.health = 0;
                }
            }
        }
        public void meditate(object obj) 
        {
            Samurai meditate = obj as Samurai;
            if(meditate != null)
            {
                meditate.health = 200;
                Console.WriteLine("You're fully healed");
            }
        }
    }
}