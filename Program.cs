// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
int getCountNumbers(int Length)
{
    int i = 0;
    int Count = 0;
    while (i < Length)
    {
        Console.WriteLine("Введите число");
        int UserNumber = int.Parse(Console.ReadLine()!);
        if(UserNumber>0)
        {
            Count = Count + 1;
        }
        i++;
    }   
    return Count; 
}

int numberM = getUserData("Введите число M");
int CountNumbers = getCountNumbers(numberM);
Console.WriteLine($"Количество чисел больше нуля равно {CountNumbers}");

