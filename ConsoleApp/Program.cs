using System;
using ConsoleApp.Compuestos;

// Crear un cliente usando propiedades (getters y setters)
Clientes cliente = new Clientes
{
    Id = 1,
    Cedula = "123456789",
    Nombre = "Juan Pérez",
    Contacto = 987654321,
    Direccion = "Calle Falsa 123"
};

// Crear un proveedor usando propiedades
Proveedores proveedor = new Proveedores
{
    Id = 1,
    Nombre_Proveedor = "Frutas y Verduras S.A.",
    Contacto = 123456789
};

// Crear un tipo de producto
Tipos_Productos tipoProducto = new Tipos_Productos
{
    Id = 1,
    Cod_tipo = 100,
    Nom_tipo = "Frutas"
};

// Crear un producto usando propiedades
Productos producto = new Productos
{
    Id = 1,
    Cod_producto = 101,
    Nombre_producto = "Manzana",
    Estado_producto = "Nuevo",
    Tipo_producto = tipoProducto
};

// Crear un compuesto (plato)
Compuestos compuesto = new Compuestos
{
    Id = 1,
    Cod_compuesto = 123,
    Nombre_composicion = "Ensalada de Frutas"
};

// Crear una orden usando propiedades
Ordenes orden = new Ordenes
{
    Id = 1,
    Cliente = cliente,
    Compuesto = compuesto,
    Estado_orden = "En espera",
    Total_pagar = 120,
    Fecha_pedido = DateTime.Now
};

// Crear una relación de proveedores-productos usando propiedades
Proveedores_Productos provProd = new Proveedores_Productos
{
    Id = 1,
    Proveedor = proveedor,
    Producto = producto,
    CantidadProducto = 100,
    FechaEntrega = DateTime.Now
};

// Mostrar la información usando getters
Console.WriteLine($"Cliente: {cliente.Nombre}, Cedula: {cliente.Cedula}, Direccion: {cliente.Direccion}");
Console.WriteLine($"Proveedor: {proveedor.Nombre_Proveedor}, Contacto: {proveedor.Contacto}");
Console.WriteLine($"Producto: {producto.Nombre_producto}, Tipo: {producto.Tipo_producto.Nom_tipo}, Estado: {producto.Estado_producto}");
Console.WriteLine($"Compuesto: {compuesto.Nombre_composicion}");
Console.WriteLine($"Orden: Estado = {orden.Estado_orden}, Total a Pagar = ${orden.Total_pagar}");
Console.WriteLine($"Proveedor del Producto: {provProd.Proveedor.Nombre_Proveedor}, Producto: {provProd.Producto.Nombre_producto}, Cantidad: {provProd.CantidadProducto}");


