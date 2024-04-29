using System;

internal class Program
{
    private static void Main(string[] args)
    {
        menu();
    }

    public static void menu()
    {
        //Hecho por adrian
        try
        {
            Console.WriteLine("Seleccione la operación a realizar:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Elija una opción (1-4): ");

            // Leer la opción del usuario
            int opcion = int.Parse(Console.ReadLine());

            // Leer los operandos
            Console.Write("Ingrese el primer operando: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo operando: ");
            int b = int.Parse(Console.ReadLine());

            // Realizar la operación seleccionada
            int resultado = 0;
            switch (opcion)
            {
                case 1:
                    resultado = sumar(a, b);
                    break;
                case 2:
                    resultado = restar(a, b);
                    break;
                case 3:
                    resultado = multiplicar(a, b);
                    break;
                case 4:
                    resultado = dividir(a, b);
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    return;
            }

            Console.WriteLine("El resultado es: " + resultado);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Entrada no válida. Por favor, ingrese un número entero.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error inesperado: " + ex.Message);
        }
    }

    // Métodos para realizar operaciones matemáticas
    public static int sumar(int a, int b)
    {
        return a + b;
    }

    public static int restar(int a, int b)
    {
        return a - b;
    }

    public static int multiplicar(int a, int b)
    {
        return a * b;
    }

    public static int dividir(int a, int b)
    {
        if (b == 0)
        {
            throw new ArgumentException("No se puede dividir por cero.");
        }
        return a / b;
    }
}
