// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine ("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());

int SecondNumber (int number)
{
int result = ((a / 10) % 10);
    return result;
}


int secondNumber = SecondNumber(a);
Console.WriteLine(secondNumber);
