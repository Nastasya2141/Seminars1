// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine ("Введите число от 1 до 7:");
int WeekDay = Convert.ToInt32(Console.ReadLine());
{
    if (WeekDay<8)
    {
        if (WeekDay<6)
        {
            Console.Write("Рабочий день недели");
        }
        else
        {
            Console.Write("Выходной");
        }
    }
    else
    {
        Console.Write("Введеное число выходит за границы диапазона, введите число от 1 до 7");
    }
    
}