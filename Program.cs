namespace GooseGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player1("Sofian", true);
            var player2 = new Player2("David", false);
            player1.InfoPlayer();
            player2.InfoPlayer();

            var dice = new Dice(0);
            dice.diceRoll();

        }
    }
}