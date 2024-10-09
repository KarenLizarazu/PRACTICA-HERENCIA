using System;
using System.Collections.Generic;
public class Persona
{
    // Atributos comunes
    private string nombre;
    private string apellido;
    private int edad;
    private string identificacion;

    // Constructor
    public Persona(string nombre, string apellido, int edad, string identificacion)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.identificacion = identificacion;
    }

    // Método para mostrar información básica
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"{nombre} {apellido}, {edad} años, Identificación: {identificacion},");
    }
}
public class Estudiante : Persona
{
    // Atributos específicos
    private int matricula;
    private string carrera;

    // Constructor
    public Estudiante(string nombre, string apellido, int edad, string identificacion, int matricula, string carrera)
        : base(nombre, apellido, edad, identificacion)
    {
        this.matricula = matricula;
        this.carrera = carrera;
    }

    // Sobrescribir método para mostrar información del estudiante
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Matricula: {matricula}, Carrera: {carrera}.");
    }    
}
public class Docente : Persona
{
    // Atributos específicos
    private string materia;
    private int anosExperiencia;

    // Constructor
    public Docente(string nombre, string apellido, int edad, string identificacion, string materia, int anosExperiencia)
        : base(nombre, apellido, edad, identificacion)
    {
        this.materia = materia;
        this.anosExperiencia = anosExperiencia;
    }

    // Sobrescribir método para mostrar información del docente
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Materia: {materia}, Anos de experiencia: {anosExperiencia}.");
    }    
}
public class Administrativo : Persona
{
    // Atributos específicos
    private string departamento;
    private string puesto;

    // Constructor
    public Administrativo(string nombre, string apellido, int edad, string identificacion, string departamento, string puesto)
        : base(nombre, apellido, edad, identificacion)
    {
        this.departamento = departamento;
        this.puesto = puesto;
    }

    // Sobrescribir método para mostrar información del administrativo
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Departamento: {departamento}, Puesto: {puesto}.");
    }    
}

class Program
{
    static void Main(string[] args)
    {
        List<Persona> personas = new List<Persona>();

        // Agregar personas a la lista 
        personas.Add(new Estudiante("Karen", "Lizarazu", 29, "5190551", 2020345, "Ingeniería"));
        personas.Add(new Docente("Genaro", "Quelali", 40, "123456", "Lenguaje de Programación", 10 ));
        personas.Add(new Administrativo("Juan", "Pérez", 35, "654321", "Recursos Humanos", "Cajero"));

        // Mostrar información de todas las personas
        Console.WriteLine("INFORMACION DE TODAS LAS PERSONAS:");
        foreach (var persona in personas)
        {
            persona.MostrarInformacion();
        }

        // Mostrar solo estudiantes
        Console.WriteLine("\nINFORMACION DE LOS ESTUDIANTES:");
        foreach (var persona in personas.OfType<Estudiante>())
        {
            persona.MostrarInformacion();
        }

        // Mostrar solo docentes
        Console.WriteLine("\nINFORMACION DE LOS DOCENTES:");
        foreach (var persona in personas.OfType<Docente>())
        {
            persona.MostrarInformacion();
        }

        // Mostrar solo administrativos
        Console.WriteLine("\nINFORMACION DE LOS ADMINISTRATIVOS:");
        foreach (var persona in personas.OfType<Administrativo>())
        {
            persona.MostrarInformacion();
        }
                        
      Console.ReadKey();
   }
}
