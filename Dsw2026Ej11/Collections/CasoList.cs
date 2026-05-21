using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> _alumnos = [];
    public void AddAlumno(Alumno alumno) => _alumnos.Add(alumno);
    public List<Alumno> GetAlumnos() => _alumnos;
    public Alumno? GetAlumno(string nombre) => _alumnos.Find((alumno) => alumno.Nombre == nombre);
    public void RemoveAlumno(Alumno alumno) => _alumnos.Remove(alumno);
    public void RemoveAlumnoEn(int posicion) => _alumnos.RemoveAt(posicion);
}
