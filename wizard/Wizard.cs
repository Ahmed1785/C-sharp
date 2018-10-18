using System;

namespace wizard
{
    public class Wizard : Human
    {
        public Wizard(string person) : base(person)
        {
        }

        public Wizard(string person, int str, int intel, int dex, int hp) : base(person, str, intel, dex, hp)
        {
        name = person;
        strength = str;
        intelligence = 25;
        dexterity = dex;
        health = 50;
        }

        public void heal(object obj)
        {
        Wizard lifeforce = obj as Wizard;
        if(lifeforce == null)
        {
            Console.WriteLine("Too late! You're dead!");
        }
        else
        {
            lifeforce.health += strength * 10;
        }
    }

        public void fireball(object obj)
        {
        Random rand = new Random();
        Wizard healthy = obj as Wizard;
        if(healthy == null)
        {
            Console.WriteLine("Finish him!");
        }
        else
        {
            healthy.health -= strength * rand.Next(20,51);
        }
    }
    }
}