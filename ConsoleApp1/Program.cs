//Tootia
//Practice1
/*
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
*/

//Practice2
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("You must enter a four-digit number: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("ABCD!");
Console.ResetColor();
try
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("Enter A: ");
    Console.ResetColor();
    var numberA = Convert.ToByte(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("Enter B: ");
    Console.ResetColor();
    var numberB = Convert.ToByte(Console.ReadLine());


    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("Enter C: ");
    Console.ResetColor();
    var numberC = Convert.ToByte(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("Enter D: ");
    Console.ResetColor();
    var numberD = Convert.ToByte(Console.ReadLine());
    var finalNumber = (numberA * 1000) + (numberB * 100) + (numberC * 10) + numberD;
    Console.Write("The number is ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"{finalNumber}");
    Console.ResetColor();

    Console.WriteLine("If yes press a key to show the reverse.");
    Console.ReadKey();
    var reverse = (numberD * 1000) + (numberC * 100) + (numberB * 10) + (numberA);
    Console.Write("The reverse is ");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"{reverse}");
    Console.ResetColor();
}
catch (FormatException)
{
    Console.WriteLine("Number i said!");
}
catch (OverflowException)
{
    Console.WriteLine("For each digits i made a name!");
}
finally
{
    Console.WriteLine("Done!");
}
Console.Write("");
