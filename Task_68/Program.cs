Console.WriteLine("Введите  неотрицательное целое число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное целое число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int FunctionAkkerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return FunctionAkkerman(numM - 1, 1);
    return FunctionAkkerman(numM - 1, FunctionAkkerman(numM, numN - 1));
}
int functionAkkerman = FunctionAkkerman(numM, numN);
Console.WriteLine($"A(m,n) = {functionAkkerman}");