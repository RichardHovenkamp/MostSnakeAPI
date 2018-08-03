namespace MostSnake.Models
{
    public class Player
    {
        public string PlayerName { get; private set; }
        public string PlayerAction { get; set; }

        public Player(string playerName)
        {
            PlayerName = playerName;
        }
    }
}