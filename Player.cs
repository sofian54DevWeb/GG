using System;
using System.Collections.Generic;
using System.Text;

namespace GooseGame
{
    public class Player1 : Players
    {
        public bool Start { get; set; }

        public Player1(string name, bool start) : base(name)
        {
            Start = start;
        }
        public void InfoPlayer()
        {
            Console.WriteLine("Player name is {0}", Name);
        }
    }
    public class Player2 : Players
    {
        public bool Start { get; set; }

        public Player2(string name, bool start) : base(name)
        {
            Start = start;
        }
        public void InfoPlayer()
        {
            Console.WriteLine("Player name is {0}", Name);
        }
    }
}