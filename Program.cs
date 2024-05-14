// Punto 7

/*
Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/

// Ejercicio 1

/*
Console.Write("Ingrese un numero: ");
string strNumero = Console.ReadLine();
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

/**
 * Función que muestra un numero invertido
 */
/*
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

// Ejercicio 2
static float sumar(int a, int b) {
    return a + b;
}
static float restar(int a, int b) {
    return a - b;
}
static float multiplicar(int a, int b) {
    return a * b;
}
static float dividir(int a, int b) {
    if (b == 0)
    {
        return -999999;
    }
    return a/b;
}

int opcion = 0;
do
{
    Console.WriteLine("====== SELECCIONAR OPERACION ======");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Finalizar operaciones");
} while (opcion == 5);