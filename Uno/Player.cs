using System;
namespace Uno
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }


        public Player()
        {
            Name = "";
            Hand = new List<Card>();
        }

        public bool HasPlayableCard(Card card)
        {

        }

        public Card GetFirstPlayableCard(Card card)
        {
            return new Card();
        }

        public Color MostCommonColor()
        {
            int red = 0;
            int yellow = 0;
            int blue = 0;
            int green = 0;
            foreach (card in Hand)
            {

            }
            return Color.Blue;
        }


    }
}

