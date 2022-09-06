// Написать программу возведения числа А в целую степень B
int NumberInStep(int numb, int step)
{
  if(step > 0) return numb * NumberInStep(numb, step-1);
  else return 1; 
}
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Число {a} в степени {b} = {NumberInStep(a,b)}. ");