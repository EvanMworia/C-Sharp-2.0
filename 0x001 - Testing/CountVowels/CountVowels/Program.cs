
using CountVowels;

VowelCount str = new();
Console.WriteLine("\t\t++++++LETS PLAY A GAME++++++");
Console.WriteLine("\t\tI Bet you cant say something without using vowels?");
Console.WriteLine("\t\tDon't Believe Me? TRY? ");
string input  = Console.ReadLine();

int vowelsUsed = str.countVowels(input);

if (vowelsUsed > 0)
{
    Console.WriteLine($"You used {vowelsUsed} vowels");
}
else
{
    Console.WriteLine($"Well i'd be damned you used {vowelsUsed} vowels");
}