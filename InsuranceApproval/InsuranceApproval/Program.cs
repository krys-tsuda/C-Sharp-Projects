using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program introduction
            Console.WriteLine("Insurance Approval Application\n\n");
            Console.WriteLine("Applicant, please supply the following information.\n");

            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());  // stores applicants age as integer
            bool ofAge = yourAge > 15;  // true if applicants age is over 15

            Console.WriteLine("\nHave you ever had a DUI? [y/n]");
            bool duiStatus = (Console.ReadLine().ToLower() == "y"); // true if dui status is yes 

            Console.WriteLine("\nHow many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());  // stores applicants tickets as integer
            bool ticketLimit = tickets > 3;    // true if tickets are greater than 3

            Console.WriteLine("\nPress enter if you'd like to submit your application for approval.");
            Console.ReadKey();

            bool approved = (ofAge && !duiStatus && !ticketLimit);  // approved if ofAge is true and not true duiStatus and not true ticketLimit
            
            if (approved)
            {
                Console.WriteLine("\nCongratulations, your application has been approved!");  // if approved is true print message
            }
            else
            {
                Console.WriteLine("\nThank you for applying. Unfortunatley we can not approve you today.");   // if approved not true print message
            }

            Console.WriteLine("\nPress any key to close program.");
            Console.ReadKey();
        }
    }
}
