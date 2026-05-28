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

char continuar;
double num1;
double num2;

do
{
 Console.WriteLine("Seleccione una opcion:");
 Console.WriteLine("1.Sumar");
 Console.WriteLine("2.Restar");
 Console.WriteLine("3.Multiplicar");
 Console.WriteLine("4.Dividir");
 Console.WriteLine("5.Valor Absoluto");
 Console.WriteLine("6.Cuadrado");
 Console.WriteLine("7.Raiz Cuadrada");
 Console.WriteLine("8.Seno");
 Console.WriteLine("9.Coseno");
 Console.WriteLine("10.Maximo numero");
 Console.WriteLine("11.Minimo numero");
 string opcion=Console.ReadLine(); 
 if(!int.TryParse(opcion, out int opc) || opc<1 || opc > 11)
    {
        Console.WriteLine("Opcion invalida");
    }
    else
    {
        if (opc >= 1 || opc<=4 || opc==10 || opc==11)
        {
            Console.WriteLine("\nIngrese el primer numero: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Error, ingrese un numero: ");
            }
            Console.WriteLine("\nIngrese el segundo numero: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Error, ingrese un numero: ");
            }
        }
        else
        {
            Console.WriteLine("\nIngrese el numero: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Error, ingrese un numero: ");
            } 
            num2=0;
        }
     double resultado = 0;
        switch (opcion)
        {
        case "1":
            resultado= num1 + num2;
            Console.Write("La suma es:");
            Console.WriteLine(resultado);
            break;
        case "2":
            resultado= num1 - num2;
            Console.Write("La resta es:");
            Console.WriteLine(resultado);
            break; 
        case "3":
            resultado= num1 * num2;
            Console.Write("La multiplicacion es:");
            Console.WriteLine(resultado);
            break; 
        case "4":
                if (num2 != 0)
                {
                    resultado=num1/num2;
                    Console.Write("La division es:");
                    Console.WriteLine(resultado);
                }
                else
                {
                    Console.Write("No se puede dividir");
                }
            break;          
        case "5":
            Console.Write("La valor absoluto es:");
            resultado = Math.Abs(num1);
            Console.WriteLine(resultado);
            break;
        case "6":
            Console.Write("El cuadrado es:");
            resultado = Math.Pow(num1,2);
            Console.WriteLine(resultado);
            break;
        case "7":
                if (num1 >= 0)
                {
                   Console.Write("La raiz cuadrada es:");
                   resultado = Math.Sqrt(num1);
                   Console.WriteLine(resultado);
                }
                else
                {
                    Console.WriteLine("No se pueden calcular raices de numeros negativos");
                }
            break;
        case "8":
            Console.Write("El seno es:");
            resultado = Math.Sin(num1);
            Console.WriteLine(resultado);
            break;
        case "9":
            Console.Write("El coseno es:");
            resultado = Math.Cos(num1);
            Console.WriteLine(resultado);
            break;
        case "10":
            Console.Write("El maximo numero es:");
            resultado = Math.Max(num1,num2);
            Console.WriteLine(resultado);
            break;
        case "11":
            Console.Write("El menor numero es:");
            resultado = Math.Min(num1, num2);
            Console.WriteLine(resultado);
            break;                        
        }
    }
    Console.WriteLine("\n¿Desea realizar otro calculo? (s/n): ");
    continuar = char.ToLower(Console.ReadKey().KeyChar);  
}while(continuar == 's');
