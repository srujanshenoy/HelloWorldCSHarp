class Program
{
    static double double_input(string prompt)
    {
        while (true)
        {
            try
            {
                Console.WriteLine(prompt);
                return Convert.ToDouble(Console.ReadLine());
            }

            catch 
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }

    static double Calculate(double x, double y, char @operator)
    {
        if (@operator == '+') { return x + y; }
        if (@operator == '-') { return x - y; }
        if (@operator == '*') { return x * y; }
        if (@operator == '/') { return x / y; } else {return 0;}
    }

    static char Operator_in()
    {
        while (true)
        {
            Console.WriteLine("Operator (+, -, *, /): ");
            string userInput = Console.ReadLine();
            string[] operators = { "+", "-", "*", "/" };

            if (operators.Contains(userInput)) { return userInput; })
            else


            
        }
    } 

    static bool Continue_game()
    {
        Console.WriteLine("Do you want to continue? Press enter for yes or anything then enter for no.");
        var userInput = Console.ReadLine();

        if (userInput == Convert.ToString(' ')) {return true;}
        else {return false;}
    }

    static void Main()
    {
        var x = double_input("x: ");
        char @operator = Operator_in();
        var y = double_input("y: ")
        Calculate(x, y, @operator);
    }
}