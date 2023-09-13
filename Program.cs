namespace MyFirstProgram
{
    internal class Program
    {
        //Jana Johansson .NET23
        static void Main(string[] args)
        {

            int Number = 4; // A variable that saves the number I choose.

            if (Number > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else if (Number < 10)
            {
                Console.WriteLine("Oj. lågt tal!");
            }
            // if and else if method, tells the program what to put out depending on the result.

            Console.WriteLine("Vad heter du?");

            string name = Console.ReadLine(); // Allows the user to type their name

            Console.WriteLine("Hej " + name + ("!"));

            for (int i = 0; i<=5; i++) // A for-loop that counts up to 5.
            {
                Console.WriteLine(i);
            }


            }

        }
    }