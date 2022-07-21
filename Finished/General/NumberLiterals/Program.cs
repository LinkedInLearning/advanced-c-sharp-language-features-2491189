// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini

// Starting in C# 7, you can use _ as a number separator
int d = 123_456;
float f = 1_234.5f;
var x = 0xAB_CD_EF;
var b = 0b1101_1110_1001_0010;

Console.WriteLine($"{d}");
Console.WriteLine($"{f}");
Console.WriteLine($"{b:X}");
Console.WriteLine($"{x:X}");
