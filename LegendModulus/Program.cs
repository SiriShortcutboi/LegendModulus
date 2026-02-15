using System;
using System.Globalization;
					
public class Program
{
	static string userInput = "default";
    static int numberprocess = 0;
   
		//might have to declare an int for conversion and do try parse below
	public static void Main()
	{
        Console.WriteLine("\nI am MODULUS, cruncher of numbers, enter your number to see its fate!");
		userInput = Console.ReadLine();

    //int.TryParse is not something you rename every time you use it
        int.TryParse(userInput, out numberprocess);
    //you just put a STRING variable in position 1 and OUT it to an int in position 2

        if (numberprocess % 2 == 0) {
            Console.WriteLine($"{userInput} is Even");
        }
        else
        {
            Console.WriteLine($"{userInput} is Odd");
        }
		
		
	}
}