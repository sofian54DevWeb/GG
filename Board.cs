using System;
using System.Collections.Generic;
using System.Text;


namespace GooseGame
{
    public class Board //Plateau de jeu avec les cases
    {
        public int Cas { get; set; }

        public Board(int cas)
        {
            Cas = cas;
        }

    }
}