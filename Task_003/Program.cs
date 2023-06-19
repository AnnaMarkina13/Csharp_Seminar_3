// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int ReadInt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string CubesStr(int number)
{
    int[] cubesOfNumbers = new int[number];
    for (int i = 0; i < cubesOfNumbers.Length; i++)
        cubesOfNumbers[i] = (int)Math.Pow((i + 1), 3);
    string result = string.Join(", ", cubesOfNumbers);
    return result;
}

var number = ReadInt("Введите число: ");
System.Console.WriteLine(CubesStr(number));
