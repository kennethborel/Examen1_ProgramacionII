using System;
using System.Collections.Generic;
using System.Linq;

class Empleado
{
    private string cedula;
    private string nombre;
    private string direccion;
    private string telefono;
    private double salario;

    public void PedirCedula()
    {
        Console.Write("Ingrese la cédula: ");
        cedula = Console.ReadLine();
    }

    public void PedirNombre()
    {
        Console.Write("Ingrese el nombre: ");
        nombre = Console.ReadLine();
    }

    public void PedirDireccion()
    {
        Console.Write("Ingrese la dirección: ");
        direccion = Console.ReadLine();
    }

    public void PedirTelefono()
    {
        Console.Write("Ingrese el teléfono: ");
        telefono = Console.ReadLine();
    }

    public void PedirSalario()
    {
        Console.Write("Ingrese el salario: ");
        salario = double.Parse(Console.ReadLine());
    }

    public void MostrarEmpleado()
    {
        Console.WriteLine($"Cédula: {cedula}, Nombre: {nombre}, Dirección: {direccion}, Teléfono: {telefono}, Salario: {salario}");
    }
}



