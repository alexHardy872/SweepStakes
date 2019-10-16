using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SweepStakes
{
  
   public  class Contestant : IContestant
    {

        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;
        public bool isWinner;

        public Contestant()
        {

            isWinner = false;
        }


        public void NotifyContestant(string sweepstakes) // just expeeriment to mess with MailAdress
        {
            MailMessage mail = new MailMessage();
                
                    mail.From = new MailAddress("alexhardy872@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = "";
                    mail.Body = "";
                    mail.IsBodyHtml = true;
                    if (isWinner == true)
                    {
                        mail.Subject = "WINNER!";
                        mail.Body = "<h1> CONGRADUALTONS! "+firstName+" "+lastName+" </h1> <p> You won the "+sweepstakes+" sweepskates! </p>";

                    }
                    else
                    {
                        mail.Subject = "SORRY!";
                        mail.Body = "<h1> SORRY! " + firstName + " " + lastName + "</h1> <p> You did <strong>NOT</strong> win the  " + sweepstakes + " sweepstakes, better luck next time!</p>";
                    }
             
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                
                    smtp.Credentials = new System.Net.NetworkCredential("alexhardy872@gmail.com", "sock872@UWL");
                    smtp.EnableSsl = true;
            try
            {
                smtp.Send(mail);
            }
                    

            
            catch (Exception e)
            {
                // email adress not found or unsuccessful
            }

        }

      
        




    }
}
