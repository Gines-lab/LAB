using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Environment.NewLine + "############################################################");
        Console.WriteLine("##########   Juego de Rol  #####################");
        Console.WriteLine("############################################################");

        int heroHealth = 10;
        int monsterHealth = 10;

        Random dice = new Random();

        while (heroHealth > 0 && monsterHealth > 0)
        {
            // El héroe ataca al monstruo
            int damageToMonster = RollDice(dice);
            monsterHealth -= damageToMonster;
            Console.WriteLine($"El monstruo recibió daño y perdió {damageToMonster} de salud, ahora tiene {monsterHealth} de salud.");

            // Verifica si el monstruo ha sido derrotado
            if (monsterHealth <= 0)
            {
                Console.WriteLine("¡El héroe gana!");
                break;
            }

            // El monstruo ataca al héroe
            int damageToHero = RollDice(dice);
            heroHealth -= damageToHero;
            Console.WriteLine($"El héroe recibió daño y perdió {damageToHero} de salud, ahora tiene {heroHealth} de salud.");

            // Verifica si el héroe ha sido derrotado
            if (heroHealth <= 0)
            {
                Console.WriteLine("¡El monstruo gana!");
                break;
            }
        }
    }

    static int RollDice(Random dice)
    {
        return dice.Next(1, 11); // Lanza un dado de 1 a 10
    }
}
