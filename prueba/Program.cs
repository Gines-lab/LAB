// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Text;


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
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.WriteLine(" celsius.");


Console.OutputEncoding = Encoding.UTF8;
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
