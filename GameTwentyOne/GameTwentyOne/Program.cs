using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GameTwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DateTime timeOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            DateTime timeOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);
            TimeSpan ageAtGraduation = timeOfGraduation - timeOfBirth;
            */
            
            /*
            string text = "Welcome to the Grand Hotel and Casino.\r\nLet's start by telling me your name:";
            File.WriteAllText(@"C:\Users\Student\Desktop\GitHub\CSharp-Exercises\GameTwentyOne\GameTwentyOne\log.txt", text);
            text = File.ReadAllText(@"C:\Users\Student\Desktop\GitHub\CSharp-Exercises\GameTwentyOne\GameTwentyOne\log.txt");
            Console.WriteLine(text);
            */




            Console.WriteLine("Welcome to the Grand Hotel and Casino. ");
            Console.WriteLine();
            Console.Write("Let's start by telling me your Name:  ");
            string playerName = Console.ReadLine();
            Console.WriteLine();

            if(playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp);
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while(!validAnswer)
            {
                Console.Write("And how much money did you bring today?  ");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                //bank = Convert.ToInt32(Console.ReadLine());
                if (!validAnswer) Console.WriteLine("\nPlease enter digits only, no decimals...\n");
                else
                {
                    if (bank <= 0)
                    {
                        Console.WriteLine("\nYou have insufficient funds to play.\n");
                        validAnswer = false;
                        Console.ReadLine();
                        return;
                    }
                }


            }




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
                    try
                    {
                        game.Play();
                        //Console.WriteLine("Would you like to keep playing?");
                    }
                    catch (FraudException e)
                    {
                        Console.WriteLine();
                        Console.WriteLine(e.Message);
                        //Console.WriteLine("Security!!  Kick this person out!");
                        UpdateDbWithException(e);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception e)
                    {
                        
                        Console.WriteLine("\nAn error occurred.  Please contact your system administrator.\n");
                        UpdateDbWithException(e);
                        Console.ReadLine();
                    }
                    

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

        private static void UpdateDbWithException(Exception e)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=GameTwentyOne;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = "INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) " +
                "VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = e.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = e.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=GameTwentyOne;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }

                connection.Close();

                


            }

            return Exceptions;
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
