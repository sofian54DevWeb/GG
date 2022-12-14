using System;
using System.Collections.Generic;
using System.Text;


namespace GooseGame
{
    public class Dice //Dé allant de 1 à 6
    {
        public int Jet { get; set; }

        public Dice(int jet)
        {
            Jet = jet;
        }

        public void diceRoll()
        {
            Random random = new Random();
            Jet = random.Next(1, 7); // Pour générer un nombre aléatoire
            Console.WriteLine("Tu as fait un " + Jet  + " Avec ton dé");
        }
    }
}