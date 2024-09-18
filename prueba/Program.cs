// ############################################################
// #################### Juego define Rol   ####################
// ############################################################

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"El monstruo recibió daño y perdió {roll} de salud, ahora tiene {monster} de salud.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"El héroe recibió daño y perdió {roll} de salud, ahora tiene {hero} de salud.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "¡El héroe gana!" : "¡El monstruo gana!");
