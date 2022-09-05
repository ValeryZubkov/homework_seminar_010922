// Показать натуральные числа от M до N, N и M заданы
void NumbForward(int m, int n)
{
    if(m <= n)
    {
    Console.Write($"{m} ");
    NumbForward(m+1, n);
    }
}
void NumbBack(int m, int n)
{
    if(m >= n)
    {
    Console.Write($"{m} ");
    NumbBack(m-1, n);
    }
}
Console.WriteLine("Введите число M: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");
if(number1 < number2) NumbForward(number1, number2);
if(number1 > number2) NumbBack(number1, number2);
if(number1 == number2) Console.WriteLine("К сожалению, Вы ввели одинаковые числа. Пожалуста, повторите попытку.");
Console.WriteLine();