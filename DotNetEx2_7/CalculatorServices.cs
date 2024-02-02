using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotNetEx2_7
{
    public class CalculatorServices
    {

        public int Number1 { get; private set; }
        public int Number2 { get; private set; }


        public void CalculatorServicesView()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Podaj pierwszą liczbę");
                var firstNumber = Console.ReadLine();
                if (int.TryParse(firstNumber, out int intFirstNumber))
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Podaj drugą liczbę");
                        var nextNumber = Console.ReadLine();
                        if (int.TryParse(nextNumber, out int intNextNumber))
                        {
                            Number2 = intNextNumber;
                            Number1 = intFirstNumber;
                            break;
                        }
                      
                    }
                    break;
                }
            }
        }

    }
}
