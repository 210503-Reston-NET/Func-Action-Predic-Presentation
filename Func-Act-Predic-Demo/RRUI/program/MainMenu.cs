using System;
using RRmodels;
namespace RRUI
{
    public class MainMenu: IMenu
    {
        public void Start()
        {
            bool repeat = true;
            do{
                Console.WriteLine("Welcome to my Restaurant Reviews Application!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] View a restaurant");
                Console.WriteLine("[1] view a review");
                Console.WriteLine("[2] Exit");
                string input = Console.ReadLine();
            switch(input)
            {
                case "0":

                    break;
                case "1":
                   Reviews fancyReview = new Reviews(4, 5, 3);
                   Console.WriteLine(fancyReview.ToString()); 
                    break;
                case "2":
                    Console.WriteLine("Goodbye cruel World");
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;
            }
            }while(repeat);
        }
    }

    
}