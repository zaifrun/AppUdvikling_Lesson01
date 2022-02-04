using System;
using System.IO.Pipes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            //her starter kode
            try
            {
                //Opgave 1.02 og 1.03
                Console.WriteLine("Hello World!");
                Assert.AreEqual(7, 5 + 2);
                Console.WriteLine(5 + 2);
                Assert.AreEqual(2, 5 / 2);
                Console.WriteLine(5 / 2);
                Assert.AreEqual(23, -1 + 4 * 6);
                Console.WriteLine(-1 + 4 * 6);
                Assert.AreEqual(5, (35 + 5) % 7);
                Console.WriteLine((35 + 5) % 7);
                Assert.AreEqual(12, 14 + -4 * 6 / 11);
                Console.WriteLine(14 + -4 * 6 / 11);
                Assert.AreEqual(3, 2 + 15 / 6 * 1 - 7 % 2);
                Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

                //Opgave 1.04
                int number1, number2;
                Console.WriteLine("Input the first number: ");
                number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Input the second number: ");
                number2 = int.Parse(Console.ReadLine());
                Console.WriteLine("After swapping: ");
                Console.WriteLine(number2);
                Console.WriteLine(number1);

                //Opgave 1.05
                int nummer1, nummer2, answer;
                Console.WriteLine("Skriv det første tal vi skal lave matematik med: ");
                nummer1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Skriv det andet tal vi skal lave matematik med: ");
                nummer2 = int.Parse(Console.ReadLine());
                answer = nummer1 + nummer2;
                Console.WriteLine(nummer1 + " + " + nummer2 + " = " + answer);
                answer = nummer1 - nummer2;
                Console.WriteLine(nummer1 + " - " + nummer2 + " = " + answer);
                answer = nummer1 * nummer2;
                Console.WriteLine(nummer1 + " * " + nummer2 + " = " + answer);
                answer = nummer1 / nummer2;
                Console.WriteLine(nummer1 + " / " + nummer2 + " = " + answer);
                answer = nummer1 % nummer2;
                Console.WriteLine(nummer1 + " % " + nummer2 + " = " + answer);

                //Opgave 1.06
                double celsius, fahrenheit, kelvin;
                Console.WriteLine("Skriv tallet som du vil have omregnet til Fahrenheit og Kelvin: ");
                celsius = double.Parse(Console.ReadLine());
                fahrenheit = celsius * 1.8 + 32;
                kelvin = celsius + 273;
                Console.WriteLine("Temperaturen i Fahrenheit er " + fahrenheit);
                Console.WriteLine("Temperaturen i Kelvin er " + kelvin);



                object dayofweek = DateTime.Now.DayOfWeek;
                string day = "";
               // Console.WriteLine($"day of week {dayofweek}");
                switch((int)dayofweek)
                {
                    case 0:
                        day = "Sunday";
                        break;
                    case 1:
                        day = "Monday";
                        break;
                    case 2:
                        day = "Tuesday";
                        break;
                    case 3:
                        day = "Wednesday";
                        break;
                    case 4:
                        day = "Thursday";
                        break;
                    case 5:
                        day = "Friday";
                        break;
                    case 6:
                        day = "Saturday";
                        break;
                    default:
                        Console.WriteLine("Day not recognized");
                        break;
                }
                Console.WriteLine($"Today is:  {day}");
            
            
            }
            catch (AssertFailedException a)
            {
                Console.WriteLine("One of the expressions does not contain the value you expected: " + a.Message);
            }
        }
    }
}
