// See https://aka.ms/new-console-template for more information

//Programa para calcular el area de un rectangulo.
//variables implicitas
var ladoA = 0.0; // Puedes inicializarlo con 0 o con otro valor predeterminado según sea necesario
var ladoB = 0.0;
var Res = 0.0;
bool DatoA, DatoB;

Console.WriteLine("Calcula el área de un rectángulo");

do
{
    Console.WriteLine("Ingrese el lado A");
    //el int.tryparce (retorna Falso o verdadero) intentara transformar lo que el usuario meta por el teclado a 
    //Int si es verdad manda el Int a la variable ladoA y el la variable DatoA manda un falso o verdadero dependiendo 
    //de si se purdo hacer el Parse a Int.
    DatoA = double.TryParse(Console.ReadLine(), out ladoA);
    //Compara si el dato es falso ejecuta la linea dentro del if de ser verdadero no entra al if y se pasa diretamente al while 
    //donde realiza la misma comparacion si la variable DatoA es verdadera  sale del ciclo de lo contrario repite todo el proceso.
    if (!DatoA)
    {
        Console.WriteLine("Por favor, ingrese un número entero válido.");
    }
} while (!DatoA);

do
{
    Console.WriteLine("Ingrese el lado B");
    DatoB = double.TryParse(Console.ReadLine(), out ladoB);
    if (!DatoB)
    {
        Console.WriteLine("Por favor, ingrese un número entero válido.");
    }
} while (!DatoB);

Res = ladoA * ladoB;

Console.WriteLine("\nEl lado A es: " + ladoA + "\nEl lado B es: " + ladoB + "\nEl área es de: " + Res);

