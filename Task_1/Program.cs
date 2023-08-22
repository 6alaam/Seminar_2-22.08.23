Console.Write("Введите число трехзначное число: ");
int number1;
while (!int.TryParse(System.Console.ReadLine(), out number1)) { System.Console.WriteLine("Это не число"); }

if ((number1 < 100) || (number1 > 1000))
{
    System.Console.WriteLine("не трехзначное число");

}
else
{
    int z;
    int x;
    z = number1 % 100;
    x = z / 10;


    System.Console.WriteLine(x);

}