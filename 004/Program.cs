// Ввод числа N, и вывод всех чисел от -N....N
Console.Clear();
Console.WriteLine("Введите число "); 
int numberA = Convert.ToInt32(Console.ReadLine());
int count = -numberA;
if (numberA < 0)
{
    count = numberA;
    numberA = -numberA;
} 
while (count < numberA + 1)
{
    Console.Write($"{count}, ");
    count++;
}