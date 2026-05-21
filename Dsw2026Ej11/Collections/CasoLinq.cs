using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> _libros = Libro.CrearLista();
    public Libro GetPrimero() => (from libro in _libros select libro).First();
    public Libro GetUltimo() => (from libro in _libros select libro).Last();
    public decimal GetTotalPrecios() => (from libro in _libros select libro.Precio).Sum();
    public decimal GetPromedioPrecios() => (from libro in _libros select libro.Precio).Average();
    public IEnumerable<Libro> GetListById() => from libro in _libros where libro.Id > 15 select libro;
    public IEnumerable<string> GetLibros() => from libro in _libros select $"{libro.Titulo} {libro.Precio:C}";
    public Libro GetMayorPrecio() => (from libro in _libros orderby libro.Precio descending select libro).First();
    public Libro GetMenorPrecio() => (from libro in _libros orderby libro.Precio select libro).First();
    public IEnumerable<Libro> GetMayorPromedio() { var promedio = GetPromedioPrecios(); return from libro in _libros where libro.Precio > GetPromedioPrecios() select libro; }
    public IEnumerable<Libro> GetOrdenados() => from libro in _libros orderby libro.Titulo descending select libro;
}
