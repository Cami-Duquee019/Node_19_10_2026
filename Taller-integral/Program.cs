using System;

class Program
{
    static void Main()
    {
        // Pruebas del taller
        Console.WriteLine(ClasificarNumero(5));  // "El número es positivo"
        Console.WriteLine(ClasificarNumero(-3)); // "El número es negativo"
        Console.WriteLine(ClasificarNumero(0));  // "El número es cero"
    }

    static string ClasificarNumero(int numero)
    {
        if (numero > 0)
        {
            return "El número es positivo";
        }
        else if (numero < 0)
        {
            return "El número es negativo";
        }
        else
        {
            return "El número es cero";
        }
    }
}