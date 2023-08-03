internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("the username, ");
        string username = Console.ReadLine();

        if (username == "Sendi")
        {
            Console.WriteLine("You Sendi, ");
        } 
        else 
        {
            Console.Write("Hello, ");
            Console.WriteLine(username);
        }

    }
}