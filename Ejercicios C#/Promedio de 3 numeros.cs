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
         Console.WriteLine ("Ingrese el tercer numero:");
         double numeroTres = 
         Convert.ToDouble(Console.ReadLine());
         
         double promedio = numeroUno+numeroDos+numeroTres / 3;
         
         
         Console.WriteLine ($"El promedio de los tres numeros es: {promedio}");
         
    }