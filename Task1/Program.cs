/* Задайте значения M и N. Напишите программу, 
которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void EvenNumbers(int min, int max)
{
    if (min > max)
    {
        return;
    }
    EvenNumbers(min, max-1); 
    if (max % 2 == 0) System.Console.WriteLine(max);
}

int min = Prompt("Введите min число > ");
int max = Prompt("Введите max число > ");
if (min <= 0) min = 1;
if (max < 0) System.Console.WriteLine("Невозможно выполнить вычисление");
EvenNumbers(min, max);