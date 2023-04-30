using System;
using System.Globalization;

class Persona
{
    private string nombre;
    private string apellido;
    private int edad;
    private double cm;

    public Persona(string nombre, string apellido, int edad, double cm)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.cm = cm;
    }

    public string NombreCompleto()
    {
        return nombre + " " + apellido;
    }

    public double mts()
    {
        return cm / 100;
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Nombre completo: " + NombreCompleto());
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Altura en metros: " + mts());
    }

    static void Main(string[] args)
    {
        Persona persona = new Persona("Sofía", "Asturias", 18, 161.5);
        persona.MostrarDatos();
    }
}