using System;

int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int platziCoins = 0;
string message = "";
int controlOtraCarta = 0;
string switchControl = "menu";

System.Random random = new System.Random();

while (true)
{
    Console.WriteLine("\nWelcome al P l a t z i n o");
    Console.WriteLine("¿Cuántos PlatziCoins deseas? \n" +
                       "Ingresa un número entero \n" +
                       "Recuerda que necesitas 1 por ronda");
    platziCoins = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");

    for (int i = 0; i < platziCoins; i++)
    {
        totalJugador = 0;
        totalDealer = 0;

        switch (switchControl)
        {
            case "menu":

                Console.WriteLine("¿Deseas jugar al 21?\n Escribe para confirmar 's'/'n'");
                switchControl = Console.ReadLine();
                i = i - 1;

                break;
            case "s":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("\nToma tu carta, jugador,");
                    Console.WriteLine($"Te salió el número: {num} ");
                    Console.WriteLine("¿Deseas otra carta ? \n 1. Si \n 2. Plantarse");
                    controlOtraCarta = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                } while (controlOtraCarta == 1);

                totalDealer = random.Next(14, 22);
                Console.WriteLine($"El dealer tiene {totalDealer}");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "Venciste al dealer, felicidades";
                    switchControl = "menu";
                }
                else if (totalJugador >= 22)
                {
                    message = "Perdiste vs el dealer, te pasaste de 21";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "Perdiste vs el dealer, lo siento";
                    switchControl = "menu";
                }
                else
                {
                    message = "condición no válida";
                }
                Console.WriteLine(message);
                break;
            case "n":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Valor ingresa no válido en el  C A S I N O");
                break;
        }
    }
}