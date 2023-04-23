Console.Write("Enter a number: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Enter another number: ");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with these 2 numbers? Press;\n+ to add them\n- to subtract them\n* to multiply\n/ To divide");
string operation = Console.ReadLine();

switch (operation)
{
        case "+":
        Console.WriteLine($"{num1}+{num2}={num1+num2}");
        break;
        case "-":
        Console.WriteLine($"{num1}-{num2}={num1 - num2}");
        break;
        case "*":
        Console.WriteLine($"{num1}*{num2}={num1 * num2}");
        break;
        case "/":
        if(num2 != 0)
        {
            Console.WriteLine($"{num1}/{num2}={num1 / num2}");
        }
        else
        {
            Console.WriteLine("A number can not be divided to zero.");
            break;
        }
        break;
        default:
        break;

}