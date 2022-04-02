// See https://aka.ms/new-console-template for more information
// hello world
Console.WriteLine("Hello, World!");
string aFriend = "Bill";
Console.WriteLine(aFriend);
aFriend = "Maira";
Console.WriteLine(aFriend);
Console.WriteLine("Hello" + aFriend);
Console.WriteLine($"Hello {aFriend}");
// hello world 2
string firstFriend = "Maria";
string secondFriend = "sage";
Console.WriteLine($"My friend are {firstFriend} and {secondFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
// hello world 3
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());
//  hello world 3
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));
Console.WriteLine(songLyrics.EndsWith("hello"));
