using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Hotel and Casino. ");
            Console.WriteLine();
            Console.Write("Let's start by telling me your Name:  ");
            string playerName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("And how much money did you bring today?  ");
            int bank  = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine();
            Console.Write("Hello, {0}.  Would you like to join a game of 21 right now?  ",playerName);
            string answer = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
            {
                Player player = new Player(playerName,bank);
                Game game = new GameTwentyOne();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                    //Console.WriteLine("Would you like to keep playing?");

                }
                game -= player;
                Console.WriteLine("Thank you for playing!");

            }
            Console.WriteLine("Feel free to look around the casino.  Bye for now.");
            Console.ReadLine();














            //Game game = new GameTwentyOne();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "dev-ay";
            //game += player;
            //game -= player;

            //GameTwentyOne game = new GameTwentyOne();
            //game.Dealer = "dev-ay";
            //game.Name = "Twenty One";
            //game.Players = new List<string>() { "Joe", "Jon", "Jane", "Jasmine" };
            //game.ListPlayers();
            //game.Play();

            //Console.ReadLine();


            //Deck NewDeck = new Deck();
            //int timesShuffled = 0;
            //string test;
            ////NewDeck = Shuffle(NewDeck);
            //NewDeck.Shuffle(out timesShuffled, out test, times: 10);

            //foreach(Card SingleCard in NewDeck.Cards)
            //{
            //    Console.WriteLine(SingleCard.Face + " of " + SingleCard.Suit);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Total Number of cards in deck is " + NewDeck.Cards.Count);
            //Console.WriteLine();
            //Console.WriteLine("Deck was shuffled " + timesShuffled + " time[s].");
            //Console.WriteLine();
            ////Console.WriteLine(test);
            //Console.ReadLine();

        }

        //public static Deck Shuffle(Deck SingleDeck)
        //{
        //    List<Card> TempList = new List<Card>();
        //    Random R = new Random();

        //    while (SingleDeck.Cards.Count > 0)
        //    {
        //        int randomIndex = R.Next(0, SingleDeck.Cards.Count);
        //        TempList.Add(SingleDeck.Cards[randomIndex]);
        //        SingleDeck.Cards.RemoveAt(randomIndex);

        //    }
        //    SingleDeck.Cards = TempList;
        //    return SingleDeck;
        //}

    }
}
