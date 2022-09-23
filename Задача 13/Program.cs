// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine ("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
string aText = Convert.ToString(a); 

{

if (aText.Length > 2) //Если размер строки больше 2ух ячеек
{
//Сокращая код ,выводим 2 элемент строки числа
  Console.WriteLine("третья цифра числа: " +aText[2]);
}
else
{
    Console.WriteLine("Число не имеет третьей цифры");
}
}
