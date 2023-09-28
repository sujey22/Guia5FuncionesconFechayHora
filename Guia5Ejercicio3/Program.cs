using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;


//Ejercicio 3 funciones de fecha

class Program
{
    public static void Main()
    {
        Console.WriteLine("Por favor, Ingrese su fecha de cumpleaños (DD-MM-YYYY):");
        if (DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaCumpleaños))
        {
            DateTime fechaActual = DateTime.Today;

            int añosCumplidos = CalcularProximoCumple(fechaActual, fechaCumpleaños);
            DateTime proximoCumpleaños = fechaCumpleaños.AddYears(añosCumplidos);
            

            int diasRestantes = CalcularDiasRestantes(fechaActual, proximoCumpleaños);

            Console.WriteLine($"Su próximo cumpleaños sera el {proximoCumpleaños.ToString("dd/MM/yyyy") }");
            Console.WriteLine($"Faltan {diasRestantes} días para su próximo cumpleaños.");
        }
        else
        {
            Console.WriteLine("Fecha de cumpleaños no válida. Por favor, ingrese una fecha válida en el formato DD-MM-YYYY.");
        }
    }

    public static int CalcularProximoCumple(DateTime fechaActual, DateTime fechaCumpleaños)
    {
        DateTime proximoCumpleaños = fechaCumpleaños.AddYears(1);

        if (proximoCumpleaños < fechaActual)
        {
            proximoCumpleaños = fechaActual.AddYears(1);
        }

        int añosCumplidos = proximoCumpleaños.Year - fechaCumpleaños.Year;

        if (proximoCumpleaños.Month < fechaCumpleaños.Month || (proximoCumpleaños.Month == fechaCumpleaños.Month && proximoCumpleaños.Day < fechaCumpleaños.Day))
        {
            añosCumplidos--;
        }

        return añosCumplidos;
    }
    

    public static int CalcularDiasRestantes(DateTime fechaActual, DateTime fechaCumpleaños)
    {
        DateTime proximoCumpleaños = new DateTime(fechaActual.Year, fechaCumpleaños.Month, fechaCumpleaños.Day);

        if (proximoCumpleaños < fechaActual)
        {
            proximoCumpleaños = proximoCumpleaños.AddYears(1);
        }

        TimeSpan diferencia = proximoCumpleaños - fechaActual;
        return diferencia.Days;
    }
}
