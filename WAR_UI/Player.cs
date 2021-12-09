namespace WAR_UI
{
    public class Player
    {
        public string Name { get; set; }
        public int Wins { get; set; }

        public Player(string Name, int Wins)
        {
            this.Name = Name;  
            this.Wins = Wins;   
        }
    }
}
