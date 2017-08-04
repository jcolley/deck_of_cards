using System;
using System.Collections.Generic;

namespace deckofcards
{
  class Deck
  {
    public List<Card> cards = new List<Card>();
    public string[] suits = {"Spades", "Hearts", "Diamonds", "Clubs"};
    public string[] ranks = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
    public Deck()
    {
      defaultDeck();
    }
    public Deck shuffle()
    {
      int unshuffled = cards.Count;
      Card backCard;
      int randomIndex;
      Random rand = new Random();
      while (unshuffled > 0)
      {
        randomIndex = rand.Next(0,52);

        backCard = cards[--unshuffled];

        cards[unshuffled] = cards[randomIndex];

        cards[randomIndex] = backCard;
      }
      return this;
    }
    public void printOut()
    {
      foreach (Card card in cards)
            {
                Console.WriteLine("I am the {0} of {1} and my value is {2}",
                    card.stringVal, card.suit, card.val);
            }
    }
    public void defaultDeck()
    {
      cards = new List<Card>();
      foreach (string suit in suits)
      {
        int value = 0;
        foreach (string rank in ranks)
        {
          cards.Add(new Card(rank, suit, ++value));
        }
      }
    }
    public Card deal(){
      Card dealt = cards[0];
      cards.RemoveAt(0);
      return dealt;
    }
  }
}