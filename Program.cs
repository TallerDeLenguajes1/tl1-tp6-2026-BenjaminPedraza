using System.ComponentModel.Design;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

int invertido=0;
Console.WriteLine("Ingrese el numero:");
string num = Console.ReadLine();
if (int.TryParse(num, out int numero))
{
    while(numero > 0)
    {
        int ultDig = numero % 10;
        invertido = (invertido*10) + ultDig;
        numero = numero / 10;  
    }
    Console.WriteLine(invertido);
}
else
{
    Console.WriteLine("No es un numero valido");
}

Console.WriteLine("Ingrese una cadena de texto:");
string cadena1=Console.ReadLine();
Console.WriteLine("\nLa longitud de la cadena es:"+ cadena1.Length);

Console.WriteLine("\nIngrese una segunda cadena:");
string cadena2=Console.ReadLine();
string concatenada=cadena1 + "" + cadena2;

Console.WriteLine("Cadena concatenada:");
Console.WriteLine(concatenada);

Console.WriteLine("\nIngrese la posicion inicial de la subcadena:");
int inicio = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de caracteres:");
int cantidad= int.Parse(Console.ReadLine());

string subcadena = cadena1.Substring(inicio,cantidad);
Console.WriteLine("Subcadena extraida:" + subcadena);

Console.WriteLine("\nIngrese el primer numero:");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero:");
double num2 = double.Parse(Console.ReadLine());

        double suma = num1 + num2;
        double resta = num1 - num2;
        double multiplicacion = num1 * num2;
        double division = num1 / num2;
        string numero1 = num1.ToString();
        string numero2 = num2.ToString();

        Console.WriteLine("\nLa suma de " + numero1 +
                          " y de " + numero2 +
                          " es igual a: " + suma);

        Console.WriteLine("La resta de " + numero1 +
                          " y de " + numero2 +
                          " es igual a: " + resta);

        Console.WriteLine("La multiplicacion de " + numero1 +
                          " y de " + numero2 +
                          " es igual a: " + multiplicacion);

        Console.WriteLine("La division de " + numero1 +
                          " y de " + numero2 +
                          " es igual a: " + division);

Console.WriteLine("\nRecorrido de la cadena:");

    foreach (char letra in cadena1)
    {
        Console.WriteLine(letra);
    }      
 Console.WriteLine("\nIngrese una palabra para buscar:");
        string palabra = Console.ReadLine();

        if (cadena1.Contains(palabra))
        {
            Console.WriteLine("La palabra SI se encuentra en la cadena.");
        }
        else
        {
            Console.WriteLine("La palabra NO se encuentra en la cadena.");
        }
 Console.WriteLine("\nCadena en mayusculas:");
        Console.WriteLine(cadena1.ToUpper());

        Console.WriteLine("\nCadena en minusculas:");
        Console.WriteLine(cadena1.ToLower());

Console.WriteLine("\nIngrese palabras separadas por coma:");
        string textoSplit = Console.ReadLine();

        string[] partes = textoSplit.Split(',');

        Console.WriteLine("\nElementos separados:");

        foreach (string parte in partes)
        {
            Console.WriteLine(parte);
        }
Console.WriteLine("\nIngrese una ecuacion simple:"); 
string ecuacion= Console.ReadLine();
char operacion=' ';
double resultado=0;
if (ecuacion.Contains("+"))
{
    operacion='+';
}else if(ecuacion.Contains("-"))
{
    operacion='-';
}else if (ecuacion.Contains("*"))
{
    operacion='*';
}else if (ecuacion.Contains("/"))
{
    operacion = '/';
}      
string[] numeros = ecuacion.Split(operacion);
double c = double.Parse(numeros[0]);
double d = double.Parse(numeros[1]);

switch (operacion)
        {
            case '+':
                resultado = c + d;
                break;

            case '-':
                resultado = c - d;
                break;

            case '*':
                resultado = c * d;
                break;

            case '/':
                resultado = c / d;
                break;
        }

        Console.WriteLine("Resultado: " + resultado);
    