// Найти сумму элементов от M до N, N и M заданы
int NumbAmount(int m, int n)
{
    if(m == n) return n;     
    if(m < n) return m + NumbAmount(m+1, n);
    else return m + NumbAmount(m-1, n);
}
Console.WriteLine("Введите число M: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Сумма элементов от {number1} до {number2} составляет: {NumbAmount(number1, number2)}.");
Console.WriteLine();