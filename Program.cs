
/*hacer un programa que lea un numero, si el numero no es par se volera a pedir.
 * de lo contrario mostrara todos los numeros que hay entre 0 y el.   (no debe ser negativo).*/


using System.Security.Cryptography.X509Certificates;

int a=1;
int x=0;

while ((a %2== 1)||(a<0)) {

   
    Console.WriteLine("Ingresa un dato");
    a=Convert.ToInt32(Console.ReadLine());
   
    if (a % 2 == 0) {
        Console.WriteLine("Los datos son:");
        for (x = 0; x <= a; x++) {
            Console.WriteLine(x);
        }
    
    }
    
}