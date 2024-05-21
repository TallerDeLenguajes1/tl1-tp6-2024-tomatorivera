// Ejercicio 1

/*
Console.Write("Ingrese un numero: ");
String strNumero = Console.ReadLine();
int intNumero = 0;

if (!int.TryParse(strNumero, out intNumero))
{
    Console.WriteLine("[!] El valor ingresado NO es un numero valido");
}
else if (intNumero <= 0)
{
    Console.WriteLine("[!] El numero debe ser mayor a cero");
}
else
{
    Console.Write("\n** Numero invertido: ");
    invertirNumero(intNumero);
}

static void invertirNumero(int numero)
{
    if (numero < 10)
        Console.Write(numero);
    else
    {
        int ultimoDigito = numero%10;
        int aux = Convert.ToInt32(numero/10);
        Console.Write(ultimoDigito);
        
        invertirNumero(aux);
    }
}
*/

// Ejercicio 4
/*
Console.Write("> Ingrese una cadena: ");
string cadena = Console.ReadLine().Trim();

// Obtener la longitud de la cadena y muestre por pantalla.
int longitud = cadena.Length;
Console.WriteLine($"\n\tLongitud de la cadena: {longitud}");

// A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.
Console.Write("\n> Ingrese otra cadena: ");
string cadenaB = Console.ReadLine().Trim();

string concatenacion = string.Concat(cadena, " ", cadenaB);
Console.WriteLine($"\n\tCadenas concatenadas: {concatenacion}");

// Extraer una subcadena de la cadena ingresada.
string subcadena = cadena.Substring(0, 3);
Console.WriteLine($"\tSubcadena de la cadena '{cadena}' desde sus 3 primeros caracteres: {subcadena}");

// Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para la suma sería: “la suma de “ num1 “ y de” num2 “ es igual a: ” resultado. Donde num1, num2 y resultados son los sumandos y el resultado de la operación respectivamente. Nota: Busque el comportamiento del Método ToString();

// Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
Console.Write("\tMuestro la cadena caracter por caracter: ");
foreach (char caracter in cadena) {
    Console.Write($"{caracter}, ");
}

// Buscar la ocurrencia de una palabra determinada en la cadena ingresada
Console.Write($"\n\n> Ingrese una ocurrencia a buscar en '{cadena}': ");
string ocurrencia = Console.ReadLine().Trim();

if (cadena.Contains(ocurrencia)) {
    Console.WriteLine($"\n\t'{ocurrencia}' SI esta contenida en '{cadena}'");
} else {
    Console.WriteLine($"\n\t'{ocurrencia}' NO esta contenida en '{cadena}'");
}

// Convierta la cadena a mayúsculas y luego a minúsculas.
Console.WriteLine($"\tCadena '{cadena}' en minusculas: {cadena.ToLower()}");
Console.WriteLine($"\tCadena '{cadena}' en mayusculas: {cadena.ToUpper()}");

// Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())
string cadenaSeparada = "esta,es,una,cadena,separada,por,comas";
Console.WriteLine($"\n\tCadena original: {cadenaSeparada}");
string[] cadenaSpliteada = cadenaSeparada.Split(",");
Console.Write("\tRecorro el arreglo luego del split para mostrar los caracteres: ");
foreach(string caracter in cadenaSpliteada) {
    Console.Write(caracter + " ");
}

// Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese por pantalla “582+2” y que le devuelva la suma de 582 con 2
// Se puede variar la operacion colocando "+" "-" "*" o "/" en el string
string operacion = "582*2";

string[] operandos;
int tipoOperacion;
string strTipoOperacion;
if (operacion.Contains("+")) {
    operandos = operacion.Split("+");
    tipoOperacion = 1;
    strTipoOperacion = "suma";
} else if (operacion.Contains("-")) {
    operandos = operacion.Split("-");
    tipoOperacion = 2;
    strTipoOperacion = "resta";
} else if (operacion.Contains("*")) {
    operandos = operacion.Split("*");
    tipoOperacion = 3;
    strTipoOperacion = "producto";
} else {
    operandos = operacion.Split("/");
    tipoOperacion = 4;
    strTipoOperacion = "division";
}

int numA = Convert.ToInt32(operandos[0]);
int numB = Convert.ToInt32(operandos[1]);
int resultado = 0;
switch (tipoOperacion) {
    case 1:
        resultado = numA + numB;
        break;
    case 2:
        resultado = numA - numB;
        break;
    case 3:
        resultado = numA * numB;
        break;
    case 4:
        resultado = numA/numB;
        break;
    default:
        Console.WriteLine("[!] Operacion invalida (no va a pasar porque la pongo en el codigo jeje)");
        break;
}

Console.WriteLine($"\n\n\nEl resultado de la operacion {strTipoOperacion} entre {numA} y {numB} es: {resultado}");
*/

// Ejercicio 5
using System.Text.RegularExpressions;

string patronMails = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
Regex regexMails = new Regex(patronMails);
string mail = "tomato_rivera@yahoo.net";

if (regexMails.IsMatch(mail)) 
    Console.WriteLine($"La cadena {mail} es un mail valido");
else 
    Console.WriteLine($"La cadena {mail} NO es un mail valido");

string patronUrls = "^(https?|ftp):\\/\\/[^\\s\\/$.?#].[^\\s]*$";
Regex regexUrls = new Regex(patronUrls);
string url = "httpswww.google.com";

if (regexUrls.IsMatch(url)) 
    Console.WriteLine($"La cadena {url} es una URL valida");
else 
    Console.WriteLine($"La cadena {url} NO es una URL valida");