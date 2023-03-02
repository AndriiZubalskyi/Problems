using Problems;

internal class Program
{
    private static void Main(string[] args)
    {
        //Helpers.PrintList(Functions.FizzBuzz(15));

        Console.WriteLine(Functions.NumberOfSteps(14));

        Console.WriteLine(Functions.CanConstruct("aa", "aab"));

        //if (Functions.CanConstruct("aa", "ab")) Console.WriteLine("First");
        //if (Functions.CanConstruct("a", "ab")) Console.WriteLine("Second");
    }
}