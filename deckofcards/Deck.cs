using System;
using System.Collections.Generic;

namespace ConsoleApplication {
    public class Deck {
        private List<Card> cards;
        public Deck() {
            Reset();
        }
        public Card Deal() {
            if(cards.Count > 0){
                Card temp = cards[0];
                cards.RemoveAt(0);
                return temp;
            }
        return null;
        }
        public Deck Shuffle() {
            Random rand = new Random();
            for(var i = cards.Count - 1; i > 0; i--){
                int randomindex = rand.Next(i);
                Card temp = cards[randomindex];
                cards[randomindex] = cards[i];
                cards[i] = temp;
            }
            return this;
        }
        public Deck Reset() {
            cards = new List<Card>();
            string[] suits = new string[4] {"Hearts", "Diamond", "Spades", "Clubs"};
            foreach (var suit in suits){
                for(int val = 1; val <= 13; val++){
                    cards.Add(new Card(suit, val));
                }
            }
        return this;
        }
        public override string ToString() {
            string info = "";
            foreach(Card card in cards) {
                info += card + "\n";
            }
            return info;
        }
    }
}