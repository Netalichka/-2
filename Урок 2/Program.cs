// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Наталья Ракитина. Урок 2");
Console.WriteLine("Написать метод, возвращающий минимальное из трёх чисел.");
Console.WriteLine("=========================================================");
int a = int.Parse(Console.readline());
int b = int.Parse(Console.readline());
int c = int.Parse(Console.readline());
int min = 0;
if (a < b & a < c)
{
    min = a;

}
if (b < c)
{
    min = b;


}
else
{
    min = c;

}
console.writeline($"min={min} ");