using System.ComponentModel.DataAnnotations.Schema;

namespace WAR_UI
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Outcome { get; set; } = "";
        [ForeignKey("Cards")]
        public int CardId { get; set; } = 53;
        public virtual Cards Card { get; set; }
        public Player(string Name)
        {
            this.Name = Name;   
        }
    }
}
