// 7. Программа которая принмает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите порядковый номер дня недели");
int i = int.Parse(Console.ReadLine()!);
if ((i > 5) && (i < 8))
{
    Console.WriteLine(i + " Это выходной день");
}
else if ((i < 6) && (i > 0))
{
    Console.WriteLine(i + " Это будний день");
}
else Console.WriteLine("Введено некорректное число");