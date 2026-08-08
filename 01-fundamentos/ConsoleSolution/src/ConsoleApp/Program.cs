// Versión moderna (top-level statements)
Console.WriteLine("=== Mi Aplicación de Consola ===\n");
Console.Write("Ingresa tu nombre: ");
string? nombre = Console.ReadLine();
Console.Write("Ingresa tu edad: ");
string? edadInput = Console.ReadLine();
if (int.TryParse(edadInput, out int edad))
{
Console.WriteLine($"\n¡Hola {nombre}! Tienes {edad} años.");
Console.WriteLine($"El año que viene tendrás {edad + 1} años.");
}
else
{
Console.WriteLine($"\n¡Hola {nombre}! (No ingresaste una edad válida)");
}


Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Texto en darkRed");
Console.ResetColor();