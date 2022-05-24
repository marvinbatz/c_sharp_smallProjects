Console.WriteLine("Enter the selected operation: ");
int caseSwitch = int.Parse(Console.ReadLine());
float num1, num2;
float result = 0;

switch (caseSwitch)
{
    case 1:
        Console.WriteLine("Enter the first number: ");
        num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        num2 = float.Parse(Console.ReadLine());
        result = num1 + num2;
        break;
    case 2:
        Console.WriteLine("Enter the first number: ");
        num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        num2 = float.Parse(Console.ReadLine());
        result = num1 - num2;
        break;
    case 3:
        Console.WriteLine("Enter the first number: ");
        num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        num2 = float.Parse(Console.ReadLine());
        result = num1 * num2;
        break;
    case 4:
        Console.WriteLine("Enter the first number: ");
        num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        num2 = float.Parse(Console.ReadLine());
        result = num1 / num2;
        break;
    default:
        Console.WriteLine("ERROR: Incorrect value.");
        break;
}
Console.WriteLine("The result is: " + result);