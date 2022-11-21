Console.Clear();
Console.WriteLine("Введите трехзначное число "); 
int numberA = Convert.ToInt32(Console.ReadLine());
int LastNumber = numberA % 10;
if (99 < numberA)
{
    if (numberA < 1000) Console.WriteLine ($"Последняя цифра числа {numberA} - {LastNumber}");
    else Console.WriteLine ("Неверное число");
}
else Console.WriteLine ("Неверное число");