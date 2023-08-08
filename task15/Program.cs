// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

bool WeekendNumber(int dayNum, int dayNum6, int dayNum7)
{
    return dayNum % dayNum6 == 0 || dayNum % dayNum7 == 0;
}
bool result = WeekendNumber(dayNumber, 6, 7);

Console.WriteLine(result ? "Выходной" : "Не выходной");