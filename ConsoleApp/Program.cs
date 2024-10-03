using System;
using ConsoleApp.Compuestos;


// instanciamos las clases de productos y tipos de productos
Tipos_Productos tipoVegetales = new Tipos_Productos { Id = 1, Cod_tipo = 101, Nom_tipo = "Vegetales" };
Productos tomate = new Productos { Id = 1, Cod_producto = 1001, Nombre_producto = "Tomate", Estado_producto = "Nuevo", Tipo_producto = tipoVegetales };

// creamos un proveedor y una entrega de productos
Proveedores proveedor1 = new Proveedores { Id = 1, Nombre_Proveedor = "Proveedor de Vegetales", Contacto = 123456789 };
Proveedores_Productos entregaTomates = new Proveedores_Productos
{
    Id = 1,
    Proveedor = proveedor1,
    Producto = tomate,
    CantidadProducto = 5, // Aqui proveedor entrega 5 tomates
    FechaEntrega = DateTime.Now
};

// Almacenamos los productos que se ingresaron en el inventario
Inventarios inventario = new Inventarios
{
    Id = 1,
    Producto = tomate,
    Cantidad_afectar = entregaTomates.CantidadProducto, // Ingresar 5 tomates al inventario
    Accion_estado = "Ingresado"
};
Console.WriteLine($"El inventario ahora tiene {inventario.Cantidad_afectar} unidades de {tomate.Nombre_producto}.");

// Creamos un cliente cualquiera
Clientes cliente1 = new Clientes
{
    Id = 1,
    Cedula = "123456789",
    Nombre = "Juan Perez",
    Contacto = 987654321,
    Direccion = "Calle Falsa 123"
};

// Creamos un compuesto/plato que necesite tomates por ejemplo una ensalada
Compuestos ensalada = new Compuestos { Id = 1, Cod_compuesto = 2001, Nombre_composicion = "Ensalada" };

// Creamos la relación entre el compuesto y el producto, cuántos tomates se necesitan para la ensalada
Compuestos_Productos ensaladaTomates = new Compuestos_Productos
{
    Id = 1,
    Compuesto = ensalada,
    Producto = tomate,
    CantidadProductoNecesario = 2 // Se necesitan 2 tomates para la ensalada
};

// Restamos la cantidad usada del inventario para hacer el compuesto/plato
if (inventario.Cantidad_afectar >= ensaladaTomates.CantidadProductoNecesario)
{
    inventario.Cantidad_afectar -= ensaladaTomates.CantidadProductoNecesario;
    Console.WriteLine($"Después de preparar la ensalada, quedan {inventario.Cantidad_afectar} unidades de {tomate.Nombre_producto} en el inventario.");
}
else
{
    Console.WriteLine($"No hay suficientes {tomate.Nombre_producto} en el inventario para preparar la ensalada.");
}

// Crear una orden
Ordenes orden1 = new Ordenes
{
    Id = 1,
    Cliente = cliente1,
    Compuesto = ensalada,
    Fecha_pedido = DateTime.Now,
    Total_pagar = 50, // Precio de la ensalada
    Estado_orden = "Cumplido"
};

// Mostrar detalles de la orden
Console.WriteLine($"Orden creada: {orden1.Compuesto.Nombre_composicion} para el cliente {orden1.Cliente.Nombre}. Total a pagar: {orden1.Total_pagar}.");


