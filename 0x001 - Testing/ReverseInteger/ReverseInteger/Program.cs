using ReverseInteger;

IntInReverseOrder intInReverseOrder = new IntInReverseOrder();

try
{
    do {
        Console.WriteLine("Input a number you want  to be reversed or 'q' to quit");
        string input = Console.ReadLine();
        if (input == "q") {
            break;
        }
       
         int numberReverse = intInReverseOrder.reverseNumber(input);
         Console.WriteLine(numberReverse);
           

    } while (true);    
    
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}

