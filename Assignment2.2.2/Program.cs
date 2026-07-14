
//Assignment 2.2.2 +++++++++++++++++++++++++++++++++++++++++++++++


Console.WriteLine("Available Calculations:");
Console.WriteLine("1. Add two integers");
Console.WriteLine("2. Add three decimal numbers");
Console.WriteLine("3. Multiply two float numbers");
Console.WriteLine("4. Multiply three float numbers");

Console.Write("Enter your choice: ");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.Write("Enter the first integer: ");
        int intNum1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int intNum2 = Convert.ToInt32(Console.ReadLine());

        int addIntResult = Maths.Add(intNum1, intNum2);

        Console.WriteLine($"Result: {addIntResult}");
        break;

    case 2:
        Console.Write("Enter the first decimal number: ");
        decimal decimalNum1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter the second decimal number: ");
        decimal decimalNum2 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter the third decimal number: ");
        decimal decimalNum3 = Convert.ToDecimal(Console.ReadLine());

        decimal addDecimalResult =
            Maths.Add(decimalNum1, decimalNum2, decimalNum3);

        Console.WriteLine($"Result: {addDecimalResult}");
        break;

    case 3:
        Console.Write("Enter the first float number: ");
        float floatNum1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the second float number: ");
        float floatNum2 = Convert.ToSingle(Console.ReadLine());

        float multiplyTwoResult =
            Maths.Multiply(floatNum1, floatNum2);

        Console.WriteLine($"Result: {multiplyTwoResult}");
        break;

    case 4:
        Console.Write("Enter the first float number: ");
        float floatNum3 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the second float number: ");
        float floatNum4 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the third float number: ");
        float floatNum5 = Convert.ToSingle(Console.ReadLine());

        float multiplyThreeResult =
            Maths.Multiply(floatNum3, floatNum4, floatNum5);

        Console.WriteLine($"Result: {multiplyThreeResult}");
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}

public class Maths
{
    
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    
    public static decimal Add(decimal num1, decimal num2, decimal num3)
    {
        return num1 + num2 + num3;
    }
    
    public static float Multiply(float num1, float num2)
    {
        return num1 * num2;
    }
    
    public static float Multiply(float num1, float num2, float num3)
    {
        return num1 * num2 * num3;
    }
}