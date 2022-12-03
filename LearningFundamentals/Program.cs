using System.Reflection.Metadata;
using System.Text.Json.Serialization;

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


            /*string age;
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
            string zig = "You can";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine( charArray);

            foreach (char zigChar in charArray)
            {
                Console.WriteLine(zigChar);
            }
            {
                
            }
            




        }
    }
}

