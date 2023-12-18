using CapitalizeFirstWords;


TittleCase tc= new();
do
{
	Console.WriteLine("Give me a text in all lowercase, i will format it for you to tittle case :-)");
	string test = Console.ReadLine();

	try
	{

		if (!string.IsNullOrEmpty(test))
		{
			if (int.TryParse(test, out int fail))
			{
                Console.WriteLine("Input has to be a string my G");
                Console.WriteLine(" ");
                continue;
            }
			
			tc.tittleCase(test);
            Console.WriteLine(" "); Console.WriteLine(" ");
        }
		else
		{
			Console.WriteLine("You're supposed to give me an input");
		}
	}
	catch (Exception ex)
	{

		Console.WriteLine(ex.Message); ;
	}
} while (true) ;

