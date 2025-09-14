using Core;

Console.Write("Enter your name: ");
var name = Console.ReadLine();

Console.WriteLine($"Hello {name ?? "friend"}!");
Console.WriteLine($"3 + 4 = {MathUtils.Add(3,4)}");
Console.WriteLine($"Is 25 adult? {MathUtils.IsAdult(25)}");
