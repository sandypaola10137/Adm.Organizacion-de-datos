// See https://aka.ms/new-console-template for more information

/* Hacer un programa que lea 3 numeros, si los numeros son iguales se calculara el promedio 
 * de lo contrario se sumara los numeros que son pares e impares entre ellos 
 * y por ultimo muestra el mayor y el menor de ellos.*/

float a, b, c;
Console.WriteLine("Introduce 3 numeros");
a=(float)Convert.ToDecimal(Console.ReadLine());
b=(float)Convert.ToDecimal(Console.ReadLine());
c=(float)Convert.ToDecimal(Console.ReadLine());

if ((a == b) && (a == c) && (b == a) && (b == c) && (c == a) && (c == b))
{

    Console.WriteLine("Promedio: {0}", (a + b + c) / 3);
}

if ((a % 2 == 0) && (b % 2 == 0))
{
    Console.WriteLine("Son numeros pares, la suma es:{0}", a + b);
}
if ((b % 2 == 0) && (c % 2 == 0))
{
    Console.WriteLine("Son numeros pares, la suma es:{0}", b + c);
}
if ((c % 2 == 0) && (a % 2 == 0))
{
    Console.WriteLine("Son numeros pares, la suma es:{0}", c + a);
}


if ((a % 2 == 0) && (b % 2 == 0) && (c % 2 == 0)) {
    Console.WriteLine("Los tres numeros son iguales, la suma es:{0}", a + b + c);
}




if ((a % 2 == 1) && (b % 2 == 1)) {
    Console.WriteLine("Son numeros impares, la suma es:{0}", a + b);

}
if ((b % 2 == 1) && (c % 2 == 1)) {
    Console.WriteLine("Son numeros impares, la suma es: {0}", b + c);
}
if ((c % 2 == 1) && (a % 2 == 1)) {
    Console.WriteLine("Son numeros impares, la suma es:{0}", c + a);
}
if ((a % 2 == 1) && (b % 2 == 1) && (c % 2 == 1)) {
    Console.WriteLine("Todos los numeros son impares, la suma es:{0}", a + b + c);
}

if ((a < b) && (a < c))
{
    Console.WriteLine("El menor es:{0}", a);
}
else if ((b < c) && (b < a))
{
    Console.WriteLine("El menor es:{0}", b);
}
else if ((c < a) && (c < b)) {
    Console.WriteLine("El menor es:{}0", c);
}

if ((a > b) && (a > c)) { 
    Console.WriteLine("El mayor es:{0}",a);
}
else if ((b > a) && (b > c))
{
    Console.WriteLine("El mayor es:{0}", b);

}
else if ((c > a) && (c > b))
{
    Console.WriteLine("El mayor es:{0}", c);
}

if ((a == b) && (a == c) && (b == c) && (b == a) && (c == b) && (c == a))
{
    Console.WriteLine("Ninguno es mayor o menor");
}