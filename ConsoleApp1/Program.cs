//Tootia
//Practice1
try
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Hours of work: ");
    Console.ResetColor();
    var hours = Convert.ToDouble(Console.ReadLine());
    var salary = hours * 3.5;
    var tax = (salary * 5) / 100;
    var finalsalary = salary - tax;
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Salary: ");
    Console.ResetColor();
    Console.Write($"{salary}");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("$");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Tax: ");
    Console.ResetColor();
    Console.Write($"{tax}");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("$");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Final salary is: ");
    Console.ResetColor();
    Console.Write($"{finalsalary}");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("$");
    Console.ResetColor();
}
catch (FormatException)
{
    Console.WriteLine("Only numbers!");
}
catch (OverflowException)
{
    Console.WriteLine("Ummm... That's too much!");
}
catch
{
    Console.WriteLine("What did you do?");
}
finally
{
    Console.WriteLine("Done!");
}
Console.Write("");
