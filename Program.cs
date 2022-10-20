//Griffin Parker
//Mini Challenge 2 Remastered - Add 2 Numbers
//October 18, 2022
//This program takes two user inputs and adds them together. It makes sure that the numbers are actually numbers then outputs the sum to the user. 
//Peer Reviewed by: 

string first;
string second;
int firstNumber = 0;
int secondNumber = 0;
int loop = 0;
string repeat = "";
bool numberChecker = false;
bool numberChunker = false;

while (loop == 0)
{
while (numberChecker != true || numberChunker != true)
{
Console.Clear();
Console.WriteLine("Give me two numbers!");
if (numberChecker == true || numberChunker == true)
{
Console.WriteLine("This time make sure they're ACTUALLY numbers!");
}
first = Console.ReadLine();
numberChecker = Int32.TryParse(first, out firstNumber);
second = Console.ReadLine();
numberChunker = Int32.TryParse(second, out secondNumber);
}

Console.WriteLine($"{firstNumber} and {secondNumber} added together equals " + (firstNumber+secondNumber));
Console.WriteLine();
while (repeat != "yes")
{
Console.WriteLine("Would you like to me to play again? Type \"yes\" to play again or \"no\" to end the program");
repeat = Console.ReadLine();
repeat = repeat.ToLower();
if (repeat == "yes")
{
numberChecker = false;
numberChunker = false;
firstNumber = 0;
secondNumber = 0;
}
if (repeat == "no")
{
    loop++;
    repeat = "yes";
}
}
if (loop == 0)
{
repeat = "";
}
}
