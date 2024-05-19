using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
//1 номер
namespace Questionnaire
{
    class Program
    {
        static void Main(string args)
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш рост (в см):");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш вес (в кг):");
            int weight = Convert.ToInt32(Console.ReadLine());

            string infoConcatenation = "Имя: " + name + ", Фамилия: " + surname + ", Возраст: " + age + ", Рост: " + height + "см, Вес: " + weight + "кг";
            Console.WriteLine(infoConcatenation);

            string infoFormatting = String.Format("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}см, Вес: {4}кг", name, surname, age, height, weight);
            Console.WriteLine(infoFormatting);

            string infoInterpolation = $"Имя: {name}, Фамилия: {surname}, Возраст: {age}, Рост: {height}см, Вес: {weight}кг";
            Console.WriteLine(infoInterpolation);
        }
    }
}
//2 номер

class Index
{
    static void Main()
    {
        Console.Write("Введите ваш вес в кг: ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Введите ваш рост в метрах: ");
        double height = double.Parse(Console.ReadLine());
        double index = weight / (height * height);
        Console.WriteLine($"Ваш индекс массы тела (ИМТ) составляет: {index}");
    }
}
//3 номер
class Coordinate
{
    static void Main()
    {
        double x1, y1, x2, y2;
        Console.WriteLine("Введите координаты первой точки (x1 y1):");
        string[] input1 = Console.ReadLine().Split(' ');
        x1 = Convert.ToDouble(input1[0]);
        y1 = Convert.ToDouble(input1[1]);

        Console.WriteLine("Введите координаты второй точки (x2 y2):");
        string[] input2 = Console.ReadLine().Split(' ');
        x2 = Convert.ToDouble(input2[0]);
        y2 = Convert.ToDouble(input2[1]);

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"Расстояние между точками: {distance:.2f}");
    }
}
//4 номер

class Var
{
    static void Main()
    {
        int a, b;
        Console.WriteLine("Введите значение переменной a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение переменной b:");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Исходные значения: a = {a}, b = {b}");

        int temp = a; // Сохраняем значение переменной a
        a = b;
        b = temp;

        Console.WriteLine($"После обмена: a = {a}, b = {b}");
    }
}
//5 номер


class Info
{
    static void Main()
    {
        string firstName = "Иван";
        string lastName = "Иванов";
        string city = "Москва";

        Console.SetCursorPosition((Console.WindowWidth - firstName.Length) / 2, Console.CursorTop);
        Console.WriteLine($"Имя: {firstName}");
        Console.SetCursorPosition((Console.WindowWidth - lastName.Length) / 2, Console.CursorTop);
        Console.WriteLine($"Фамилия: {lastName}");
        Console.SetCursorPosition((Console.WindowWidth - city.Length) / 2, Console.CursorTop);
        Console.WriteLine($"Город: {city}");
    }
}