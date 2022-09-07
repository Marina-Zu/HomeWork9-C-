/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int SumNaturalNumbers(int min, int max)
{
    if (min > max)
    {
        return 0;
    }
    return SumNaturalNumbers(min, max-1) + max;;
}

int min = Prompt("Введите min число > ");
int max = Prompt("Введите max число > ");
if (min <= 0) min = 0;
if (max < 0) System.Console.WriteLine("Невозможно выполнить вычисление");
System.Console.WriteLine(SumNaturalNumbers(min, max));
