// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Наталья Ракитина. Урок 2
// Написать метод, возвращающий минимальное из трёх чисел.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int min = 0;
if (a < b & a < c)
{
    min = a;
    
}
    if (b<c)
{
    min = b;
  
  
}
    else
{
    min = c;
    
}
Console.WriteLine($"min={min} ");