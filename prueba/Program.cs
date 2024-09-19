int value1 = 11; 
decimal value2 = 6.2m; 
float value3 = 4.3f; 

// Solución para result1: Dividir value1 entre value2, mostrar el resultado como int
// Convierte value1 a decimal antes de dividir para evitar problemas de tipos
int result1 = (int)Math.Round((decimal)value1 / value2); 
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Solución para result2: Dividir value2 entre value3, mostrar el resultado como decimal
// Se realiza la conversión de value3 a decimal antes de la división para evitar pérdida de precisión
decimal result2 = value2 / (decimal)value3; 
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Solución para result3: Dividir value3 entre value1, mostrar el resultado como float
// Aseguramos que el tipo sea float durante la división
float result3 = value3 / value1; 
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
