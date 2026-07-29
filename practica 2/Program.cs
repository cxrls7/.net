// ejercicio 1
// Console.WriteLine("Ingresa un numero: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"El numero {numero} es par");
// }
// else
// {
//     Console.WriteLine($"El numero {numero} es impar");
// }

// ejercicio 2

// Console.WriteLine("Ingresa tu nombre: ");
// string nombre = Console.ReadLine();

// if (nombre == "")
// {
//     Console.WriteLine("ERROR: INGRESE UN NOMBRE");
// }
//  else
// {
//     Console.WriteLine($"Hola {nombre}, bienvenido!");
// }

//ejercicio 3

// Console.WriteLine("Ingresa tu edad: ");

// int edad = Convert.ToInt32(Console.ReadLine());

// if (edad >= 18 )
// {
//     Console.WriteLine("Eres mayor de edad");

// }
// else
// {
//     Console.WriteLine("Eres menor de edad");
// }

//Ejercicio 4

// Console.WriteLine("Ingresa un numero, de acuerdo a ese numero te dire el dia de la semana que corresponde a ese numero: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// switch (numero)
// {
//     case 1:
//     Console.WriteLine("El numero 1 corresponde al dia Lunes");
//     break;

//     case 2:
//     Console.WriteLine("El numero 2 corresponde al dia Martes");
//     break;

//     case 3:
//     Console.WriteLine("El numero 3 corresponde al dia Miercoles");
//     break;

//     case 4:
//     Console.WriteLine("El numero 4 corresponde al dia Jueves");
//     break;

//     case 5:
//     Console.WriteLine("El numero 5 corresponde al dia Viernes");
//     break;

//     case 6:
//     Console.WriteLine("El numero 6 corresponde al dia Sabado");
//     break;

//     case 7:
//     Console.WriteLine("El numero 7 corresponde al dia Domingo");
//     break;
        
// }

//Ejercicio 5

// Console.WriteLine("Ingresa tu nacionalidad: ");
// string respuesta = Console.ReadLine();

// string nacionalidad = (respuesta == "colombiana") ? "Eres nativo de Colombia" : "Eres extranjero";

// Console.WriteLine(nacionalidad);

//Ejercicio 6

// Console.WriteLine("Ingresa un numero: ");
// double num1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Ingresa un numero: ");
// double num2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Ingresa un numero: ");
// double num3 = Convert.ToDouble(Console.ReadLine());

// if (num1 >= num2 && num1 >= num3 )
// {
//     Console.WriteLine($"El numero mayor es {num1}");

// }

// else if (num2 >= num1 && num2 >= num3)
// {
//     Console.WriteLine($"El numero mayor es {num2}");
// }

// else
// {
//     Console.WriteLine($"El numero mayor es {num3}");
// }

//ejercicio 7

// Console.WriteLine("Ingresa una contraseña: ");

// string password = Console.ReadLine();

// string respuesta = (password == "") ? "ERROR: La contaseña no puede estar en blanco!" : "Contraseña valida, Bienvenido!";

// Console.WriteLine($"{respuesta}");

//ejercicio 8

// Console.WriteLine("Ingresa un numero del 1 al 12 y te dire a que mes del año pertence: ");

// int numero = Convert.ToInt32(Console.ReadLine());

// switch (numero)
// {
//     case 1:
//     {
//       Console.WriteLine("El numero 1 pertenece a Enero");
//     }
//     break; 

//      case 2:
//     {
//       Console.WriteLine("El numero 2 pertenece a Febrero");
//     }
//     break; 
//      case 3:
//     {
//       Console.WriteLine("El numero 3 pertenece a Marzo");
//     }
//     break; 
//      case 4:
//     {
//       Console.WriteLine("El numero 4 pertenece a Abril");
//     }
//     break; 
//      case 5:
//     {
//       Console.WriteLine("El numero 5 pertenece a Mayo");
//     }
//     break; 
//      case 6:
//     {
//       Console.WriteLine("El numero 6 pertenece a Junio");
//     }
//     break; 
//      case 7:
//     {
//       Console.WriteLine("El numero 7 pertenece a Julio");
//     }
//     break; 
//      case 8:
//     {
//       Console.WriteLine("El numero 8 pertenece a Agosto");
//     }
//     break; 
//      case 9:
//     {
//       Console.WriteLine("El numero 9 pertenece a Septiembre");
//     }
//     break; 
//      case 10:
//     {
//       Console.WriteLine("El numero 10 pertenece a Octubre");
//     }
//     break; 
//      case 11:
//     {
//       Console.WriteLine("El numero 11 pertenece a Noviembre");
//     }
//     break; 
//      case 12:
//     {
//       Console.WriteLine("El numero 12 pertenece a Diciembre");
//     }
//     break; 
     
// }

// ejercicio 9

// Console.Write("Ingresa una calificacion(1-5): ");
// double nota = Convert.ToDouble(Console.ReadLine());

// if (nota >= 1 && nota < 2)
// {
//     Console.WriteLine("Tu nota equivale a una F");
// }
// else if (nota >= 2 && nota < 3)
// {
//     Console.WriteLine("Tu nota equivale a una D");
// }
// else if (nota >= 3 && nota < 4)
// {
//     Console.WriteLine("Tu nota equivale a una C");
// }
// else if (nota >= 4 && nota < 5)
// {
//     Console.WriteLine("Tu nota equivale a una B");
// }

// else
// {
//     Console.WriteLine("Tu nota equivale a una A");
// }

//ejercicio 10

// Console.WriteLine("Ingresa una letra y verificare si es vocal o consonante: ");

// char letra = Convert.ToChar(Console.ReadLine());

// char letraMinuscula = char.ToLower(letra);

// switch (letraMinuscula)
// {   
//     case  'a':
//     case  'e':
//     case  'i':
//     case  'o':
//     case  'u':
//             Console.WriteLine($"La letra {letra} Es una vocal");
//     break;

//     default:
//             Console.WriteLine($"La letra {letra} Es una consonante");
//     break;
        
// }

//ejercicio 11

// Console.Write("Ingresa el primer número: ");
// double num1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Ingresa el segundo número: ");
// double num2 = Convert.ToDouble(Console.ReadLine());

// if (num1 == num2)
// {
//     Console.WriteLine($"Los numeros {num1} y {num2} son iguales");
// }

// else
// {
//     Console.WriteLine($"Los numeros {num1} y {num2} son diferentes");
// }

//ejercicio 12

// Console.WriteLine("Ingresa tu direccion: ");

// string direccion = Console.ReadLine();

// string respuesta = string.IsNullOrWhiteSpace(direccion) ? "ERROR: La direccion no puede estar en blanco!" : "Direccion valida";

// Console.WriteLine($"{respuesta}");

//ejercicio 13

// Console.WriteLine("Ingresa un numero: ");
// double numero = Convert.ToDouble(Console.ReadLine());

// if (numero == 0)
// {
//     Console.WriteLine("El numero es cero");
// }
// else if (numero > 0)
// {
//     Console.WriteLine("El numero es positivo");
// }
// else
// {
//     Console.WriteLine("El numero es negativo");
// }

//ejercicio 14

// Console.WriteLine("Ingresa una letra: ");

// string letra = Console.ReadLine();

// string letraMinuscula = letra.ToLower();

// if (letraMinuscula == "a" || letraMinuscula == "e" || letraMinuscula == "i" || letraMinuscula == "o" || letraMinuscula == "u")
// {
//     Console.WriteLine($"La letra {letra} es una vocal");
// }
// else
// {
//     Console.WriteLine($"La letra {letra} es una consonante");
// }

//Ejercicio 15

// Console.WriteLine("Ingresa una temperatura(en celcius): ");
// double temperatura = Convert.ToDouble(Console.ReadLine());

// if (temperatura >= 30)
// {
//     Console.WriteLine("Hace calor");
// }
// else if (temperatura >= 10 && temperatura < 30)
// {
//     Console.WriteLine("Hace una temperatura templada");
// }
// else if (temperatura >= 10)
// {
//     Console.WriteLine("Hace frio");
// }
// else
// {
//     Console.WriteLine("Hace mucho frio");
// }

//ejercicio 16

// Console.Write("Ingresa un año: ");
//         int año = Convert.ToInt32(Console.ReadLine());

        
//         if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
//         {
//             Console.WriteLine($"El año {año} ES bisiesto.");
//         }
//         else
//         {
//             Console.WriteLine($"El año {año} NO es bisiesto.");
//         }

//ejercicio 17

// Console.WriteLine("Ingresa un valor: ");

// string valor= Console.ReadLine();

// string respuesta = string.IsNullOrWhiteSpace(valor) ? "ERROR: El valor no puede estar en blanco!" : $"Tu valor es {valor}";

// Console.WriteLine($"{respuesta}");

//ejercicio 18

// Console.Write("Ingresa un número del 1 al 7: ");
//         int dia = Convert.ToInt32(Console.ReadLine());

//         switch (dia)
//         {
//             case 1: // Lunes
//             case 2: // Martes
//             case 3: // Miércoles
//             case 4: // Jueves
//             case 5: // Viernes
//                 Console.WriteLine("Es un día LABORABLE.");
//                 break;

//             case 6: // Sábado
//             case 7: // Domingo
//                 Console.WriteLine("Es FIN DE SEMANA.");
//                 break;

//             default:
//                 Console.WriteLine("Número inválido. Debes ingresar un número del 1 al 7.");
//                 break;
//         }


