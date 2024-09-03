// See https://aka.ms/new-console-template for more information
using ConsoleApp.Compuestos;

Clientes clientes= new Clientes
{
    Id = 1,
    Cedula = "123456789",
    Nombre = "Juan Pérez",
    Contacto = 987654321,
    Direccion = "Calle Falsa 123",
};
Console.WriteLine($"Cliente: {clientes.Nombre}");
Console.WriteLine("Hello, World!");


