using DotNetEx2_7;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
//using CalculatorServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Metoda InData() Pobiera informacje od urzytkownika,
        //oraz za pomocą opcji zwraca text lub tylko wyświetla informacje tekstowe lub wyświetla
        //tekst naciśnij klawisz aby kontynuować 
        //1 zadanie tworzenie dwóch zmiennych int i sprawdzenie czy są równe 
        string a = "5", b = "5";
        int a1 = 0, b1 = 0;
        int.TryParse(a, out a1);
        int.TryParse(b, out b1);
        if (a1 == b1)
        {
            InData("liczba " + a + " i liczba " + b + " są równe", 2);
        }

        //2 zadanie sprawdź czy liczba jest parzysta        
        while (true)
        {
            if (int.TryParse(InData("Podaj liczbę", 0, 1), out int number))
            {
                if (number % 2 == 0)
                {
                    InData(number + " jest liczbą parzysta", 2, 1);
                    break;
                }
                else if (true)
                {
                    InData(number + " jest liczbą nieparzysta", 2, 1);
                    break;

                }
            }
        }

        //3 zadanie program do sprawdzenia czy podana liczba jest ujemna

        while (true)
        {
            if (double.TryParse(InData("Podaj liczbę dodatią lub ujemną", 0, 1), out double number))
            {
                if (number < 0)
                {
                    InData(number + " jest liczbą ujemną", 2, 1);
                    break;
                }
                else if (number > 0)
                {
                    InData(number + " jest liczbą dodatnią", 2, 1);
                    break;
                }
            }
        }

        //4 zadanie sprawdza czy podany rok jest przestępny
        while (true)
        {
            if (int.TryParse(InData("Podaj rok to sprawdzę czy jest rokiem przestępnym", 0, 1), out int year))
            {
                if (((year % 4 == 0 & year % 100 != 0) || year % 400 == 0) & year > 0)
                {
                    InData(year + " jest rokiem przestępnym ", 2, 1);
                    break;
                }
                else if (true)
                {
                    InData(year + " nie jest rokiem przestępnym ", 2, 1);
                    break;

                }
            }
        }

        //5 zadanie na jakie stanowisko możesz kandydować

        while (true)
        {
            if ((int.TryParse(InData("Podaj swój wiek ", 0, 1), out int year)) & year > 0)
            {
                if (year >= 21 & year < 30)
                {
                    InData("Możesz zostać posłem", 2, 1);
                    break;
                }
                else if (year >= 30 & year < 35)
                {
                    InData("Możesz zostać posłem i senatorem", 2, 1);
                    break;
                }
                else if (year >= 35)
                {
                    InData("Możesz zostać posłem,senatorem i prezydentem", 2, 1);
                    break;
                }
                else
                {
                    year = 21 - year;
                    InData("Jeszcze poczekasz " + year + " lat zanim będziesz mógł ubiegać się o stanowisko posła", 2, 1);
                    break;
                }
            }
        }

        //6 zadanie przypisanie kategorii wzrostu
        while (true)
        {
            if (int.TryParse(InData("Podaj wzrost w cm", 0, 1), out int grow))
            {
                if (grow <= 49 & grow > 0)
                {
                    InData("Kategoria \"Szkrab\"", 2, 1);
                    break;
                }
                else if (grow >= 50 & grow <= 69)
                {
                    InData("Kategoria \"Duży Szkrab\"", 2, 1);
                    break;
                }
                else if (grow >= 70 & grow <= 99)
                {
                    InData("Kategoria \"Z Metra Cięty\"", 2, 1);
                    break;
                }
                else if (grow >= 100 & grow <= 159)
                {
                    InData("Kategoria \"Młody Bóg\"", 2, 1);
                    break;
                }
                else if (grow >= 160 & grow <= 199)
                {
                    InData("Kategoria \"Kawał Byka\"", 2, 1);
                    break;
                }
                else if (grow >= 200)
                {
                    InData("Kategoria \"Wielka Stopa\"", 2, 1);
                    break;
                }
            }
        }

        //7 zadanie pobieram trzy liczby od urzytkownika i sprawdzam która jest największa
        SortedList<int, string> list = new SortedList<int, string>();
        InData("Podaj trzy całkowite liczby ", 1, 1);
        for (int i = 1; i <= 3; i++)
        {
            int clear = 1;
            while (true)
            {
                if (int.TryParse(InData("Podaj liczbę " + i, 0, clear), out int number))
                {

                    if (!list.ContainsKey(number))
                    {
                        list.Add(number, "liczba " + i);
                        break;
                    }
                    else
                    {
                        clear = 0;
                        InData("Podaj inną liczbę ta już była\n", 1);
                    }
                }
                else
                {
                    clear = 0;
                    InData("Podaj prawidłową liczbę", 1, clear);
                }
            }
        }
        int lastInSortedlist = list.Keys[2];
        InData(lastInSortedlist + " jest największa z podanych", 2, 1);

        //8 zadanie czy kandydat może ubiegać się o miejsce na stuidiach
        while (true)
        {
            if ((int.TryParse(InData("Podaj Wynik z matematyki", 0, 1), out int mathematics)) & mathematics >= 0)
            {
                while (true)
                {
                    if ((int.TryParse(InData("Podaj Wynik z fizyki", 0, 1), out int physics)) & physics >= 0)
                    {
                        while (true)
                        {
                            if ((int.TryParse(InData("Podaj Wynik z chemii", 0, 1), out int chemistry)) & chemistry >= 0)
                            {
                                if ((mathematics > 70 & physics > 55 & chemistry > 45) ||
                                    (mathematics + physics + chemistry > 180) ||
                                    (mathematics + physics > 150 || mathematics + chemistry > 150))
                                {
                                    InData("Kandydat dopuszczony do rekrutacji", 2, 1);
                                }
                                else
                                {
                                    InData("Kandydat nie dopuszczony do rekrutacji ", 2, 1);
                                }
                                break; //chemia                               
                            }
                        }
                        break; //fizyka
                    }
                }
                break; //matematyka
            }
        }

        //9 zadanie pobierz temperaturę i zwróć nazwę

        while (true)
        {
            if (int.TryParse(InData("Podaj temperaturę", 0, 1), out int temperature))
            {
                if (temperature < 0)
                {
                    InData("cholernie piździ", 1, 1);
                }
                else if (temperature >= 0 & temperature < 10)
                {
                    InData("zimno", 1, 1);
                }
                else if (temperature >= 10 & temperature < 20)
                {
                    InData("chłodno", 1, 1);
                }
                else if (temperature >= 20 & temperature < 30)
                {
                    InData("w sam raz", 1, 1);
                }
                else if (temperature >= 30 & temperature < 40)
                {
                    InData("zaczyna być słabo, bo gorąco", 1, 1);
                }
                else if (temperature >= 40)
                {
                    InData("a weź wyprowadzam się na alaskę", 1, 1);
                }

                InData("", 2);
                break;
            }
        }

        //10 zadanie pobiera trzy długości boków i zwraca informacje czy można stworzyć trójkąt

        while (true)
        {
            InData("Podaj trzy liczby reprezentujące długości odcinów", 1, 1);
            if ((int.TryParse(InData("Podaj długość odcinka a"), out int length_a)) & length_a > 0)
            {
                while (true)
                {
                    if ((int.TryParse(InData("Podaj długość odcinka b", 0, 1), out int length_b)) & length_b > 0)
                    {
                        while (true)
                        {
                            if ((int.TryParse(InData("Podaj długość odcinka c", 0, 1), out int length_c)) & length_c > 0)
                            {
                                if (length_a + length_b > length_c)
                                {
                                    InData("Można zbudować trójkąt", 2, 1);
                                }
                                else
                                {
                                    InData("brak możliwości stworzenia trójkąta ", 2, 1);
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
                break;
            }
        }

        //11 zadanie pobiera ocenę i zwraca nazwę oceny

        while (true)
        {
            InData("Podaj ocenę ucznia jako liczbę", 1, 1);
            if ((int.TryParse(InData("Wpisz liczbę"), out int rating)) & rating > 0 & rating <= 6)
            {
                if (rating == 6)
                {
                    InData("Celujący", 2, 1);
                    break;
                }
                else if (rating == 5)
                {
                    InData("Bardzo dobry", 2, 1);
                    break;
                }
                else if (rating == 4)
                {
                    InData("Dobry", 2, 1);
                    break;
                }
                else if (rating == 3)
                {
                    InData("Dostateczny", 2, 1);
                    break;
                }
                else if (rating == 2)
                {
                    InData("Dopuszczający", 2, 1);
                    break;
                }
                else if (rating == 1)
                {
                    InData("Niedostateczny", 2, 1);
                    break;
                }
            }
        }

        //12 zadanie pobiera numer dnia tygodnia i wyświetla nazwę dnia w języku angielskim

        while (true)
        {
            string stringToIntDay = InData("Podaj numer dnia tygodnia:", 0, 1);
            if (int.TryParse(stringToIntDay, out int intDay) & intDay > 0 & intDay <= 7)
            {

                InData("Angielska nazwa dnia numer " + intDay + " to:  " + (DayOfWeek)intDay, 2);
                break;
            }
        }


        CalculatorServices Calculate = new CalculatorServices();
        bool exit = false;
        while (true)
        {
            InData("Wybierz opcję:\n1. Dodawanie\n2. Odejmowanie\n" +
                                "3. Mnożenie\n4. Dzielenie\n5. Zakończ", 1, 1);
            ConsoleKeyInfo option = Console.ReadKey();
            switch (option.KeyChar)
            {
                case '1':
                    Calculate.CalculatorServicesView();
                    int calculations = Calculate.Number1 + Calculate.Number2;
                    Console.Clear();
                    Console.WriteLine(Calculate.Number1 + " + " + Calculate.Number2 + " = " + calculations);
                    Console.ReadKey();
                    break;
                case '2':
                    Calculate.CalculatorServicesView();
                    calculations = Calculate.Number1 - Calculate.Number2;
                    Console.Clear();
                    Console.WriteLine(Calculate.Number1 + " - " + Calculate.Number2 + " = " + calculations);
                    Console.ReadKey();
                    break;
                case '3':
                    Calculate.CalculatorServicesView();
                    calculations = Calculate.Number1 * Calculate.Number2;
                    Console.Clear();
                    Console.WriteLine(Calculate.Number1 + " * " + Calculate.Number2 + " = " + calculations);
                    Console.ReadKey();
                    break;
                case '4':
                    Calculate.CalculatorServicesView();
                    if (Calculate.Number2 == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Nie dziel przez 0 !!!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        calculations = Calculate.Number1 / Calculate.Number2;
                        Console.Clear();
                        Console.WriteLine(Calculate.Number1 + " / " + Calculate.Number2 + " = " + calculations);
                        Console.ReadKey();
                        break;
                    }
                case '5':
                    exit = true;
                    break;
                default:
                    InData("Wybież inną opcję");
                    break;
            }

            if (exit)
            {
                break;
            }
        }

        static string InData(string text, int empty = 0, int clear_console = 0)
        {
            string outtext;
            if (clear_console == 1)
            {
                Console.Clear();
            }
            Console.WriteLine(text);

            if (empty == 1)
            {
                outtext = "";
                return outtext;
            }
            else
            {
                if (empty == 2)
                {
                    Console.WriteLine("\n\nNaciśnij dowolny klawisz...");
                    Console.ReadKey();
                    outtext = "";
                    return outtext;
                }
            }



            return outtext = Console.ReadLine();
        }
    }
}