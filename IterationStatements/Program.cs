namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintedNumber()
        {
            Console.WriteLine("Enter a low integer: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a high integer: ");
            int endNum = int.Parse(Console.ReadLine());

         
            for (int i = startNum; i <= endNum; i++)
            {
                Console.WriteLine(i);
            }
            
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void IncrementByThree()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void EqualOrNot(int firstInt, int secondInt)
        {
            
            if (firstInt == secondInt)
            {
                Console.WriteLine($"Wow! {firstInt} is equal to {secondInt}");
            }

            else
            {
                Console.WriteLine($"Sorry! {firstInt} is not equal to {secondInt}");
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int givenNumber)
        {        
            if ( (givenNumber % 2) == 0)
            {
                Console.WriteLine($"{givenNumber} is even!");
            }
            else
            {
                Console.WriteLine($"{givenNumber} is odd!");
            }
        }
        
        //Write a method to check whether a given number is positive or negative

        public static void PosOrNeg(int givenNumber)
        {
            if (givenNumber > 0)
            {
                Console.WriteLine($"{givenNumber} is positive!");
            }
            else if (givenNumber < 0)
            {
                Console.WriteLine($"{givenNumber} is negative!");
            }
            else
            {
                Console.WriteLine($"{givenNumber} is neither positive or negative!");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CanIVote()
        {
            Console.WriteLine("How old are you?");
            var voterAge = int.Parse(Console.ReadLine());

            if (voterAge >= 18)
            {
                Console.WriteLine($"You can vote because you are {voterAge} years old!");
            }
            else
            {
                Console.WriteLine("Sorry, you can't vote because you aren't at least 18 years old!");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void InRange()
        {
            Console.WriteLine("Please enter a number (think small!): ");
            var intInRange = int.Parse(Console.ReadLine());

            if ( intInRange >= -10 && intInRange <= 10)
            {
                Console.WriteLine($"{intInRange} lies within the range from -10 to 10!");
            }

            else
            {
                Console.WriteLine($"{intInRange} lies outside of the range from -10 to 10.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultTable(int intForTable)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {intForTable} = {i*intForTable}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            // Call PrintedNumber Method
            PrintedNumber();

            // Call IncrementByThree Method
            IncrementByThree();

            // Initialize a start and end integer, pass values into EqualOrNot method
            Console.WriteLine("Enter an integer: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another integer: ");
            int endNum = int.Parse(Console.ReadLine());

            EqualOrNot(startNum,endNum);

            // Prompt for a number to check if it is even/odd with EvenOrOdd method
            Console.WriteLine("Enter a number to see if it's even or odd: ");
            var evenOddTest = int.Parse(Console.ReadLine());
            EvenOrOdd(evenOddTest);

            // Prompt for a number to see if it is positive or negative
            Console.WriteLine("Enter a number to see if it's positive or negative: ");
            var posNegTest = int.Parse(Console.ReadLine());
            PosOrNeg(posNegTest);

            // Calling CanIVote method
            CanIVote();

            // Calling InRange method
            InRange();

            // Prompting for a number to pass into MultTable method
            Console.WriteLine("Enter a number to see the products with numbers 1 through 12");
            int inputMultiplier = int.Parse(Console.ReadLine());
            MultTable(inputMultiplier);

        }
    }
}
