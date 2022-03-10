// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Наталья Ракитина. Урок 2");
Console.WriteLine("Написать метод, возвращающий минимальное из трёх чисел.");
Console.WriteLine("=========================================================");
Console.WriteLine("Введите первое число a =");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число b =");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  третье число c =");
int c = int.Parse(Console.ReadLine());
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
Console.WriteLine($"min={min} ");
Console.ReadLine();