namespace Dsw2026Ej11.Collections;

public static class Helper
{
    public static void Listar<T>(IEnumerable<T> array)
    {
        foreach(var element in array)
        {
            Console.WriteLine(element);
        }
    }

    public static void Listar<T, U>(IDictionary<T, U> array)
    {
        foreach(var element in array)
        {
            Console.WriteLine($"{element.Key} | {element.Value}");
        }
    }
}
