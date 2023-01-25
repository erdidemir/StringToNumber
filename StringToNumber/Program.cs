// See https://aka.ms/new-console-template for more information
using StringToNumber;
using System.Threading;

Console.WriteLine("input:");

// Create a string variable and get user input from the keyboard and store it in the variable
string input = "He paid twenty millions for three such cars.";

TextToNumberService textToNumberService = new TextToNumberService();


var output = textToNumberService.ConvertTextToNumber(input);

Console.WriteLine(output);

Console.ReadLine();



//input: He paid twenty millions for three such cars.
//output: He paid 20000000 for 3 such cars.