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
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

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
    return a/b;
}

static float operar(int opcion) {
    int numA;
    int numB;
    float resultado = -999;

    Console.Write("\n\t* Ingrese el primer numero: ");
    string strNumeroA = Console.ReadLine();
    Console.Write("\t* Ingrese el segundo numero: ");
    string strNumeroB = Console.ReadLine();

    if (int.TryParse(strNumeroA, out numA) && int.TryParse(strNumeroB, out numB)) {
        
        switch (opcion)
        {
            case 1:
                resultado = sumar(numA, numB);
                break;
            case 2:
                resultado = restar(numA, numB);
                break;
            case 3:
                resultado = multiplicar(numA, numB);
                break;
            case 4:
                if (numB == 0) 
                    Console.WriteLine("[!] No se puede dividir un numero por cero");
                else           
                    resultado = dividir(numA, numB);
                break;

            // No debería llegar aquí por la verificación del main
            // pero por si acaso... Segunda validacion
            default:
                Console.WriteLine("\n[!] Opcion invalida\n");
                break;
        }

    } else {
        Console.WriteLine("\n[!] Debe ingresar numeros reales\n");
    }

    return resultado;
}

int indefinido = -999;
int opcion = 0, numA, numB;

do
{
    Console.WriteLine("====== SELECCIONAR OPERACION ======");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Finalizar operaciones");

    Console.Write("* Ingrese su opcion: ");
    string strOpcion = Console.ReadLine();

    if ( !int.TryParse(strOpcion, out opcion) || (opcion < 1) || (opcion > 5) ) {
        Console.WriteLine("\n[!] Opcion invalida\n");
    } else if (opcion == 5) {
        Console.WriteLine("\n*** Programa finalizado ***\n");
    } else {
        float resultado = operar(opcion);
        if (resultado != indefinido) Console.WriteLine($"\n*** El resultado es: {resultado} ***\n");
    }

} while (opcion != 5);