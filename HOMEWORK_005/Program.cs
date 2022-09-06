// Написать программу вычисления функции Аккермана
int FunctionAck(int m, int n)
{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return FunctionAck(m - 1, 1);
  else if(m > 0 && n > 0) return FunctionAck(m - 1, FunctionAck(m, n - 1));
  else return n+1;
}
Console.WriteLine("Введите 1-й параметр функции Аккермана(неотрицательное целое число) m : ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите 2-й параметр функции Аккермана(неотрицательное целое число) n : ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"При заданных параметрах функция Аккермана A(m,n) = {FunctionAck(m,n)}. ");




