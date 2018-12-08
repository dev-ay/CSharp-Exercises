using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTwentyOne
{
    public class GameTwentyOne : Game, IWalkAway
    {
        public DealerTwentyOne Dealer { get; set; }

        public override void Play()
        {
            Dealer = new DealerTwentyOne();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            //Take bets from all players
            

            foreach(Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;

                while (!validAnswer)
                {
                    Console.Write("Place your bet! ... ");
                    validAnswer = int.TryParse(Console.ReadLine(),out bet);
                    //int bet = Convert.ToInt32(Console.ReadLine());
                    if (!validAnswer) Console.WriteLine("\nPlease enter digits only, no decimals\n");
                }

                if (bet < 0)
                {
                    throw new FraudException("Security!!  Kick this person out!");
                }
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }

                Bets[player] = bet;
                player.Balance -= bet;
            }

            Console.WriteLine();

            //Deal each player 2 cards
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("\t{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = RulesTwentyOne.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            Console.WriteLine("\nBlackjack! {0} wins {1}.  Your balance is now {2}\n", player.Name, Bets[player],player.Balance);

                            Console.Write("Play again?  ");
                            string answer = Console.ReadLine().ToLower();
                            Console.WriteLine();
                            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
                            {
                                player.isActivelyPlaying = true;

                            }
                            else
                            {
                                player.isActivelyPlaying = false;
                            }

                            return;
                        }

                    }
                }

                //Deal the Dealer one hand
                Console.Write("\tDealer: ");
                Dealer.Deal(Dealer.Hand);
                
                if (i == 1)
                {
                    bool blackJack = RulesTwentyOne.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Dealer has Blackjack!  Everyone loses!\n");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }

                        foreach(Player player in Players)
                        {
                            Console.Write("Play again?  ");
                            string answer = Console.ReadLine().ToLower();
                            Console.WriteLine();
                            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
                            {
                                player.isActivelyPlaying = true;

                            }
                            else
                            {
                                player.isActivelyPlaying = false;
                            }

                        }

                        return;
                    }
                }

            }
            Console.WriteLine();
            //If no one wins, continue to ask which players wish to stay
            foreach(Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    Console.Write("\t");
                    foreach(Card card in player.Hand)
                    {
                        Console.Write("{0}, ", card.ToString());
                    }
                    Console.WriteLine();

                    Console.WriteLine("Dealer's cards are: ");
                    Console.Write("\t");
                    foreach (Card card in Dealer.Hand)
                    {
                        Console.Write("{0}, ", card.ToString());
                    }
                    Console.WriteLine();

                    Console.Write("\nHit or stay?  ");
                    string answer = Console.ReadLine().ToLower();

                    if(answer == "stay")
                    {
                        player.Stay = true;
                        Console.WriteLine();
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Console.Write("\t");
                        Dealer.Deal(player.Hand);
                        Console.WriteLine();

                        bool blackJack = RulesTwentyOne.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            Console.WriteLine("Blackjack! {0} wins {1}.  Your balance is now {2}\n", player.Name, Bets[player], player.Balance);

                            Console.Write("Play again?  ");
                            answer = Console.ReadLine().ToLower();
                            Console.WriteLine();
                            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
                            {
                                player.isActivelyPlaying = true;

                            }
                            else
                            {
                                player.isActivelyPlaying = false;
                            }

                            return;

                        }

                    }
                    bool busted = RulesTwentyOne.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted!  You lose your bet of {1}.  Your balance is now {2}\n", player.Name, Bets[player], player.Balance);
                        //Console.WriteLine("Dealer balance: {0}\n", Dealer.Balance);
                        Console.Write("Do you want to play again?  ");
                        answer = Console.ReadLine().ToLower();
                        Console.WriteLine();
                        if(answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            

            //Check if Dealer is busted as well as if Dealer should stay
            Dealer.isBusted = RulesTwentyOne.IsBusted(Dealer.Hand);
            Dealer.Stay = RulesTwentyOne.ShouldDealerStay(Dealer.Hand);

            while(!Dealer.Stay && !Dealer.isBusted){
                Console.WriteLine("Dealer is hitting...");
                Console.Write("\t");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = RulesTwentyOne.IsBusted(Dealer.Hand);
                Dealer.Stay = RulesTwentyOne.ShouldDealerStay(Dealer.Hand);
                Console.WriteLine();
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.\n");

            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!\n");
                foreach(KeyValuePair<Player,int> entry in Bets)
                {
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Console.WriteLine("{0} won {1}!  Your balance is now {2}\n", entry.Key.Name, entry.Value, entry.Key.Balance);
                    Dealer.Balance -= entry.Value;

                    Console.Write("Play again?  ");
                    string answer = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
                    {
                        Players.Where(x => x.Name == entry.Key.Name).First().isActivelyPlaying = true;

                    }
                    else
                    {
                        Players.Where(x => x.Name == entry.Key.Name).First().isActivelyPlaying = false;
                    }

                }
                //Console.WriteLine("Dealer balance: {0}\n",Dealer.Balance);

                return;
            }

            //Compare who has larger hand
            foreach(Player player in Players)
            {
                //turns boolean into 3 state boolean that accepts Null
                bool? playerWon = RulesTwentyOne.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push!  No one wins.\n");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    player.Balance += (Bets[player] * 2);
                    Console.WriteLine("{0} won {1}!  Your balance is now {2}\n", player.Name, Bets[player],player.Balance);
                    Dealer.Balance -= Bets[player];
                    //Console.WriteLine("Dealer balance: {0}\n",Dealer.Balance);
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!  Your balance is now {1}\n", Bets[player],player.Balance);
                    Dealer.Balance += Bets[player];
                }

                Console.Write("Play again?  ");
                string answer = Console.ReadLine().ToLower();
                Console.WriteLine();
                if(answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
                {
                    player.isActivelyPlaying = true;

                }
                else
                {
                    player.isActivelyPlaying = false;
                }

            }


        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
