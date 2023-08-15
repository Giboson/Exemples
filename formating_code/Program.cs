// For all sources


    // Продемонстрировать применение идентификатора со знаком @.
    using System;
    class IdTest 
    {
    static void Main() 
    {
    int @if; // применение ключевого слова if
    // в качестве идентификатора
    for(@if = 0; @if < 10; @if++)
    Console.WriteLine("@if равно " + @if);
    }
    }