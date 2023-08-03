// My class Example003_Sun
internal class Program
{
    public static void Main(string[] args)
    {
        int numberA = new Random().Next(1, 10); // Numder Random 0 do 9 
        int numberB = new Random().Next(1, 10); // Numder Random 0 do 9 
        // result
        int result = numberA + numberB;
        Console.WriteLine(result);

    }
}