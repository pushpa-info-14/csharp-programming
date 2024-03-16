namespace CSharpProgramming.Study.BroCode
{
    public class Lesson44ListOfObjects
    {
        public void Method1()
        {
            var players = new List<Player>();

            var player1 = new Player("Chad");
            var player2 = new Player("Steve");
            var player3 = new Player("Karen");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach (var player in players)
            {
                Console.WriteLine(player.Username);
            }
        }

        class Player
        {
            public string Username;

            public Player(string username)
            {
                Username = username;
            }
        }
    }
}
