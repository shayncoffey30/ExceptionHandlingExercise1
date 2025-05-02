using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // Objective: Iterate through a character array. Try to parse each character into an integer.
            // If you attempt to parse a letter into an integer, an exception will occur. 
            // Use a try-catch statement to avoid a run-time exception.
            // Below we will set this up.
            // ------------------------------------------------------------------------------
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c', };
            var numbers = new List<int>();
            var str = "";




            // 1) Done - Create an char[], it must contain 6 numbers and 3 letters - name it arr

            // 2) Done - Create a list called numbers that will hold integers
            // 3) Done - Create an string variable with an empty string initializer - name it str
            // 4) Done - Make a foreach loop to iterate through your character array            
            foreach (var item in arr)
            {
                // Now create a try catch
                // Inside your try block
                // Set your string variable to each array element in your char[] to .ToString()
                // Now, using int.Parse, parse your string variable and store in an int variable
                // Then add each int to your list
                int number;
                try

                {
                    str = item.ToString();
                    number = int.Parse(str);

                    numbers.Add(number);

                }
                catch (Exception e)
                {
                    // catch your Exception:
                    // in the scope of your catch you can use the following,

                    Console.WriteLine($"Unable to Parse '{item}'");
                    //character will be the name of each item in your collection

                }
                finally
                {
                    Console.WriteLine(item);
                }

            }


            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
