using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var cList = new CasoList();

        var alumnos = new Alumno[]{ new(1, "Jorge", 7), new(2, "Luis", 8), new(3, "Pedro", 4) };
        var nombreExistente = alumnos[1].Nombre;
        var nombreInexistente = "Pepe";

        Console.WriteLine("Caso List\nAlumnos:");
        foreach(var alumno in alumnos)
        {
            cList.AddAlumno(alumno);
            Console.WriteLine(alumno.ToString());
        }

        Console.WriteLine($"\nBuscando por nombre: {nombreExistente}\n");
        Console.WriteLine(cList.GetAlumno(nombreExistente));

        Console.WriteLine($"\nBuscando por nombre: {nombreInexistente}\n");
        Console.WriteLine(cList.GetAlumno(nombreInexistente)?.ToString() ?? "No Existe");

        Console.WriteLine($"\nEliminando alumno: {alumnos[1]}\n");
        cList.RemoveAlumno(alumnos[1]);

        Helper.Listar(cList.GetAlumnos());

        Console.WriteLine($"\nEliminando alumno: {cList.GetAlumnos()[0]}\n");
        cList.RemoveAlumnoEn(0);

        Helper.Listar(cList.GetAlumnos());
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var cDictionary = new CasoDictionary();

        var alumnos = new (int, Alumno)[]{ (1, new(1, "Jorge", 7)), (2, new(2, "Luis", 8)), (3, new(3, "Pedro", 4)) };
        var legajoExistente = alumnos[1].Item1;
        var legajoInexistente = 4;

        Console.WriteLine("Caso Dictionary\nAlumnos:");
        foreach(var (legajo,alumno) in alumnos)
        {
            cDictionary.AddAlumno(legajo, alumno);
            Console.WriteLine($"Legajo {legajo} | {alumno}");
        }

        Console.WriteLine($"\nBuscando por clave: {legajoExistente}\n");
        Console.WriteLine(cDictionary.GetAlumno(legajoExistente));

        Console.WriteLine($"\nBuscando por clave: {legajoInexistente}\n");
        Console.WriteLine(cDictionary.GetAlumno(legajoInexistente)?.ToString() ?? "No existe");

        Console.WriteLine($"\nEliminando alumno: {cDictionary.GetAlumnos()[legajoExistente]}\n");
        cDictionary.RemoveAlumno(legajoExistente);

        Helper.Listar(cDictionary.GetAlumnos());
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var cLinq = new CasoLinq();

        Console.WriteLine("Caso LINQ\n");

        Console.WriteLine($"\nPrimer Libro: {cLinq.GetPrimero()}\n");
        Console.WriteLine($"\nUltimo Libro: {cLinq.GetUltimo()}\n");
        Console.WriteLine($"\nSuma de precios: {cLinq.GetTotalPrecios():C}\n");
        Console.WriteLine($"\nPromedio de precios: {cLinq.GetPromedioPrecios():C}\n");
        Console.WriteLine($"\nLibros con id mayor a 15: \n");
        Helper.Listar(cLinq.GetListById());
        Console.WriteLine($"\nLibros con formato: \n");
        Helper.Listar(cLinq.GetLibros());
        Console.WriteLine($"\nLibro con precio mas alto: {cLinq.GetMayorPrecio()}\n");
        Console.WriteLine($"\nLibro con precio mas bajo: {cLinq.GetMenorPrecio()}\n");
        Console.WriteLine($"\nLibros con precio mayor al promedio: \n");
        Helper.Listar(cLinq.GetMayorPromedio());
        Console.WriteLine($"\nLibros ordenados de manera descendente: \n");
        Helper.Listar(cLinq.GetOrdenados());
    }
}
