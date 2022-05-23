// Задание 1
// Создайте консольный мини-калькулятор, который будет подсчитывать сумму двух чисел.
// Определите интерфейс для функции сложения числа и реализуйте его.
// Дополнительно: добавьте конструкцию Try/Catch/Finally для проверки корректности введённого значения.

// Задание 2
// Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя
// материал из скринкаста юнита 10.1.
// Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.
using _10._5._1;

Logger logger = new Logger();
Calculator calc = new Calculator(logger);
while (true)
{
    try
    {
        Console.Write("Введите 1-ое слагаемое: ");
        var a = Console.ReadLine();
        Console.Write("Введите 2-ое слагаемое: ");
        var b = Console.ReadLine();
        calc.Addition(Convert.ToInt32(a), Convert.ToInt32(b));
    }
    catch (Exception ex)
    {
        logger.Error(ex.Message);
    }
}

public interface IAddition
{
    void Addition(int a, int b);
}
public interface ILogger
{
    void Event (string message);
    void Error (string message);
}
public class Logger : ILogger
{
    public void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public void Event(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Произошла ошибка: {0}",message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}