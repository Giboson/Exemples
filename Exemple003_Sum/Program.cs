// My class Example003_Sum
internal class Program
{
    public static void Main(string[] args)
    {
        int numberA = new Random().Next(1, 10); // Numder Random 0 do 9 
        Console.WriteLine(numberA); 
        int numberB = new Random().Next(1, 10); // Numder Random 0 do 9
        Console.WriteLine(numberB); 
        // result
        int result = numberA + numberB;
        Console.WriteLine(result);

    }
}