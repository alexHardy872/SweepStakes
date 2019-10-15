using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SweepStakes
{
    static class UI
    {
        private static Random rand = new Random();
        public static string GetManagerStyle()
        {
            string sweepstakesManagerStyle = GetUserInput("Stack or Queue structured Sweepstakes? ('S', or 'Q')").ToUpper();
            while (sweepstakesManagerStyle != "Q" && sweepstakesManagerStyle != "S")
            {
                sweepstakesManagerStyle = RetryGetUserInput("Stack or Queue structured Sweepstakes? ('S', or 'Q')").ToUpper();
            }
            return sweepstakesManagerStyle;
        }
       
        public static void MarketingFirmMenu()
        {
            Console.WriteLine("Options: {0} " +
                "{0}Create new Sweepstakes 'S'" +
                "{0}Get Sweepstakes 'G'" +    
              "{0}Exit Application 'E'", Environment.NewLine);

        }

        public static string ValidateMFMenuSelection()
        {
            string selection = GetUserInput("Type 'S', 'G', or 'E'");
            while (selection != "S" && selection != "G" && selection != "E")
            {
                selection = RetryGetUserInput("Type 'S', 'G', or 'E'");
            }
            return selection;
        }

        public static void SweepstakesMenu()
        {
            Console.WriteLine("Options: {0} " +
                "{0}Register Contestant 'R'" +
               // "{0}Pick Winner of sweepstakes 'W'"+
                "{0}Done Adding to this sweepstakes? 'D'" , Environment.NewLine);
        }



        public static string SweepstakesMenuSelection()
        {
            string selection = GetUserInput("Type 'R' or 'D'");
            while (selection != "R" && selection != "D")
            {
                selection = RetryGetUserInput("Type 'R', or 'D'");
            }
            return selection;
        }

        public static void GETSweepstakesMenu()
        {
            Console.WriteLine("Options: {0} " +
               // "{0}Register Contestant 'R'" +
                "{0}Pick Winner of sweepstakes 'W'"+
                "{0}Done Adding to this sweepstakes? 'D'", Environment.NewLine);
        }



        public static string GETSweepstakesMenuSelection()
        {
            string selection = GetUserInput("Type 'W' or 'D'");
            while ( selection != "W" && selection != "D")
            {
                selection = RetryGetUserInput("Type 'W' or 'D'");
            }
            return selection;
        }

        public static void DisplaySweepstakes(Sweepstakes sweepstakes)
        {
            Console.WriteLine(sweepstakes.name + ": " + sweepstakes.usedList.Count + " registered contestants");
        }


        public static string GetUserInput(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }


        public static string RetryGetUserInput(string question)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(question);
            Console.ResetColor();
            return Console.ReadLine();
        }

        public static void Error(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
            
        }



        public static int GetUserInputInt(string question)
        {
            Console.WriteLine(question);
            int number = CheckToInt(Console.ReadLine());

            return number;
        }


        public static string RetryGetUserInputInt(string question)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(question);
            Console.ResetColor();
            return Console.ReadLine();
        }


        public static int CheckToInt(string stringNum)
        {
           bool success = Int32.TryParse( stringNum, out int result);
           while (success == false)
            {
              string retry = RetryGetUserInputInt("Not a valid number input, try again!");
              success = Int32.TryParse(retry, out result);
            }
            return result;
        }


        public static void GetContestantInformation(Contestant contestant)
        {
            contestant.firstName = GetFirstName();
            contestant.lastName = GetLastName();
            contestant.email = GetEmail();
        }

        public static void DisplayContestantInformation(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName + " " + contestant.lastName);
            Console.WriteLine(contestant.email);
            Console.WriteLine("Registration number: " + contestant.registrationNumber);
        }


        public static string GetFirstName()
        {
            return GetUserInput("Enter the contestant's FIRST name");
        }


        public static string GetLastName()
        {
            return GetUserInput("Enter the contestant's LAST name");
        }


        public static string GetEmail()
        {
            string email = GetUserInput("Enter the contestant's EMAIL adress");
            bool success = IsValidEmail(email);
            while (success == false)
            {
                email = RetryGetUserInput("email not valid.. please enter a valid EMAIL adress");
                success = IsValidEmail(email);
            }
            return email;
        }



        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress validEmail = new MailAddress(email);
                return validEmail.Address == email;
            }
            catch
            {
                return false;
            }
        }

        

        public static int GenerateRandomNumber(int min, int max)
        {
            int randNum = rand.Next(min, max);
            return randNum;
        }

        





















    }
}
