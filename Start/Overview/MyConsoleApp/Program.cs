// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string response;

Console.WriteLine("Hi! What's your name?");
response = Console.ReadLine();
Console.WriteLine($"Nice to meet you, {response}");

OperatingSystem thisOS = Environment.OSVersion;
Console.WriteLine(thisOS.Platform);
Console.WriteLine(thisOS.VersionString);
