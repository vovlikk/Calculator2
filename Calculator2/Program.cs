using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в калькулятор!");
        Console.WriteLine("Выберите тип калькулятора:");
        Console.WriteLine("1. Основные операции (+, -, *, /, ^, %, факториал)");
        Console.WriteLine("2. Тригонометрические функции (sin, cos)");
        Console.WriteLine("3. Конвертация валют");
        Console.WriteLine("4. Конвертация длины");

        int CalculatorType = int.Parse(Console.ReadLine());
        switch (CalculatorType)
        {
            case 1:
                BasicOperation();
                break;
            case 2:
                TrigonometricCalculator();
                break;
            case 3:
                MoneyConverter();
                break;

            case 4:
                ConvertLanght();
                break;
            

            default:
                Console.WriteLine("Неверный выбор!");
                break;
        }

        static void BasicOperation()
        {
            try
            {
                while (true)
                {
                    Console.Write("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите операцию: (+,-,*,/,f,^,%)");
                    string operation = Console.ReadLine();
                    double num2 = 0;
                    if (operation != "f")
                    {
                        Console.Write("Введите второе число: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    double result = 0;
                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine($"{num1} + {num2} = {result}");
                            break;
                        case "-":
                            result = num1 - num2;
                            Console.WriteLine($"{num1} - {num2} = {result}");
                            break;
                        case "*":
                            result = num1 * num2;
                            Console.WriteLine($"{num1} * {num2} = {result}");
                            break;
                        case "/":
                            if (num2 == 0)
                            {
                                Console.WriteLine("Деление на 0 невозможно");
                            }
                            else
                            {
                                result = num1 / num2;
                                Console.WriteLine($"{num1} / {num2} = {result}");
                            }
                            break;
                        case "^":
                            result = Math.Pow(num1, num2);
                            Console.WriteLine($"{num1} ^ {num2} = {result}");
                            break;
                        case "%":
                            result = num1 % num2;
                            Console.WriteLine($"{num1} % {num2} = {result}");
                            break;
                    }
                    Console.WriteLine("Хотите продолжить? (да/нет)");
                    string str = Console.ReadLine();
                    if (str.ToLower() != "да")
                    {
                        break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неизвестный формат числа");
            }
        }

        static void TrigonometricCalculator()
        {
            try
            {
                while (true)
                {
                    Console.Write("Введите угол в радианах: ");
                    double angle = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите операцию (sin, cos): ");
                    string operation = Console.ReadLine();
                    double result = 0;
                    switch (operation)
                    {
                        case "sin":
                            result = Math.Sin(angle);
                            Console.WriteLine($"Синус({angle}) = {result}");
                            break;
                        case "cos":
                            result = Math.Cos(angle);
                            Console.WriteLine($"Косинус({angle}) = {result}");
                            break;
                        default:
                            Console.WriteLine("Неизвестная операция!");
                            continue;
                    }
                    Console.WriteLine("Хотите продолжить? (да/нет)");
                    string str = Console.ReadLine();
                    if (str.ToLower() != "да")
                    {
                        break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода! Попробуйте снова.");
            }
        }

        static void MoneyConverter()
        {
            try
            {
                while (true)
                {

                    Console.WriteLine("Выберите валюту");
                    Console.WriteLine($"1.UAH -> USD");
                    Console.WriteLine($"2.UAH -> PLN");
                    Console.WriteLine($"3.UAH -> EUR");

                    int choise = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите сумму");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    switch (choise)
                    {
                        case 1:
                            result = amount / 42;
                            Console.WriteLine($"{amount} UAH = {result} Usd");
                            break;
                        case 2:
                            result = amount / 10;
                            Console.WriteLine($"{amount} Uah = {result} Pln");
                            break;


                    }
                    Console.WriteLine("Хотите продолжить? (да/нет)");
                    string str = Console.ReadLine();
                    if (str.ToLower() != "да")
                    {
                        break;
                    }

                }    
            }
            catch(FormatException)
            {
                Console.WriteLine("");
            }

        }
        static void ConvertLanght()
        {
            try
            {
                while(true)
                {
                    Console.WriteLine("Выберите конвертацию");
                    Console.WriteLine("1.Метры -> Километры");
                    Console.WriteLine("2.Метры -> Мили");
                    Console.WriteLine("3.Футы -> Метры");

                    int choise = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите значение: ");
                    double value = double.Parse(Console.ReadLine());

                    double result = 0;
                    switch(choise)
                    {
                        case 1:
                            result = value / 1000;
                            Console.WriteLine($"{value}M = {result} km");
                            break;
                        case 2:
                            result = value * 0.000621371;
                            Console.WriteLine($"{value}M = {result} Mils");
                            break;
                        case 3:
                            result = value * 0.3048;
                            Console.WriteLine($"{value}Fut = {result}M");
                            break;

                    }
                    Console.WriteLine("Хотите продолжить? (Да/Нет)");
                    string str = Console.ReadLine();
                    if (str.ToLower() != "да")
                    {
                        break;
                    }

                }
            }
            catch(FormatException)
            {

            }
        }
    }
}
