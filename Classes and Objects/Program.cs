using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {

            //Game game = new Game();
            //game.Players = new List<string>() { "Hugo", "Paco", "Luis" };
            //game.ListPlayers();
            //game.Play();

            //section polimorphis
            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            //games.Add(game);

            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Leo", "Luis" };
            game.ListPlayers();
            Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }
    }
}
