// Ejercicio 3
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

static float sumar(float a, float b) {
    return a + b;
}
static float restar(float a, float b) {
    return a - b;
}
static float multiplicar(float a, float b) {
    return a * b;
}
static float dividir(float a, float b) {
    return a/b;
}
static float valorAbsoluto(float num) {
    return Math.Abs(num);
}
static double cuadrado(float num) {
    return Math.Pow(num, 2);
}
static double raizCuadrada(float num) {
    return Math.Sqrt(num);
}
static double seno(float num) {
    return Math.Sin(num);
}
static double coseno(float num) {
    return Math.Cos(num);
}
static int parteEntera(float num) {
    return Convert.ToInt32(num);
}
static float maximo(float numA, float numB) {
    return Math.Max(numA, numB);
}
static float minimo(float numA, float numB) {
    return Math.Min(numA, numB);
}

static float operar(int opcion) {
    float numA;
    float numB;
    float resultado = -999;

    Console.Write("\n\t* Ingrese el primer numero: ");
    string strNumeroA = Console.ReadLine();

    string strNumeroB = "0"; // Lo inicializo en 0 para que pase la validacion en caso de no necesitar un segundo numero

    // Si para una operacion no necesito dos numeros, no lo solicitare
    if (opcion < 7) {
        Console.Write("\t* Ingrese el segundo numero: ");
        strNumeroB = Console.ReadLine(); 
    } 

    if (float.TryParse(strNumeroA, out numA) && float.TryParse(strNumeroB, out numB)) {
        
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
            case 5:
                resultado = maximo(numA, numB);
                break;
            case 6:
                resultado = minimo(numA, numB);
                break;
            case 7:
                resultado = valorAbsoluto(numA);
                break;
            case 8:
                resultado = (float) cuadrado(numA);
                break;
            case 9:
                resultado = (float) raizCuadrada(numA);
                break;
            case 10:
                resultado = (float) seno(numA);
                break;
            case 11:
                resultado = (float) coseno(numA);
                break;
            case 12:
                resultado = parteEntera(numA);
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
int opcionSalir = 13;

do
{
    Console.WriteLine("====== SELECCIONAR OPERACION ======");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Maximo entre dos numeros");
    Console.WriteLine("6. Minimo entre dos numeros");
    Console.WriteLine("7. Valor absoluto");
    Console.WriteLine("8. Cuadrado");
    Console.WriteLine("9. Raíz cuadrada");
    Console.WriteLine("10. Seno");
    Console.WriteLine("11. Coseno");
    Console.WriteLine("12. Parte entera de un decimal");
    Console.WriteLine("13. Finalizar operaciones");

    Console.Write("* Ingrese su opcion: ");
    string strOpcion = Console.ReadLine();

    if ( !int.TryParse(strOpcion, out opcion) || (opcion < 1) || (opcion > opcionSalir) ) {
        Console.WriteLine("\n[!] Opcion invalida\n");
    } else if (opcion == opcionSalir) {
        Console.WriteLine("\n*** Programa finalizado ***\n");
    } else {
        float resultado = operar(opcion);
        if (resultado != indefinido) Console.WriteLine($"\n*** El resultado es: {resultado} ***\n");
    }

} while (opcion != opcionSalir);