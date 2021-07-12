using System;

namespace EEG_REWRITE
{
    class Program
    {
        static void Main(string[] args)
        {
            string course;
            string input;

            //while (true){

                Console.WriteLine("Please Enter you're part-time or full-time");
                input = Console.ReadLine();

                if (input.Substring(0,4).ToLower().Contains("full"))
                {
                    Console.WriteLine("Enter your course of study in full-Time:");
                    course =Console.ReadLine();
                    Console.WriteLine(course+"is a good course");
                    //break;
                }

                if (input.Substring(0,4).ToLower().Contains("part"))
                {
                    Console.WriteLine("How many credit are you taking ?");
                    int partTimeCredit = Convert.ToInt32(Console.ReadLine());
                    if (partTimeCredit > 6)
                    {
                        Console.WriteLine("To much for a part-time student.");
                        // continue;
                    }
                    else
                    {
                        Console.WriteLine("Proceed to the screen,");
                        //break;
                    }
                }

                //}
        }
    }
}

