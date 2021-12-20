

namespace WAR_UI
{
    public class Cards
    {
        public int Id { get; set; }
        public int Cardnumber { get; set; }
        public string Face { get; set; }

        public Cards(int Cardnumber, string Face)
        {
            this.Cardnumber = Cardnumber;
            this.Face = Face;
        }
        
    }
}
