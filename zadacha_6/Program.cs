// int a = 4;
// int b = -3;
// int c = 7;                             
//Console.WriteLine("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine()); 

if (a % 2 == 0)
{
    Console.WriteLine("a -> да, четное число");      
}
else
{
    Console.WriteLine("a -> нет, не четное число");
}
if (b % 2 == 0)
{
    Console.WriteLine("b -> да, четное число");     
}
else
{
    Console.WriteLine("b -> нет, не четное число");
}
if (c % 2 == 0) 
{
    Console.WriteLine("c -> да, четное число");    
}
else
{
    Console.WriteLine("c -> нет, не четное число");
}
