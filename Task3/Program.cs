// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermanFunction(int n, int m)
{
    if (n == 0) return (m +1);
    if (m == 0) return AckermanFunction(n-1, 1);
    if (n > 0 && m > 0)
    {
        return AckermanFunction(n-1, AckermanFunction(n, m-1));
    }
    return 0;
}

int n = Prompt("Введите число n > ");
int m = Prompt("Введите число m > ");
System.Console.WriteLine($"A(n, m) = {AckermanFunction(n, m)}");
