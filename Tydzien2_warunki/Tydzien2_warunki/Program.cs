using System;
using System.Collections.Generic;
using System.Linq;

namespace Tydzien2_warunki
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctlyTyped;
            //Zadanie 1
            int a = 5;
            int b = 5;

            if (a == b)
                Console.WriteLine($"{a} i {b} są równe");

            //Zadanie 2
            int numberModulo;

            Console.WriteLine("Podaj liczbę do zadania 2");
            correctlyTyped = int.TryParse(Console.ReadLine(), out numberModulo);
            if (correctlyTyped)
            {
                if (numberModulo % 2 == 1)
                    Console.WriteLine($"{numberModulo} jest liczbą nieparzystą");
                else
                    Console.WriteLine($"{numberModulo} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine("Podano w konsoli złą warotść w zadaniu 2");
            }

            //Zadanie 3
            int numberExercise3;

            Console.WriteLine("Podaj liczbę do zadania 3");
            correctlyTyped = int.TryParse(Console.ReadLine(), out numberExercise3);
            if (correctlyTyped)
            {
                if (numberExercise3 >= 0)
                    Console.WriteLine($"{numberExercise3} jest liczbą dodatnią");
                else
                    Console.WriteLine($"{numberExercise3} jest liczbą ujemną");
            }
            else
            {
                Console.WriteLine("Podano w konsoli złą warotść w zadaniu 3");
            }

            //Zadanie 4
            int year;

            Console.WriteLine("Podaj rok do zadania 4");
            correctlyTyped = int.TryParse(Console.ReadLine(), out year);
            if (correctlyTyped)
            {
                if (year % 4 == 0)
                    Console.WriteLine($"{year} jest rokiem przestępnym");
                else
                    Console.WriteLine($"{year} nie jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine("Podano w konsoli złą warotść w zadaniu 4");
            }

            //Zadanie 5
            int age;

            Console.WriteLine("Podaj wiek do zadania 5");
            correctlyTyped = int.TryParse(Console.ReadLine(), out age);
            if (correctlyTyped)
            {
                if (age >= 18)
                    Console.WriteLine("Możesz zostać posłem");
                else
                    Console.WriteLine("Nie możesz zostać posłem");
            }
            else
            {
                Console.WriteLine("Podano w konsoli złą warotść w zadaniu 5");
            }

            //Zadanie 6
            int height;

            Console.WriteLine("Podaj wzrost do zadania 6");
            correctlyTyped = int.TryParse(Console.ReadLine(), out height);
            if (correctlyTyped)
            {
                if (height < 150 && height > 0)
                    Console.WriteLine("Jesteś krasnoludem");
                else if (height < 210 && height >= 150)
                    Console.WriteLine("Jesteś człowiekiem");
                else if (height >= 210)
                    Console.WriteLine("Jesteś wysokim elfem");
                else
                    Console.WriteLine("Nie możesz mieć ujemnego wzrostu");
            }
            else
            {
                Console.WriteLine("Podano w konsoli złą warotść w zadaniu 6");
            }

            //Zadanie 7
            int numExerise7;
            List<int> numbers = new List<int>();

            Console.WriteLine("Podaj pierwszą liczbę");
            correctlyTyped = int.TryParse(Console.ReadLine(), out numExerise7);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 7");
            else
                numbers.Add(numExerise7);

            Console.WriteLine("Podaj drugą liczbę");
            correctlyTyped = int.TryParse(Console.ReadLine(), out numExerise7);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 7");
            else
                numbers.Add(numExerise7);

            Console.WriteLine("Podaj trzecią liczbę");
            correctlyTyped = int.TryParse(Console.ReadLine(), out numExerise7);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 7");
            else
                numbers.Add(numExerise7);

            Console.WriteLine($"{numbers.Max()} jest największa z podanych");

            // Zadanie 8
            const int MATH_RESULT = 70;
            const int PHYSICS_RESULT = 55;
            const int CHEMISTRY_RESULT = 45;
            int mathResult, physicsResult, chemistryResult;
            int sumResult, mathAndOtherResult;

            Console.WriteLine("Podaj wynik z matematyki");
            correctlyTyped = int.TryParse(Console.ReadLine(), out mathResult);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 8");

            Console.WriteLine("Podaj wynik z fizyki");
            correctlyTyped = int.TryParse(Console.ReadLine(), out physicsResult);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 8");

            Console.WriteLine("Podaj wynik z chemii");
            correctlyTyped = int.TryParse(Console.ReadLine(), out chemistryResult);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 8");

            sumResult = mathResult + physicsResult + chemistryResult;
            mathAndOtherResult = mathResult + (physicsResult > chemistryResult ? physicsResult : chemistryResult);
            if (mathAndOtherResult > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (mathResult > MATH_RESULT && physicsResult > PHYSICS_RESULT && chemistryResult > CHEMISTRY_RESULT && sumResult > 180)
            {
                Console.WriteLine("Kandydat nie jest dopuszczony do rekrutacj");
            }
            else
            {
                Console.WriteLine("Kandydat nie jest dopuszczony do rekrutacj");
            }

            // Zadanie 9
            int temperature;

            Console.WriteLine("Podaj temperaturę");
            correctlyTyped = int.TryParse(Console.ReadLine(), out temperature);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 9");

            if (temperature < 0)
                Console.WriteLine("cholernie piździ");
            else if (temperature >= 0 && temperature < 10)
                Console.WriteLine("zimno");
            else if (temperature >= 10 && temperature < 20)
                Console.WriteLine("chłodno");
            else if (temperature >= 20 && temperature < 30)
                Console.WriteLine("w sam raz");
            else if (temperature >= 30 && temperature < 40)
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            else
                Console.WriteLine("a weź wyprowadzam się na Alaskę.");

            // Zadanie 10
            int side1, side2, side3;
            bool check1, check2, check3;
            Console.WriteLine("Podaj długosc boku 1");
            correctlyTyped = int.TryParse(Console.ReadLine(), out side1);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 10");

            Console.WriteLine("Podaj długosc boku 2");
            correctlyTyped = int.TryParse(Console.ReadLine(), out side2);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 10");

            Console.WriteLine("Podaj długosc boku 3");
            correctlyTyped = int.TryParse(Console.ReadLine(), out side3);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 10");

            check1 = side1 + side2 > side3;
            check2 = side1 + side3 > side2;
            check3 = side3 + side2 > side1;

            if (check1 && check2 && check3)
                Console.WriteLine("Można zbudować trójkąt");

            // Zadanie 11
            int grade;
            string resultExercise11;
            Console.WriteLine("Podaj ocenę");
            correctlyTyped = int.TryParse(Console.ReadLine(), out grade);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 11");

            resultExercise11 = grade switch
            {
                1 => "Niedostateczny",
                2 => "Dopuszczjący",
                3 => "Dostateczny",
                4 => "Dobry",
                5 => "Bardzo dobry",
                6 => "Celujący",
                _ => "Nie ma takiej oceny!!"
            };
            Console.WriteLine($"{resultExercise11}");

            //Zadanie 12
            int dayOfWeek;
            string resultExercise12;
            Console.WriteLine("Podaj dzień tygodnia");
            correctlyTyped = int.TryParse(Console.ReadLine(), out dayOfWeek);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 12");

            resultExercise12 = dayOfWeek switch
            {
                1 => "Poniedziałek",
                2 => "Wtorek",
                3 => "Środa",
                4 => "Czwartek",
                5 => "Piątek",
                6 => "Sobota",
                7 => "Niedziela",
                _ => "Nie ma takiego dnia tygoania!"
            };
            Console.WriteLine($"{resultExercise12}");

            //Zadanie 13
            double number1, number2;
            double resultExercise13 = 0d;
            int operation;

            Console.WriteLine("Podaj pierwszą liczbę");
            correctlyTyped = double.TryParse(Console.ReadLine(), out number1);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 13");

            Console.WriteLine("Podaj drugą liczbę");
            correctlyTyped = double.TryParse(Console.ReadLine(), out number2);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 13");

            Console.WriteLine("Podaj numer operacji do wykonania\n1. Dodawanie\n2. Odejmowanie\n3. Mnożenie\n4. Dzielenie");
            correctlyTyped = int.TryParse(Console.ReadLine(), out operation);
            if (!correctlyTyped)
                Console.WriteLine("Zła wartość wpisana w konsoli w zadaniu 13");

            switch (operation)
            {
                case 1:
                    resultExercise13 = number1 + number2;
                    break;
                case 2:
                    resultExercise13 = number1 - number2;
                    break;
                case 3:
                    resultExercise13 = number1 * number2;
                    break;
                case 4:
                    resultExercise13 = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Nie ma takiej operacji");
                    break;
            }

            Console.WriteLine($"Twój wynik to: {resultExercise13}");
        }
    }
}
