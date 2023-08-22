Console.Write("Введите число трехзначное число: ");
int number1;
while (!int.TryParse(System.Console.ReadLine(), out number1)) { System.Console.WriteLine("Это не число"); }

while (number1 > 1000){
    number1 = number1/10;
}
if (number1 < 100){
    System.Console.WriteLine("нет третьего числа");
} else{
    int x = number1%10;
    System.Console.WriteLine(x);
}
