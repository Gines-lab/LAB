string permission = "Admin|Manager";
int level = 30;

// Verificamos si el permiso contiene "Admin"
if (permission.Contains("Admin"))
{
    // Comprobamos el nivel para Admin
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level > 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
// Si el permiso no contiene "Admin", verificamos si contiene "Manager"
else if (permission.Contains("Manager"))
{
    // Comprobamos el nivel para Manager
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level > 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
// Si el permiso no contiene ni "Admin" ni "Manager"
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
