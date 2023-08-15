// For all sources


// Использовать тип decimal для расчета скидки.
    using System;
    class UseDecimal 
    {
    static void Main() 
    {
    decimal price;
    decimal discount;
    decimal discounted_price;
    // Рассчитать цену со скидкой.
    price = 19.95m;
    discount = 0.15m; // норма скидки составляет 15%
    discounted_price = price - ( price * discount);
    Console.WriteLine("Цена со скидкой: RUB " + discounted_price);
    }
    }