// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Сколько цифр будет в массиве");
int num = Convert.ToInt32(Console.ReadLine());
int total = 0;
for (int i = 0; i < num; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
    {
        total += 1;
    }
}
Console.WriteLine(total);
