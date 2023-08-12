using System;

namespace simplecsharpadd
{
    class Programs
    {
        static int Main(string[] args)
        {
            Console.WriteLine("**************************");
            Console.WriteLine("***** My First C# App*****");
            Console.WriteLine("**************************");
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("args: {0}", args[i]);
            }
             //  Wait for button  <Enter> kay to be Pressed
             Console.ReadLine();
            return 0;
        }

    }

}
