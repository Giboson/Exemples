
  
        void FillArray(int[] collection)
        {   
            int length = collection.Length;
            int index = 0;
            int position = 0;
            while (index < length)
            {
                collection[index] = new Random().Next(1, 10);
                // index = index + 1;
                index++;
            }

        }
        void PrintArray(int[] coll)
        {
            int  count = coll.Length;
            int position = 0;

            while(position < count)
            {
                Console.WriteLine(coll[position]);
                position++;
            }
        }
        int IndexOf(int[] collection, int find);
        
        int count = Collection.Length;
        index = 0;
        index position = 0;
        while(index < count)
        {
            int count = collection.Length;
            if (collection[index] == find)
            {
                position = index;
                break;

            }
            index++;
        } 
        return position;
    //                      { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
       int[] array = new int[10]; 
    
    FillArray(array);
    PrintArray(array);
    Console.WriteLine(); 

    int pos = IndexOf(array, 4);
    Console.WriteLine(pos);

