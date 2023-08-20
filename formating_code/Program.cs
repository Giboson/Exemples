// For all sources


// Неявные преобразования типов могут повлиять на
// решение перегружать метод.
using System;
class Overload2
{
    public void MyMeth(int x)
    {
        Console.WriteLine("В методе MyMeth(int): " + x);
    }
    public void MyMeth(double x)
    {
        Console.WriteLine("В методе MyMeth(double): " + x);
    }
}
class TypeConv
{
    static void Main()
    {
        Overload2 ob = new Overload2();
        int i = 10;
        double d = 10.1;
        byte b = 99;
        short s = 10;
        float f = 11.5F;
        ob.MyMeth(i); // вызватьм етод ob.MyMeth(int)
        ob.MyMeth(d); // вызватьм етод ob.MyMeth(double)
        ob.MyMeth(b); // вызватьм етод ob.MyMeth(int)  -- с  преобразованием т ипа
        ob.MyMeth(s); // вызватьм етод ob.MyMeth(int)  --  с преобразованием  типа
        ob.MyMeth(f); // вызвать метод ob.MyMeth(double) -- с преобразованием типа
    }
}
