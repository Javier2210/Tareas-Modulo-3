using System;

public class Ejercicios
{
    public static void Main(string[] args)
    {
         Console.WriteLine ("Ingrese el grado de temperatura en celsius:");
         double gradoCelsius = 
         Convert.ToDouble(Console.ReadLine());
         
         double gradoF = (gradoCelsius * 9 / 5) + 32;
         
         
         Console.WriteLine ($"La temperatura de celsius a fahrenheit es: {gradoF}");
         
    }
}