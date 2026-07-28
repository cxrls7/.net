//Ejercicio 1

// Console.Write("Hola mundo");

//Ejercicio 2

// int number = 77;
// string message = $"El numero es: {number}";

// Console.WriteLine(message);

//Ejercicio 3

// string name = "Carlos";

// Console.WriteLine($"{name.ToUpper()}");
// Console.WriteLine($"{name.ToLower()}");

//Ejercicio 4

// int number1 = 5;
// int number2 = 56;

// Console.WriteLine($"la suma es = {number1 + number2}");
// Console.WriteLine($"la resta es = {number1 - number2}");
// Console.WriteLine($"la multiplicacion es = {number1 * number2}");
// Console.WriteLine($"la division es = {number1 / number2}");

//Ejercicio 5
//  int num1 = 6;
//  int num2 = 23;

// Console.WriteLine($"Son iguales? = {num1 == num2}");
// Console.WriteLine($"Son diferentes? = {num1 != num2}");
// Console.WriteLine($"Num1 es menor que num2? = {num1 < num2}");
// Console.WriteLine($"Num1 es mayor que num2? = {num1 > num2}");

// Ejercicio 6

// string texto = "Vivo en barranquilla";

// string textoNuevo = texto.Replace("barranquilla", "Soledad");

// Console.WriteLine(textoNuevo);

// Ejercicio 7
// Console.Write("Ingresa tu nombre:"); 
// string nombre = Console.ReadLine();

// Console.Write("Ingresa tu edad:");
// string edad = Console.ReadLine();


// Console.WriteLine($"Hola {nombre}, tienes {edad} años.");

// ejercicio 8

// int a = 6;

// if (a<10)
// {
//     Console.WriteLine($"El numero {a} es menor que 10");
// }

// else if (a>10)
// {
//     Console.WriteLine($"El numero {a} es mayor que 10");
// }

// else
// {
//     Console.WriteLine($"El numero {a} es igual a 10");
// }

//ejercicio 9

// double a = 23.23424;
// double b = 3434.345432;

// Console.WriteLine($"la suma es = {a + b}");
// Console.WriteLine($"la resta es = {a - b}");
// Console.WriteLine($"la multiplicacion es = {a * b}");
// Console.WriteLine($"la division es = {a / b}");

//ejercicio 10

// string a = "League of legends";
// string b = "Valorant";

// Console.WriteLine($"{a} y {b} son juegos creados por riot games");

//ejercicio 11


// int a = 5000;

// double b = a;

// Console.WriteLine($"Valor entero: {a}");
// Console.WriteLine($"Valor decimal: {b}");

//ejercicio 12

// Console.Write("Ingresa un numero: ");
// double numero = Convert.ToDouble(Console.ReadLine());

// if  (numero < 0)
// {
    
//     Console.WriteLine($"El numero {numero} es negativo");
// }
// else if (numero > 0)
// {
//     Console.WriteLine($"El numero {numero} es positivo");
// }
// else
// {
//     Console.WriteLine($"El numero {numero} es cero");
// }

//Ejercicio 13

// for (int i = 1; i <= 0; i++)
// {
//     Console.WriteLine($"El numero es: {i}");
// }

// Ejercicio 14 
//  string texto = "     HoLa MuNdO  ";

//  string limpio = texto.Trim();

//  string resultado = char.ToUpper(limpio[0]) + limpio.Substring(1).ToLower();

//  Console.WriteLine($"Antes = {texto}");
//  Console.WriteLine($"Despues = {resultado}");

// Ejercicio 15

// Console.WriteLine("Ingresa un numero: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     int resultado = numero * i ;
//     Console.WriteLine($"{numero} x {i} = {resultado}");
// }

//Ejercicio 16 

// string a = "sett";
// string b = "trindamere";

// string resultado = $"{a} y {b}";

// int longitud1 = a.Length;
// int longitud2 = b.Length;

// Console.WriteLine($"{resultado}");
// Console.WriteLine($"El nombre {a} tiene {longitud1} caracteres");
// Console.WriteLine($"El nombre {b} tiene {longitud2} caracteres");

//Ejercicio 17 

// string a = "Kia Picanto";

// string subcadena = a.Substring(4, 7);

// int longitud = subcadena.Length;

// Console.WriteLine($"La subcadena {subcadena} tiene {longitud} caracteres");