Console.Clear();
Console.WriteLine("Напишите перове число"); 
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число"); 
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB == numberA*numberA)
{
    Console.WriteLine($"Число {numberB} являеться квадратом {numberA}"); 
}
else
{
    Console.WriteLine($"Число {numberB} не являеться квадратом {numberA}"); 
}