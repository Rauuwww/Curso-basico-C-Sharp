
var r = 0d;
var Resultado = 0d;
const double Pi = 3.1416; //constantes siempre comienzan en Mayuscula
bool comprobacion;

Console.WriteLine("Bienvenido");
// PI * r^2
do
{
    Console.WriteLine("Ingresa el valor del radio: ");
    //el double.tryparce (retorna Falso o verdadero) intentara transformar lo que el usuario meta por el teclado a 
    //Double si es verdad manda el Double a la variable "r" y en la variable comprobacion manda un falso o verdadero dependiendo 
    //de si se purdo hacer el Parse a Double.
    comprobacion = double.TryParse(Console.ReadLine(), out r);
    //Compara si el dato es falso ejecuta la linea dentro del if de ser verdadero no entra al if y se pasa diretamente al while 
    //donde realiza la misma comparacion si la variable comprobacion es verdadera sale del ciclo de lo contrario repite todo el proceso.
    if (!comprobacion)
    {
        Console.WriteLine("Por favor, ingrese un número válido.");
    }
} while (!comprobacion);

Resultado = Pi * (Math.Pow(r,2));

Console.WriteLine("El area del circulo es: " +  Resultado);
