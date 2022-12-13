Console.WriteLine("Введите натуральное число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int SumAllNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    else if (num1 < num2) return num2 + SumAllNumbers(num1, num2 - 1);
    else return num2 + SumAllNumbers(num1, num2 + 1);

}
int sumAllNumbers = SumAllNumbers(num1, num2);
Console.WriteLine($"Сумма натуральных чисел от M до N -> {sumAllNumbers}");
