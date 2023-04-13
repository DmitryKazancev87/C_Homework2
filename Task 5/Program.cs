// 5. Программа, которая на входе принимает трехзначное число
// и на выходе выдает вторую цифру этого числа.  
Console.WriteLine(" Введите трехзначное число");
int i = int.Parse(Console.ReadLine()!);
if (i > 99 && i < 1000)
{
    int second = (i / 10)%10;
    Console.WriteLine(second + " - вторая цифра");
}
else
{
    Console.WriteLine(" Введено некорректное значение");
}