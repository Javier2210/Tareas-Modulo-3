using System;

public class Triangulo
{
    public static void Main(string[] args)
    {
         Console.WriteLine ("Ingrese la base del triangulo:");
         double baseTriangulo = 
         Convert.ToDouble(Console.ReadLine());
         Console.WriteLine ("Ingrese la altura del triangulo:");
         double alturaTriangulo = 
         Convert.ToDouble(Console.ReadLine());
         
         double area = baseTriangulo * alturaTriangulo;
         
         Console.WriteLine ($"El area del triangulo es: {area}");
         
    }
}