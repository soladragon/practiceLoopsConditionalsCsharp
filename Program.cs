using System;

namespace Treehouse.PracticeSession
{
    class Program
    {
        public static void Main()
        {
            // TODO Declare a boolean variable named "keepGoing"
            // and assign it a value of "true". Use this variable to 
            // know when to exit the while loop.
          
          bool keepGoing = true;

            // TODO Define a while loop.
            // Keep looping as long as the variable "keepGoing" has a value of "true".
          while(keepGoing){
            
          // TODO Prompt the user with the text "Enter a number:" and assign their value to an "entry" string variable.
            Console.Write("Enter a number:");
            string entry = Console.ReadLine();
            
            // TODO If the user entered the text "quit"...TODO Exit the program.
            if(entry == "quit"){
            keepGoing = false;
            } 
            // TODO Else the user didn't enter the text "quit"... 
            else {
              
              // TODO Parse the user's entry to an integer
            int numberEntry = int.Parse(entry);
              
              // TODO Square the user's provided number 
              int square = numberEntry * numberEntry;
              
                // TODO Output the result.
              Console.WriteLine("The square of " + numberEntry + " is " + square);
            }
            
          }
          
          Console.WriteLine("Goodbye!");

        }
    }
}












