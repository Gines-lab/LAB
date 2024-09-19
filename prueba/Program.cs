string pangram = "The quick brown fox jumps over the lazy dog";

// Paso 1 y 3 combinados: Dividimos el string, invertimos cada palabra y las volvemos a juntar en un solo paso
string result = string.Join(" ", pangram
                           .Split(' ') // Dividimos la cadena en palabras
                           .Select(word => new string(word.Reverse().ToArray()))); // Invertimos cada palabra

// Paso 4: Mostramos el resultado
Console.WriteLine(result);
