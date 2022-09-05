// Показать натуральные числа от N до 1, N задано
void Numb(int n)
{
    if(n >= 1)
    {
    Console.Write($"{n} ");
    Numb(n-1);
    }
}
Console.WriteLine("Введите число N для отображения обратной последовательности: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Numb(number);
Console.WriteLine();