// Declaración del nombre del cliente
string nombreCliente = "Sra. Barros";

// Producto actual y detalles financieros asociados
string productoActual = "Magic Yield";
int accionesActuales = 2975000;
decimal retornoActual = 0.1275m;
decimal gananciaActual = 55000000.0m;

// Nuevo producto y su rentabilidad
string nuevoProducto = "Glorious Future";
decimal nuevoRetorno = 0.13125m;
decimal nuevaGanancia = 63000000.0m;

// Enviar un mensaje personalizado al cliente
Console.WriteLine($"Estimado/a {nombreCliente},");
Console.WriteLine($"Como cliente de nuestro producto {productoActual}, estamos emocionados de contarle sobre un nuevo producto financiero que aumentaría drásticamente su retorno.\n");
Console.WriteLine($"Actualmente, posee {accionesActuales:N} acciones con un retorno de {retornoActual:P}.\n");
Console.WriteLine($"Nuestro nuevo producto, {nuevoProducto}, ofrece un retorno de {nuevoRetorno:P}. Dado su volumen actual, su ganancia potencial sería de {nuevaGanancia:C}.\n");

Console.WriteLine("Aquí tiene una comparación rápida:\n");

// Crear el mensaje de comparación entre los dos productos
string mensajeComparacion = "";

// Añadir detalles del producto actual
mensajeComparacion = productoActual.PadRight(20); // Alinear nombre del producto a 20 caracteres
mensajeComparacion += String.Format("{0:P}", retornoActual).PadRight(10); // Formatear y alinear el retorno
mensajeComparacion += String.Format("{0:C}", gananciaActual).PadRight(20); // Formatear y alinear la ganancia

// Añadir una nueva línea y detalles del nuevo producto
mensajeComparacion += "\n";
mensajeComparacion += nuevoProducto.PadRight(20); // Alinear nombre del nuevo producto a 20 caracteres
mensajeComparacion += String.Format("{0:P}", nuevoRetorno).PadRight(10); // Formatear y alinear el nuevo retorno
mensajeComparacion += String.Format("{0:C}", nuevaGanancia).PadRight(20); // Formatear y alinear la nueva ganancia

// Imprimir la comparación
Console.WriteLine(mensajeComparacion);
