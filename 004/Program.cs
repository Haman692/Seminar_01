Console.Clear();
Console.WriteLine("Введите число "); 
int numberA = Convert.ToInt32(Console.ReadLine());
int count = -numberA;
while (count < numberA + 1)
{
    Console.Write($"{count}, ");
    count++;
}