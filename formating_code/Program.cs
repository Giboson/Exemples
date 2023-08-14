// For all sources

    Console.WriteLine("=> String equality:");
    string si = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("si = {0}", si);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Проверить строки на равенство.
    Console.WriteLine("si == s2: {0}", si == s2);
    Console.WriteLine("si == Hello!: {0}", si == "Hello!");
    Console.WriteLine("si == HELLO!: {0}", si == "HELLO!");
    Console.WriteLine("si == hello!: {0}", si == "hello!");
    Console.WriteLine("si.Equals(s2): {0}", si.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine();
