using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    public class Card
    {
        public Suit Suit {get; set;}
        public Face Face {get; set;}

        public enum Suit
        {
            Clubs,
            Hearts,
            Diamonnds,
            Spades
        }
        public enum Face
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }

    }
}
