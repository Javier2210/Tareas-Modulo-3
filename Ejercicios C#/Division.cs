using System;

public class Ejercicios
{
    public static void Main(string[] args)
    {
         Console.WriteLine ("Ingrese el primer numero:");
         double numeroUno = 
         Convert.ToDouble(Console.ReadLine());
         Console.WriteLine ("Ingrese el segundo numero:");
         double numeroDos = 
         Convert.ToDouble(Console.ReadLine());
       
         
         double division = numeroUno / numeroDos;
         
         
         Console.WriteLine ($"El resutado de la division es: {division}");
         
    }
}