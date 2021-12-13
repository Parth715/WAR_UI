

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
        public static List<Cards> Deck()
        {
            List<Cards> Deck = new List<Cards>()
            {
                new Cards(2, "2 ofDiamonds"),
                new Cards(2, "2 ofHearts"),
                new Cards(2, "2 ofSpades"),
                new Cards(2, "2 ofClubs"),
                new Cards(3, "3 of Diamonds"),
                new Cards(3, "3 of Hearts"),
                new Cards(3, "3 of Spades"),
                new Cards(3, "3 of Clubs"),
                new Cards(4, "4 of Diamonds"),
                new Cards(4, "4 of Hearts"),
                new Cards(4, "4 of Spades"),
                new Cards(4, "4 of Clubs"),
                new Cards(5, "5 of Diamonds"),
                new Cards(5, "5 of Hearts"),
                new Cards(5, "5 of Spades"),
                new Cards(5, "5 of Clubs"),
                new Cards(6, "6 of Diamonds"),
                new Cards(6, "6 of Hearts"),
                new Cards(6, "6 of Spades"),
                new Cards(6, "6 of Clubs"),
                new Cards(7, "7 of Diamonds"),
                new Cards(7, "7 of Hearts"),
                new Cards(7, "7 of Spades"),
                new Cards(7, "7 of Clubs"),
                new Cards(8, "8 of Diamonds"),
                new Cards(8, "8 of Hearts"),
                new Cards(8, "8 of Spades"),
                new Cards(8, "8 of Clubs"),
                new Cards(9, "9 of Diamonds"),
                new Cards(9, "9 of Hearts"),
                new Cards(9, "9 of Spades"),
                new Cards(9, "9 of Clubs"),
                new Cards(10, "10 of Diamonds"),
                new Cards(10, "10 of Hearts"),
                new Cards(10, "10 of Spades"),
                new Cards(10, "10 of Clubs"),
                new Cards(11, "Jack of Diamonds"),
                new Cards(11, "Jack of Hearts"),
                new Cards(11, "Jack of Spades"),
                new Cards(11, "Jack of Clubs"),
                new Cards(12, "Queen of Diamonds"),
                new Cards(12, "Queen of Hearts"),
                new Cards(12, "Queen of Spades"),
                new Cards(12, "Queen of Clubs"),
                new Cards(13, "King of Diamonds"),
                new Cards(13, "King of Hearts"),
                new Cards(13, "King of Spades"),
                new Cards(13, "King of Clubs"),
                new Cards(14, "Ace of Diamonds"),
                new Cards(14, "Ace of Hearts"),
                new Cards(14, "Ace of Spades"),
                new Cards(14, "Ace of Clubs"),
            };
            return Deck;
        }
        public static List<Cards> Mix(List<Cards> deck)
        {
            var list1 = new List<Cards>();
            var list2 = new List<Cards>();
            for (var c = 0; c < deck.Count; c += 2)
            {
                list1.Add(deck[c]);
                list2.Add(deck[c + 1]);
            }
            List<Cards> Mix = list1.Concat(list2).ToList();

            return Mix;
        }
    }
}
