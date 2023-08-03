internal class Program
{
    public static void Main(string[] args)
    {
        // sorting numbers in order
        //             0   1   2   3   4   5   6   7   8   9  10   11  12
        int[] array = {1, 12, 31, 4, 15, 16, 17, 18, 19, 10, 111, 121, 18};

        int n = array.Length;
        int find = 18;
        int index = 0;

        while(index < n)
        {
            if (array[index] == find) 
            {
                Console.WriteLine(index);
                break;
            }  
            // index = index + 1;
            index++;
        }

    }
}