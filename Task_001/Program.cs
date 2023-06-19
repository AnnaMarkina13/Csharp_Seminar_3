// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Prompt (string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return number;
}

bool IsValid (string number) 
{
    foreach (var symbol in number)
    {
        if (!char.IsDigit(symbol))
        {
            System.Console.WriteLine("Ошибка! Вы ввели не число!");
            return false;
        }
    }
    if (number.Length != 5) 
    {
        System.Console.WriteLine("Ошибка! Необходимо ввести пятизначное число!");
        return false;
    }
    return true;
}

void IsPalindrom (string number)
{
    if (number[0] == number[4] && number[1] == number[3]) 
    {
        Console.WriteLine("Число является палиндромом");
        return;
    }
    Console.WriteLine("Число не является палиндромом");
}

var number = Prompt("Введите пятизначное число: ");
if (IsValid(number)) IsPalindrom(number);
