using PalindromeChecker;

ChecksPalindromes cp = new ChecksPalindromes();
Console.WriteLine("Do you fancy palindromes? Let me see how many you know?");
string input = Console.ReadLine();

string test = cp.isThisAPalindrome(input);
if (test.Equals(input.ToLower()))
{
    Console.WriteLine($"Lol, {input} is a palindrome :)");
}
else
{
    Console.WriteLine($"Naaah, {input} is not a palindrome bruv :(");
}

