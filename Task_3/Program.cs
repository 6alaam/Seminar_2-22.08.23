Console.Write("Введите номер дня недели: ");
int number1;
while (!int.TryParse(System.Console.ReadLine(), out number1)) { System.Console.WriteLine("Это не число"); }
if (number1 > 7)
{
    System.Console.WriteLine("в недели 7 дней");
}
if ((number1 > 5) && (number1 < 8))
{
    System.Console.WriteLine("Выходной");
}
else
    System.Console.WriteLine("будний день");
