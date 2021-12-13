namespace WAR_UI
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int Wins { get; set; } = 0;
        public int Loses { get; set; } = 0;
        public string? Outcome { get; set; }

        public Player(string Name, int Wins)
        {
            this.Name = Name;  
            this.Wins = Wins;   
        }
    }
}
