using System.Text;

// See https://aka.ms/new-console-template for more information
using System.Drawing;



// Texto o comentario es este simbolo
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");
Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line.");

Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);


string name = "Bob";
decimal temperature = 34.4m;
string messages = "tas";

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.WriteLine(" celsius.");


Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");


string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");
string message = $"{greeting} {firstName}!";

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

string projectName1 = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");


// Ejercicio de Matematicas
Console.Clear();
Console.WriteLine(Environment.NewLine+"##################################################");
Console.WriteLine("##########   Ejercicio de Matematicas  ###########");
Console.WriteLine("##################################################");
int firstNumber = 10;
int secondNumber = 7;

Console.WriteLine( "Resultado de suma  " + (firstNumber + secondNumber));
Console.WriteLine( "Resultado de resta  " + (firstNumber - secondNumber));
Console.WriteLine( "Resultado de multiplicar  " + (firstNumber * secondNumber));
Console.WriteLine( "Resultado de dividir  " + (firstNumber / secondNumber));
Console.WriteLine( "Resultado de decimal  " + (firstNumber /(decimal) secondNumber));

// Temperatura
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine(Environment.NewLine+"##################################################");
Console.WriteLine("##########   Ejercicio de temperatura  ###########");
Console.WriteLine("##################################################");
Console.WriteLine("The temperature is " + celsius + " Celsius.");
Console.WriteLine(Environment.NewLine+"");


