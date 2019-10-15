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

        public static string GetManagerStyle()
        {
            string sweepstakesManagerStyle = GetUserInput("Stack or Queue structured Sweepstakes? ('S', or 'Q')").ToUpper();
            while (sweepstakesManagerStyle != "Q" && sweepstakesManagerStyle != "S")
            {
                sweepstakesManagerStyle = RetryGetUserInput("Stack or Queue structured Sweepstakes? ('S', or 'Q')").ToUpper();
            }
            return sweepstakesManagerStyle;
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


        public static void GetContestantInformation(Contestant contestant, Random random)
        {
            contestant.firstName = GetFirstName();
            contestant.lastName = GetLastName();
            contestant.email = GetEmail();
            contestant.registrationNumber = GenerateRandomNumber(random, 100000, 999999);
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

        

        public static int GenerateRandomNumber(Random random, int min, int max)
        {
            int rand = random.Next(min, max);
            return rand;
        }

        





















    }
}
