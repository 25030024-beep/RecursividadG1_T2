using Recursividad.Logica;

Console.WriteLine("Ejemplos de recursividad");
Console.WriteLine("\n\nFactorial");

Recursividades oRecursividades = new Recursividades();

int resultadoFactorial = oRecursividades.CalcularFactorial(5);
Console.WriteLine("El resultado de 5! es: " + resultadoFactorial);