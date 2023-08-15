// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int modenas = 0;
String message = "";
String controlOtraCarta = "";
string switchControl = "menu";

System.Random random = new System.Random();

//Blackjack,si juntas 21 pidiendo ganas, en caso de pasarte de 21 pierdes.
//si tienes menos de 21 o igual al dealer ganas.

while (true)
{
    Console.WriteLine("Bienvenido al C A S I N O");
    Console.WriteLine("Cuantas modenas deseas? \n " +
        "Ingresa un numero entero \n" +
        "Recuerda que necesias una por ronda.");
    modenas = int.Parse(Console.ReadLine());

    for (int i = 0; i < modenas; i++)
    {

        totalJugador = 0;
        totalDealer = 0;

        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Escriba '21' para jugar al 21");
                switchControl = Console.ReadLine();
                i = i - 1;
                break;


            case "21":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu carta, Jugador");
                    Console.WriteLine($"Tu carta es el numero: {num} ");
                    Console.WriteLine("Deseas otra Carta?");
                    controlOtraCarta = Console.ReadLine();

                } while (controlOtraCarta == "SI" ||
                         controlOtraCarta == "si" ||
                         controlOtraCarta == "yes" ||
                         controlOtraCarta == "YES");

                totalDealer = random.Next(12, 21);
                Console.WriteLine($"El dealer tiene {totalDealer}!");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = $"Vencisite al dealer con {totalJugador}, ¡Felicitaciones!";
                    switchControl = "menu";
                }

                else if (totalJugador >= 22)
                {
                    message = $"Perdiste vs el dealer con {totalJugador}, te pasaste de 21";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = $"Perdiste vs el dealer con {totalJugador}, lo siento";
                    switchControl = "menu";
                }
                else
                {
                    message = "Condición no válida";
                    switchControl = "menu";
                }

                Console.WriteLine(message);
                break;

            default:
                Console.WriteLine("Valor ingresado no valido en el C A S I N O");
                break;

        }
    }
}