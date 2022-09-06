// Найти сумму цифр числа

int AmountDigits(int numb)
{
    if(numb > 0) return numb%10 + AmountDigits(numb/10);
    if(numb < 0) return -numb%10 + AmountDigits(-numb/10);
    else return 0;
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма цифр числа {number} составляет: {AmountDigits(number)}.");