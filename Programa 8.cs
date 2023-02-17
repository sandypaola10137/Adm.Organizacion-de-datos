

// hacer un programa que lea nombre del alumno, nombre de la materia y 4 calificaciones.
//el programa calculara el promedio de la materia y la almacenara en una lista. Esta accion se repetira hasta que el usuario lo desee.

// al finalizar el programa mostrara el promedio de todas las materias.



string a, b,respuesta2;
float cal=0,cal2=0,cal3=0,cal4=0,prom=0;


List<List<string>> lista_promedio=new List<List<string>>();

Console.WriteLine("Deseas agregar a un alumno?");
String respuesta = Console.ReadLine();
while (respuesta!= "no") 

{
    Console.WriteLine("Nombre del alumno");
    a = Console.ReadLine();

    Console.WriteLine("Nombre de la materia");
    b = Console.ReadLine();

    Console.WriteLine("Calificacion 1:");
    cal = (float)Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine(" Calificacion 2:");
    cal2 = (float)Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Calificacion 3:");
    cal3 = (float)Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Calificacion 4:");
    cal4 = (float)Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Deseas agregar a otro alumno?");
    respuesta2 =Convert.ToString(Console.ReadLine());

    if (respuesta2 == "no") {
        break;
    }
    prom = (cal + cal2 + cal3 + cal4) / 4;

    List<string> prom_materias = new List<string>();
    prom_materias.Add(a);
    prom_materias.Add(b);
    prom_materias.Add(prom.ToString());
    lista_promedio.Add(prom_materias);
    lista_promedio.Add(prom_materias);

    Console.WriteLine("El promedio es:{0}", lista_promedio);

};











