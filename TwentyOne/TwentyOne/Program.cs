using System;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string text = File.ReadAllText("F:\\TechAcademy\\WorkingBranch\\Logs\\log.txt");*/    // text to be read
            //string text = "Here is some text."; // txt to be logged
            //File.WriteAllText(@"F:\TechAcademy\WorkingBranch\Logs\log.txt", text);  // file path to log txt

            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);    // new object of DateTime year someone was born
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);   // new object of DateTime   year someone graduates

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;  // new timespan object someones age at graduation (in days)

            // var can be used to replace data type
            // for readabuility should use actual data type
            //var newPlayer = new Player("Jesse");  
            // Greeting message prompts user for name assigning it to var playerName

            // for more control can create constant data type
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine($"Welcome to the {casinoName}. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            
            // Prompting player for bank assigning it to var bank
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                // lets you know if conversion succeeded or not
                Console.WriteLine("How much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);   // converts string input to int, output is bank
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            // Asking player if they want to play if yes do....
            Console.WriteLine($"Hello, {playerName}. Would you like to join a game of 21 right now?");
            string answer = Console.ReadLine().ToLower();
            // Checking for multiple answers
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);   // Creating object player with property values of playerName and bank
                player.Id = Guid.NewGuid();    // creates new global unique identifier
                using (StreamWriter file = new StreamWriter(@"F:\TechAcademy\WorkingBranch\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();    // New object of TwentyOneGame that inherits from Game using polymorphism
                game += player; // adding player to game
                player.isActivelyPlaying = true;    // bool property set to true
                while (player.isActivelyPlaying && player.Balance > 0)  // while player is playing and balance is greater than 0
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error has occured. Please contact your system administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;   
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
        // Method to update database 
        private static void UpdateDbWithException(Exception ex)
        {
            // connection string to database
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated                                      Security=True;ConnectTimeout=30;Encrypt=False;TrustServerCertificate=False;
                                      ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            // Sql query to add values to db
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @EcveptionMessage, @TimeStamp)";   // value placeholders protects db
            // using statement to control unmanaged resources
            // sql connection that automatically closes when statement is complete
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);   // takes in queryString and connectionString
                // protects against sql injection setting paramater data type
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);    
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();   // converts 'ex' to string 
                command.Parameters["@ExceptionMessage"].Value = ex.Message;    // sets value to 'ex' message
                command.Parameters["@TimeStamp"].Value = DateTime.Now;  // sets value to time now

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
    }
}
