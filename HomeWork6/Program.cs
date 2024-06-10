using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{

    public static void Exponentiation(int number1, int number2)
    {
        decimal exponentiation = (decimal)(Math.Pow(number1, number2));
        Console.WriteLine(exponentiation);
    }

    public static void Sum(int number1, int number2)
    {
        int i = 0;
     for (number2++; number1!=number2; ) 
        {
            i += number2;
            number2++;
            
        }
        Console.WriteLine(i);
    }
    public static void PerfectNumber(int start, int end)
    {
        for (int number = start; number <= end; number++)
        {
            int sum = 1;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number && number != 1)
            {
                Console.WriteLine($"{number} is perfect number");
            }
        }
    }

    public static void Cards(int card)
    {
        string [] numbers = {"2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH", "AH",
            "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD", "AD",
            "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC", "AC",
            "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS", "AS"};
        if ( (card > 52) || (card < 1)) 
        {
            Console.WriteLine($"We don't dave card with number {card}");
        }
        else
        {
            
            {
                card--;
                Console.WriteLine($"Your card is {numbers[card]}");


            }
        }
    }
    public static void LuckyNumber(int number)
    {
        
        if (( number < 100000) || (number> 999999))
        {
            throw new Exception("This is not six digit number");
        }
        int number1 = number / 100000;
        int number2 = number / 10000 % 10;
        int number3 = number / 1000 % 10;
        int number4 = number / 100 % 10;
        int number5 = number / 10 % 10;
        int number6 = number  % 10;

        if ((number1+number2+number3) == (number4 + number5 + number6))
        {
            Console.WriteLine("This number is  lucky!");
            
        } 
        else
        {
            Console.WriteLine("This is not your day");
        }

    }

    public static void Main()
    {
        try
        {
            Console.WriteLine("Choose task by entering number from 1 to 5");
            int task = Convert.ToInt32(Console.ReadLine());
            if (task == 1)
            {
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                Exponentiation(number1, number2);
            }
            else if (task == 2)
            {
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());
                Sum(number1, number2);
            }
            else if (task == 3)
            {
                int start = Convert.ToInt32(Console.ReadLine());
                int end = Convert.ToInt32(Console.ReadLine());
                PerfectNumber(start, end);
            }
            else if (task == 4)
            {
                int card = Convert.ToInt32(Console.ReadLine());
                Cards(card);
            }
            else if (task == 5)
            {
                Console.WriteLine("Enter six digit number");
                int number = Convert.ToInt32(Console.ReadLine());
                LuckyNumber(number);
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("This is wrong type of data");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
    }
}