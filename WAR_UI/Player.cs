using System.ComponentModel.DataAnnotations.Schema;

namespace WAR_UI
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Outcome { get; set; } = "";
        public virtual Cards Card { get; set; }
        public Player() { }
    }
}
