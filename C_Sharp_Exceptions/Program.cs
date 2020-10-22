using System;

namespace C_Sharp_Exceptions
{
    //When an error occurs, C# will normally stop and 
    //an error message. The technical term for this is: C# will throw an exception (throw an error).

    class Program
    {
        //C# try and catch

        static void Main(string[] args)
        {
            //The try statement allows you to define a block of code to be tested for errors while it is 
            //executed.

            //The catch statement allows you to define a block of code to be executed, if an error occurs in 
            //the try block.

            //If an error occurs, we can use try...catch to catch the error and execute some code to handle it.

            //The try and catch keywords come in pairs:

            try
            {
                //Block of code to try
                int[] myNumbers = {1, 2, 3 };
                Console.WriteLine(myNumbers[10]); //error
            }
            catch (Exception e)
            {
                //Block of code to handle errors
                Console.WriteLine(e.Message);

                //we use the variable inside the catch block (e) together with the 
                //built -in Message property,

                //Output will be 'Index was outside the bounds of the array'

            }
        }
    }
}
