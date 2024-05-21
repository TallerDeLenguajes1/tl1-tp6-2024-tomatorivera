# Respuestas Ejercicio 4

## ¿String es una tipo por valor o un tipo por referencia?
En C# los tipo Strings (cadenas) son objetos y tipos de referencia

## ¿Qué secuencias de escape tiene el tipo string?
Secuencias de escape del tipo String:
* \' - Comilla simple
* \" - Comilla doble
* \  - Barra diagonal inversa
* \0 - Null
* \a - Alerta
* \b - Retroceso
* \f - Avance de página
* \n - Nueva linea
* \r - Retorno de carro (no sé qué significa)
* \t - Tabulación horizontal
* \v - Tabulación vertical
* \u - Secuencia de escape unicode UTF-16
* \U - Secuencia de escape unicode UTF-32
* \x - Secuencia de escape unicode similar a \u pero con longitud variable

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Cuando utilizamos '$' antes de una cadena podemos incluir variables en los String mediante {} sin necesidad de concatenar con otros caracteres como '+' y ','.
Por otro lado cuando utilizamos '@' estamos escribiendo lo que se llama 'una cadena literal', en estas cadenas literales todo se escribe como tal, no se procesan secuencias de escape y se permiten múltiples líneas.

# Respuestas Ejercicio 5 

## Qué son las expresiones regulares
Las expresiones regulares (regex) son patrones de búsqueda y manipulación de texto que sirven para identificar secuencias de caracteres específicas dentro de una cadena.

## ¿Funcionan únicamente en C#?
No, funcionan en todos los lenguajes de programación modernos como Java, Python, Kotlin, PHP, etc (en C no tiene soporte nativo, te odio C, te odio Dennis Ritchie!)

## ¿En qué casos le parecen útiles? Enuncie al menos 3.
Algunos casos donde puede resultar útil expresiones regulares:
* Verificar si una cadena es una URL (tiene www., termina en .com o .net o .org, etc)
* Verificar si una cadena es un email (tiene @, termina en 'algo.com', etc)
* Verificar si una cadena tiene solo dígitos del 0 al 9

## Como se hace uso de las regex en C#
En C# se implementan mediante el objeto 'Regex', el cual se instancia y recibe como parámetro de su método constructor el patron de regex, por ejemplo:

```
// Este patron valida si una cadena tiene solo digitos del 0 al 9
string pattern = @"^[0-9]+$";

// Cadena de entrada para validar
string input = "1234567890";

// Creo un objeto Regex y le mando el patron anterior
Regex regex = new Regex(pattern);
```

A continuación debemos llamar al método ```IsMatch(string input)``` del objeto regex para validar si la cadena 'input' definida anteriormente cumple con dicha expresión regular:

```
// El método 'isMatch(str)' devuelve TRUE si el input coincide con la expresión regular y FALSE en caso contrario
if (regex.IsMatch(input))
{
    Console.WriteLine("La cadena contiene solo dígitos del 0 al 9.");
}
else
{
    Console.WriteLine("La cadena NO contiene solo dígitos del 0 al 9.");
}
```