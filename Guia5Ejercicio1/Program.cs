using System;

//Ejercicio 1 con el método IsLeapyear

class ProgramEjer1
{
    public static void Main()
    {
        int[] años = new int[10] { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020,2021 };

        foreach (int año in años)
        {
            if (IsLeapYear(año))
            {
                Console.WriteLine($"El año {año}, Es un año bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {año}, No es un año bisiesto.");
            }
        }
    }

    public static bool IsLeapYear(int año)
    {
        return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
    }
}
