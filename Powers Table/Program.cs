class Program
{
    public static void Main()
    {
        Console.WriteLine("Learn your squares and cubes!");
        bool goAgain = true;

        while (goAgain == true)
        {

            Console.WriteLine("\nPlease enter an integer:");
            
            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 1290)
            {
                Console.WriteLine("\n\tNumber  Squared  Cubed");
                Console.WriteLine("\t======  =======  ======");

                for (int numStart = 1; numStart <= num; numStart++)
                {
                    double square = numStart * numStart;
                    double cube = numStart * numStart * numStart;

                    Console.WriteLine("\t " + numStart + "\t " + square + "\t  " + cube);
                }
            }
            else if (num > 1290)
            {
                Console.WriteLine("That number was too large!\n");
                continue;
            }
            else
            {
                Console.WriteLine("That number was too small!\n");
                continue;
            }

            goAgain = RunAgain();
        }
    }

    public static string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        return input;

    }
    public static bool RunAgain()
    {
        string answer = GetUserInput("\n\nWould you like to go again? y/n ").ToLower();

        if (answer == "y")
        {
            return true;
        }
        else if (answer == "n")
        {
            Console.WriteLine("\nGoodbye!");
            return false;
        }
        else
        {
            Console.WriteLine("\nI'm sorry, I didn't understand that. \nPlease input y or n next time.");
            return RunAgain();
        }

    }

}
