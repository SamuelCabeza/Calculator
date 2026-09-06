using System.Text.RegularExpressions;
using CalculatorLibrary;


Calculator calculator = new Calculator();
bool endApp = false;
// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

while (!endApp)
{
    //Times used
    Console.WriteLine("Times used: " + calculator.GetTimesUsed());

    // Ask the user to choose an operator.
    string? op = calculator.AskOption(0);

    // Validate input is not null, and matches the pattern
    if (op == null || !Regex.IsMatch(op, "^(a|s|m|d|l|c|pc|sr|p|tn|sine)$"))
    {
        Console.WriteLine("Error: Unrecognized input.");
    }
    else
    {

        switch (op)
        {
            case "a":
            case "s":
            case "m":
            case "d":
            case "sr":
            case "p":
            case "tn":
            case "sine":
                calculator.Calculate(op);
                break;
            case "l":
                calculator.GetCalculations();
                break;
            case "c":
                 calculator.DeleteCalculation();
                break;
            case "pc":
                calculator.CalculateWithPreviousCalculations();
                break;
        }

 
    }
    Console.WriteLine("------------------------\n");

    // Wait for the user to respond before closing.
    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
    if (Console.ReadLine() == "n") endApp = true;

    Console.WriteLine("\n"); // Friendly linespacing.
}

calculator.Finish();
return;
