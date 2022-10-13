// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

void RemoveAndPrintMiddLeDigit(int Value)
{
    if (Value >= 100 && Value < 1000)
    {
        int result = Value / 10 % 10;
        System.Console.WriteLine(result);
    }
    else
    {
        System.Console.WriteLine("Число не трезначное");
    }
}

int number = Prompt("Введите трехзначное число");
RemoveAndPrintMiddLeDigit(number);

Console.WriteLine("---------");

// Напишите программу, которая выводит случайное трёхзначное число и
// удаляет вторую цифру этого числа.

int Remove2Digit(int Value)
{
    int three = Value % 10;
    int two = Value / 10 % 10;
    int one = Value / 100 % 10;
    int result = one * 10 + three;
    return result;
}
int Value = new Random().Next(100, 1000);
System.Console.WriteLine(Value);


System.Console.WriteLine(Remove2Digit(Value));

Console.WriteLine("---------");

// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

int Get3Digit(int Val)
{
    while (Val > 1000)
    {
        Val = Val / 10;
    }
    int result = Val % 10;
    System.Console.WriteLine(result);
    return result;
}
int Val = Prompt("Введите число");
if (Val > 99)
{
    int result = Get3Digit(Val);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}

Console.WriteLine("---------");

// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int dayOfWeek;
dayOfWeek = Prompt($"Введите номер дня: ");
if (dayOfWeek < 1 || dayOfWeek >7)
{
    System.Console.WriteLine("Это не день недели");
    return;
}
if (dayOfWeek == 6 || dayOfWeek ==7)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}