using System;

//Ejercio 2 con funciones de fecha
class Program
{
    public static void Main()
    {
        double montoPrestamo = 3000.00;
        int plazoMeses = 6;
        DateTime fechaInicio = DateTime.Now;

        
        double cuotaMensual = montoPrestamo / plazoMeses;

        Console.WriteLine("Detalles del préstamo:");
        Console.WriteLine("Estudiante: Juan Perez");
        Console.WriteLine("Lugar donde estudia: UNAB Chalatenango");
        Console.WriteLine($"Monto del préstamo: ${montoPrestamo}");
        Console.WriteLine($"Plazo: {plazoMeses} meses");

        Console.WriteLine("\nFechas para realizar el pago y sus cuotas mensuales:");
        for (int i = 0; i < plazoMeses; i++)
        {
            
            DateTime FechaPago = fechaInicio.AddMonths(i);

            
            Console.WriteLine($"{FechaPago.ToString("dd MMMM yyyy")}: Cuota de ${cuotaMensual}");
        }
    }
}
