// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем
void NumbersRow(int numbers, int numb1, int numb2)
{
    if(numbers >0)
    {
         Console.Write($"{numb1} ");
         NumbersRow(numbers-1, numb2, numb1 + numb2);
    }
}
Console.WriteLine("Введите 1-й элемент последовательности: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите 2-й элемент последовательности: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество первых элементов последовательности: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Последовательность из заданных Вами {n} элементов: ");
NumbersRow(n, number1, number2);
Console.WriteLine();
