using System;

namespace EjercicioExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("===== Calculadora Básica =====");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                try
                {
                    opcion = int.Parse(Console.ReadLine());

                    if (opcion >= 1 && opcion <= 4)
                    {
                        Console.Write("Ingrese el primer número: ");
                        double num1 = double.Parse(Console.ReadLine());

                        Console.Write("Ingrese el segundo número: ");
                        double num2 = double.Parse(Console.ReadLine());

                        double resultado = 0;

                        switch (opcion)
                        {
                            case 1:
                                resultado = Operaciones.Sumar(num1, num2);
                                break;
                            case 2:
                                resultado = Operaciones.Restar(num1, num2);
                                break;
                            case 3:
                                resultado = Operaciones.Multiplicar(num1, num2);
                                break;
                            case 4:
                                resultado = Operaciones.Dividir(num1, num2);
                                break;
                        }

                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    else if (opcion == 5)
                    {
                        Console.WriteLine("¡Gracias por usar la calculadora!");
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Ingrese un número válido.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 5);
        }
    }
}
