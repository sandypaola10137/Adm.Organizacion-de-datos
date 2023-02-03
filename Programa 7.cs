// See https://aka.ms/new-console-template for more information


//hacer un  programa que lea nombre ,cantidad y precio de 5 productos, el programa mostrara al finalizar el porcenntaje de IVA y
//el total a pagar
float IVA = 0; 
int cantidad;
string nombre;
float precio, tiva=0;
float total = 0;
float contador = 0;
for (int i = 0; i <= 1; i++)
{
    Console.WriteLine(" Ingresa el nombre del producto-->");
    nombre = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Ingresa la cantidad de producto que deseas--->");
    cantidad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingresa el precio");
    precio = (float)Convert.ToDecimal(Console.ReadLine());
    total = cantidad * precio ;
    contador= contador+ total ;
    IVA = (float)(contador * .16);
    tiva = contador + IVA;
    
}



Console.WriteLine("Total a pagar --> {0}", contador);
Console.WriteLine("IVA:   {0}", IVA);
Console.WriteLine("Total con IVA:  {0}", tiva);