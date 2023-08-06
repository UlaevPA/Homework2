// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Неверное число");
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }



}

int thirdDigit = number % 10;
Console.WriteLine($"{thirdDigit}");

// if (number / 10 <= 999)

//     {
//         int thirdDigit = number % 10;
//         Console.WriteLine($"{thirdDigit}");
//     }
//     else
//     {
//         number = number / 10;

//     }