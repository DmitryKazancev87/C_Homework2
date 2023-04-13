// 6. Программа, которая на входе принимает трехзначное число
// и на выходе выдает третью цифру этого числа или сообщает, что третьей цифры нет.  
Console.WriteLine(" Введите трехзначное число");
int i = int.Parse(Console.ReadLine()!);
if (i > 99 && i < 1000)
{
    int second = i % 10;
    Console.WriteLine(second + " - третья цифра");
}
else
{
    Console.WriteLine(" Третьей цифры нет!");
}