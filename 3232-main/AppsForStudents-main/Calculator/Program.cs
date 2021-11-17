using System;
namespace Calculator
{
  /// <summary>
  /// Главный класс программы.
  /// </summary>
  public class Program
  {
    /// <summary>
    /// Точека входа в программу.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    public static void Main(string[] args)
    {
            Caluc();
    }
    private static void Caluc()
        {
            while (true)
            {
                string leftnumberinput;
                double leftnumber;
                string rightnumberinput;
                double rightnumber;
                double result;
                string acting;
                
                Console.WriteLine("Write first number : ");
                leftnumberinput = Console.ReadLine();
                while (!double.TryParse(leftnumberinput,out leftnumber)){
                    Console.WriteLine("Wrong input. Try again");
                    Console.WriteLine("Write first number : ");
                    leftnumberinput = (Console.ReadLine());
                }
                Console.WriteLine("Write next number : ");
                rightnumberinput = Console.ReadLine();
                while (!double.TryParse(rightnumberinput, out rightnumber))
                {
                    Console.WriteLine("Wrong input. Try again");
                    Console.WriteLine("Write next number : ");
                    rightnumberinput = (Console.ReadLine());
                }
                Console.WriteLine("Write action with namber :");
                acting = Console.ReadLine();
                switch (acting)
                {
                    case "+":
                        result = leftnumber + rightnumber;
                        break;
                    case "-":
                        result = leftnumber - rightnumber;
                        break;
                    case "*":
                        result = leftnumber * rightnumber;
                        break;
                    case "/":
                        result = leftnumber / rightnumber;
                        break;
                    default:
                        result = 0;
                        break;
                }
                Console.Write("Result = ");
                Console.WriteLine(result);
            }
        }
  }
}