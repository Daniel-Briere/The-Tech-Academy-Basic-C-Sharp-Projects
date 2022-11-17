using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro to daily report
            Console.WriteLine("The Tech Academy.");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            //Student name input
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();
            //Student course input
            Console.WriteLine("What Course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your Current Course is: " + yourCourse);
            Console.ReadLine();
            //Student Page input
            Console.WriteLine("What Page number are you on?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Your Page Number is: " + pageNumber);
            Console.ReadLine();
            //Student Help input
            Console.WriteLine("Do you need any help? Please answer \"true\" or \"False.\"");
            string needHelp = Console.ReadLine();
            Console.WriteLine("You answered: " + needHelp);
            Console.ReadLine();
            //Student Positive experiences input
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();
            Console.WriteLine("Your positive experience was: " + yourExperience);
            Console.ReadLine();
            //Student Feedback input
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("Your Feedback was: " + yourFeedback);
            Console.ReadLine();
            //Student Hours Studied input
            Console.WriteLine("How many hours did you study today?");
            string yourHours = Console.ReadLine();
            Console.WriteLine("Your study time was: " + yourHours);
            Console.ReadLine();
            //Exit program message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
