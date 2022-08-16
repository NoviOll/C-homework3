// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
if (stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
{
    Console.WriteLine("Это палиндром");
}
else 
{
    Console.WriteLine("Это не палиндром");
}


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
class Program
{
    static void Main(string[] args)
    {
        int n = 3;
        int[] A = new int[n];
        int i = 0;
        Console.WriteLine("Введите координаты первой точки через enter");
        while (i < n)
        {
            A[i] = Convert.ToInt32(Console.ReadLine()); i++;
        }
        int[] B = new int[n];
        int j = 0;
        Console.WriteLine("Введите координаты второй точки через enter");
        while (j < n)
        {
            B[j] = Convert.ToInt32(Console.ReadLine()); j++;
        }
        Console.WriteLine(Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2) + Math.Pow(A[2] - B[2], 2)));
    }
}


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
class Program
{
    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (i < (N+1))
        {
            Console.WriteLine(Math.Pow(i,3)); 
            i++;
        }
    }
}