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


        int.TryParse(userInput, out numberprocess);

        if (numberprocess % 2 == 0) {
            Console.WriteLine($"{userInput} is Even");
        }
        else
        {
            Console.WriteLine($"{userInput} is Odd");
        }
		
		
	}
}