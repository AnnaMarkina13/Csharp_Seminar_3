// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int[] StringToArray(string message)
{
    System.Console.WriteLine(message);
    int[] coordinates = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return coordinates;
}

double Distance(int[] coordinates1, int[] coordinates2)
{
    double distance = Math.Round(
        Math.Sqrt(
            (
                Math.Pow((coordinates2[0] - coordinates1[0]), 2)
                + Math.Pow((coordinates2[1] - coordinates1[1]), 2)
                + Math.Pow((coordinates2[2] - coordinates1[2]), 2)
            )
        ),
        3
    );
    return distance;
}

var firstCoordinates = StringToArray("Введите координаты первой точки через пробел: ");
var secondCoordinates = StringToArray("Введите координаты второй точки через пробел: ");
System.Console.WriteLine(Distance(secondCoordinates, firstCoordinates));
