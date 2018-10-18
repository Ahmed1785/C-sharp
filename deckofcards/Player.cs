using System.Collections.Generic;

namespace ConsoleApplication {
    public class Player {
        public string name;
        private List<Card> hand;

        public Player(string thing) {
            hand = new List<Card>();
            name = thing;
        }
        public void DrawFrom(Deck currentDeck) {
            hand.Add(currentDeck.Deal());
        }
        public Card Discard(int idx) {
            Card temp = hand[idx];
            hand.RemoveAt(idx);
            return temp;
        }
    }
}