﻿namespace EjercicioExcepciones
{
    public class Operaciones
    {
        public static double Sumar(double a, double b) => a + b;

        public static double Restar(double a, double b) => a - b;

        public static double Multiplicar(double a, double b) => a * b;

        public static double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");
            return a / b;
        }
    }
}
