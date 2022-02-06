using System.ComponentModel.DataAnnotations.Schema;

namespace WAR_UI
{
    public class Cards
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Face { get; set; }
        public string Photo { get; set; }
        [ForeignKey("Player")]
        public int Playerid { get; set; } = 3;

        public Cards() { }
        
    }
}
