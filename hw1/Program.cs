Console.WriteLine("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
}
else
{
    Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
}

Console.WriteLine("---------");

// Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел. 2, 3, 7 -> 7

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
};

int numberA = Prompt("Введите первое число");
int numberB = Prompt("Ведите второе число");
int numberC = Prompt("Введите третье число");
int numberMax = numberA;
if (numberB > numberMax)
{
    numberMax = numberB;
}
if (numberC > numberMax)
{
    numberMax = numberC;
}
Console.WriteLine("max = " + numberC);

Console.WriteLine("---------");

// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка). 4 -> Четное

int number = Prompt("Введите число");
if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

Console.WriteLine("---------");

// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N. 5 -> 2, 4

int N = Prompt("Введите число");
int k = 2;
while (k <= N)
{
    Console.WriteLine(k);
    k = k + 2;
}