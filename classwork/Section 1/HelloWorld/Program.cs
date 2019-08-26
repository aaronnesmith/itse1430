using System;
namespace HelloWorld
{
    // parameters are camelCase

    class Program
    { 
        static void Main ( /*string[] args*/ )
        {
            string name ="";

           
            // string if = "";

            //Definitely assigned
            //name = "Aaron";
            string name2 = Console.ReadLine ();
            //name2 = Console.Readline ();

            name2 = name = "Aaron";
            Console.WriteLine (name2);
            Console.WriteLine ("Hello World!");

            int hours = 8;
            double payRate = 15.25;

            double totalPay = payRate * hours; 

            string fullName = "Fred" + " " + "Jones";
       
        }
    }
}
