using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;

namespace LearningFundamentals


{

    class Program
    {
       
        
        public static void Main(string[] args)
        {

            /*............................................*/
            /*/*
             * Boolean Type
             #1#
            int a = 1;
            int b = 2;
// Which one is greater?
            bool greaterAB = (a > b);
// Is 'a' equal to 1?
            bool equalA1 = (a == 1);
// Print the results on the console
            if (greaterAB)
            {
                Console.WriteLine("A > B");
            }
            else
            {
                Console.WriteLine("A <= B");
            }
            Console.WriteLine("greaterAB = " + greaterAB);
            Console.WriteLine("equalA1 = " + equalA1);

            string o = "World";
            string c = "Hello";

            bool equal = (
                c == "Hello"
                );
            bool notEqual = (o != "Hello");
            /* See the output to the console#1#
            if (equal)
            {
                Console.WriteLine("O == C");
            }
            else
            {
                Console.WriteLine("O==C");
            }
            Console.WriteLine("equal = " +equal);
            Console.WriteLine("notEqual = " +notEqual);
            Console.ReadLine();*/


            /*............................................*/
            /*
             * Simple problem solving programs.
             */

            /*int x;
            int t;
            
            x = 7;
            t = x + 3;
            Console.WriteLine(x);
            Console.WriteLine(t);
            Console.ReadLine();
            */


            /*
            string age;
            string text;
            
            age = "twenty six";
            text = "He is " + age + " years old.";
            Console.WriteLine(text);
            Console.WriteLine("What is this?");
            Console.ReadLine();*/

            /*............................................*/
            /*
             * User Input
             */

            /*Console.WriteLine("What is your name?");
            Console.Write("Type your firstname: ");
            string myFirstName;
            myFirstName = Console.ReadLine();
            Console.WriteLine(myFirstName);
            
            string myFirstname;
            myFirstname = Console.ReadLine();
            Console.WriteLine(myFirstname);
            
            Console.WriteLine("Continue");
            Console.Write("Type your last name: ");
            string myLastName;
            myLastName = Console.ReadLine();
            Console.WriteLine(myLastName);*/


/*............................................*/
            /*
             * Concatenation of Mixed Types
             */
            /*string s;
                s= "Four: " + 2 + 2;
            Console.WriteLine(s);

            string s1 = "Four: " + (2 + 2);
            Console.WriteLine(s1);*/


            /*............................................*/

            /*
            string str;
            str = "Hello World!";
// Print (the normal way)
            Console.WriteLine(str);
// Print (through formatting string)
            Console.Write("{0}", str);
            Console.Write("{0}", str);
            */


            /*............................................*/
            /*string name = "John";
            int age = 18;
            string town = "Seattle";
            Console.Write(
                "{0} is {1} years old from {2}!\n", name, age, town);
            Console.Write(
                "{0} is {1} years old from {2}!\n", name, age, town);*/

            /*..............................................*/
            /*
             *  Conditional Statement
             */
            /*Console.WriteLine("Bod's Gig Gateway");
            Console.Write("Select a door: 1, 2 or 3: ");
            string userChoice = Console.ReadLine();

            string message;*/

            /*if (userChoice == "1")
            {
                message = "You won a dog";
            }
            else if(userChoice == "2")
            {
                message = "You won a Bike";
             
            }else if (userChoice == "3")
            {
                message = "You won a wallet";
            }
            else
            {
                message = "Sorry, I didn't understand.";
                message = message + "You Lose.";

            }
             Console.WriteLine(message);
            Console.ReadLine();
            */



            /*message = (userChoice == "1") ? "boat" : "stand of lint";
            
            Console.WriteLine("You entered: {0}, therefore you won a {1}.",userChoice, message);
            
            Console.ReadLine();*/


            /*..............................................*/
            /*
             *  For Iterations
             */
            /*for (int i = 0; i <= 10; i= i + 3)
            {
                Console.WriteLine("Out put= " + i);
            }
            string [] cars = { "BMW", "Lexus", "Toyota"};
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }*/

            /*int[] number = new int[] {4,4,5,7,89};
            for (int i = 0; i <= number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.ReadLine();*/

            /*
            string[] names = new string[] { "Mary", "Juliet", "Mackenzi","Meghan" };
            for (int i = 0; i < names.Length; ++i)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */


/*........................*/
/*Reverse an array with C# */
            /*string zig = "You can";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine( charArray);

            foreach (char zigChar in charArray)
            {
                Console.WriteLine(zigChar);
            }
            {
                
            }*/
            /*........................*/
/*Defining and calling simple methods */
            /*bool displayOrder = true;
            while (displayOrder == true)
            {
                displayOrder = Iterate();
            }*/

            WorkingWithStrings();
            PrintSign(2);
            ReverseString();
            Methods();
            PrintCompanyInformation();
            Console.ReadLine();

/* While Iteration*/


        }

        private static void Methods()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Microsoft");
            Console.WriteLine("www.microsoft.com");
        }

        static void PrintCompanyInformation()
        {
// Invoking the Method() method
            Methods();
            Console.WriteLine("Address: One, Microsoft Way");
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
                
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
        

        static void ReverseString()
        {
            string Message = "Hello C#";
            char[] messageArray = Message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (var item in messageArray)
            {
                Console.Write(item);
            }
        }
        private static bool Iterate()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Prime Number");
            Console.WriteLine("2 Guessing Game");
            Console.WriteLine("3 exit");

            String result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumber();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                correctAnswer();
                return false;
            }
            else
            {
                return true;
            }


        }
        
    

    private static void PrintNumber()
        {
            Console.Clear();
            Console.WriteLine("Print numbers");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result)
            {
                Console.Write(counter);
                Console.Write(".");
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                String result = Console.ReadLine();
                guesses++;

                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            } while (incorrect);
            Console.WriteLine("Correct! it took you {0} guesess.", guesses);
        
            
        }

        private static void correctAnswer()
        {
            Console.WriteLine("You choose number 3");
         
        }

        private static void WorkingWithStrings()
        {
            /*String myString =  "My \"so-called\"world." ;*/
            /*
            String myString = "What if i need a \n new line?";
            */
            /*
            String myString = "Go to your c:\\ drive";
            */
            /*
            String myString = String.Format("{1} = {0}", "first", "Second");
            */
            /*
            String myString = String.Format("{0:C}", 123.45);
            */
            /*
            String myString = String.Format("{0:N}", 1234567890);
            */
            /*
            String myString = String.Format("Percentage {0:P}", .123);
            */
            /*
            String myString = String.Format("Phone number: {0:(###) ### ######}", 254745345345);
            */
            String myString = "That summer we took threes across the board ";
            myString = myString.Substring(6, 14);
            Console.WriteLine(myString);
          
            
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2000;
            myCar.Color = "Grey";
            Console.WriteLine("{2} {3} {1} {0}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
           

            Console.WriteLine("{2} {3} {1} {0}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            decimal value = DetermineMarketValue(myCar);
            Console.WriteLine("{0:C}", value);
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
          

        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;
            

            return carValue;
        }
    

       
    }
    class Car
    {
        public String Make { get; set; }
        public String Model { get; set; }
        public int Year { get; set; }
        public String Color { get; set; }


        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;
        }
    }
}

