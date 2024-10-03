using System;

namespace ConsoleApp.Compuestos
{
    public class Clientes
    {
        private int id = 0;
        private string cedula = "";
        private string nombre = "";
        private int contacto = 0;
        private string direccion = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Cedula { get => this.cedula; set => this.cedula = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public int Contacto { get => this.contacto; set => this.contacto = value; }
        public string Direccion { get => this.direccion; set => this.direccion = value; }
    }

    public class Tipos_Productos
    {
        private int id = 0;
        private int cod_tipo = 0;
        private string nom_tipo = "";

        public int Id { get => this.id; set => this.id = value; }
        public int Cod_tipo { get => this.cod_tipo; set => this.cod_tipo = value; }
        public string Nom_tipo { get => this.nom_tipo; set => this.nom_tipo = value; }
    }

    public class Ordenes
    {
        private int id = 0;
        private Clientes? cliente = null;
        private Compuestos? compuesto = null;
        private string estado_orden = "";
        private int total_pagar = 0;
        private DateTime? fecha_pedido = null;

        public int Id { get => this.id; set => this.id = value; }
        public Clientes? Cliente { get => this.cliente; set => this.cliente = value; }
        public Compuestos? Compuesto { get => this.compuesto; set => this.compuesto = value; }
        public DateTime? Fecha_pedido { get => this.fecha_pedido; set => this.fecha_pedido = value; }
        public int Total_pagar { get => this.total_pagar; set => this.total_pagar = value; }
        public string Estado_orden { get => this.estado_orden; set => this.estado_orden = value; }

        public void ValidarEstadoOrden()
        {
            // Este método podría verificar si la orden está "cumplida" o "en espera", 
            // No funcional, falta la logica
        }
        public void GenerarFactura()
        {
            // Este método podría generar una factura para la orden
            //No funcional, falta la logica
        }

    }
    public class Compuestos
    {
        private int id = 0;
        private int cod_compuesto = 0;
        private string nombre_composicion = "";

        public int Id { get => this.id; set => this.id = value; }
        public int Cod_compuesto { get => this.cod_compuesto; set => this.cod_compuesto = value; }
        public string Nombre_composicion { get => this.nombre_composicion; set => this.nombre_composicion = value; }
        
    }
    public class Compuestos_Productos
    {
        private int id = 0;
        private Compuestos? compuesto = null;  // Relación con Compuestos
        private Productos? producto = null;  // Relación con Productos
        private int cantidadProductoNecesario = 0;

        public int Id { get => this.id; set => this.id = value; }
        public Compuestos? Compuesto { get => this.compuesto; set => this.compuesto = value; }  // Referencia a Compuestos
        public Productos? Producto { get => this.producto; set => this.producto = value; }  // Referencia a Productos
        public int CantidadProductoNecesario { get => this.cantidadProductoNecesario; set => this.cantidadProductoNecesario = value; }
    }

    public class Productos
    {
        private int id = 0;
        private Tipos_Productos? tipo_producto = null;
        private int cod_producto = 0;
        private string nombre_producto = "";
        private string estado_producto = "";

        public int Id { get => this.id; set => this.id = value; }
        public Tipos_Productos? Tipo_producto { get => this.tipo_producto; set => this.tipo_producto = value; }
        public int Cod_producto { get => this.cod_producto; set => this.cod_producto = value; }
        public string Nombre_producto { get => this.nombre_producto; set => this.nombre_producto = value; }
        public string Estado_producto { get => this.estado_producto; set => this.estado_producto = value; }

        public void VerificarEstadoProducto()
        {
            // Este método podría verificar si un producto está "viejo" o "nuevo", 
            // no funcional, falta la logica
        }
        public void CalcularPrecioProducto()
        {
            // Este método podría calcular el precio de un producto en especifico,
            // no funcional
        }

    }
    public class Inventarios
    {
        private int id = 0;
        private Productos? producto = null;
        private int cantidad_afectar = 0;
        private string accion_estado = "";

        public int Id { get => this.id; set => this.id = value; }
        public Productos? Producto { get => this.producto; set => this.producto = value; }
        public int Cantidad_afectar { get => this.cantidad_afectar; set => this.cantidad_afectar = value; }
        public string Accion_estado { get => this.accion_estado; set => this.accion_estado = value; }
    }
    public class Proveedores_Productos
    {
        private int id = 0;
        private Proveedores? proveedor = null;  // Relación con Proveedores
        private Productos? producto = null;  // Relación con Productos
        private int cantidadProducto = 0;
        private DateTime? fechaEntrega = null;

        public int Id { get => this.id; set => this.id = value; }
        public Proveedores? Proveedor { get => this.proveedor; set => this.proveedor = value; }  // Referencia a Proveedores
        public Productos? Producto { get => this.producto; set => this.producto = value; }  // Referencia a Productos
        public int CantidadProducto { get => this.cantidadProducto; set => this.cantidadProducto = value; }
        public DateTime? FechaEntrega { get => this.fechaEntrega; set => this.fechaEntrega = value; }
    }
    public class Proveedores
    {
        private int id = 0;
        private string nombre_proveedor = "";
        private int contacto = 0;

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre_Proveedor { get => this.nombre_proveedor; set => this.nombre_proveedor = value; }
        public int Contacto { get => this.contacto; set => this.contacto = value; }
    }
    

    
}
