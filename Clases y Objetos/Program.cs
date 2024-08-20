using System;

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void MostrarInfo()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad: " + Edad);
    }
}

class Program
{
    static void Main()
    {
        Persona persona1 = new Persona();
        persona1.Nombre = "Juan";
        persona1.Edad = 30;
        persona1.MostrarInfo();

        Persona persona2 = new Persona();
        persona2.Nombre = "María";
        persona2.Edad = 25;
        persona2.MostrarInfo();
    }
}
