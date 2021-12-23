// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int min;
if (a < b & a < c)
{
    Console.WriteLine("min= ", a);
}
    if (b<c)
{
    Console.WriteLine("min= ", b);
  
}
    else
{
    Console.WriteLine("min= ", c);
}