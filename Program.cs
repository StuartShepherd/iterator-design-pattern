using IteratorDesignPattern;

Console.WriteLine("Iterator Design Pattern");
Console.WriteLine("Iterator is a behavioral design pattern that allows sequential traversal through a complex data structure without exposing its internal details.");
Console.WriteLine();

var collection = new WordsCollection();
collection.AddItem("First");
collection.AddItem("Second");
collection.AddItem("Third");

Console.WriteLine("Straight traversal:");

foreach (var element in collection)
{
    Console.WriteLine(element);
}

Console.WriteLine("");
Console.WriteLine("Reverse traversal:");

collection.ReverseDirection();

foreach (var element in collection)
{
    Console.WriteLine(element);
}

Console.WriteLine();