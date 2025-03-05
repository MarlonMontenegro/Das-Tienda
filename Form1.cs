using Das_Tienda.Models;
using Das_Tienda.Servicios;
using Das_Tienda.Utils;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Das_Tienda
{
    public partial class Form1 : Form
    {

        InputValidator validator = new InputValidator();
        private GestorClientes gestorCli = new GestorClientes();
        Inventario inventario = new Inventario();
        private List<Producto> carrito = new List<Producto>();  // Lista temporal para almacenar productos en el carrito
        GestorVenta gestorVenta = new GestorVenta();

        public Form1()
        {
            InitializeComponent();

        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string Nombre = tbNombreCli.Text;
            string Direccion = tbDirecccionCli.Text;
            string Telefono = TbTelefonoCli.Text;
            int NumeroTel;

            // Validaciones
            if (!validator.EsTextoValido(Nombre))
            {
                MessageBox.Show("El campo Nombre no debe estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombreCli.Focus();
                return;
            }

            if (!validator.EsTextoValido(Direccion))
            {
                MessageBox.Show("El campo Dirección no debe estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDirecccionCli.Focus();
                return;
            }

            if (!validator.EsTextoValido(Telefono))
            {
                MessageBox.Show("El campo Teléfono no debe estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbTelefonoCli.Focus();
                return;
            }

            if (!validator.EsNumeroPositivo(Telefono, out NumeroTel))
            {
                MessageBox.Show("El campo Teléfono debe ser un número positivo sin caracteres especiales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbTelefonoCli.Focus();
                return;
            }

            // Crear un cliente y agregarlo al gestor
            Cliente cliente = new Cliente(Nombre, Direccion, NumeroTel);
            gestorCli.AgregarCliente(cliente);

            // Limpiar los campos de texto
            tbNombreCli.Clear();
            tbDirecccionCli.Clear();
            TbTelefonoCli.Clear();

            // Actualizar la vista del ListBox
            ActualizarListBox();
            CargarClientes();

        }
        private void ActualizarListBox()
        {
            ListBClientes.Items.Clear();

            // Recorrer la lista de clientes y agregarlos al ListBox
            foreach (var cliente in gestorCli.ListadoClientes)
            {
                ListBClientes.Items.Add($"ID: {cliente.Id} - Nombre: {cliente.Nombre} - Tel: {cliente.Telefono} - Direccion {cliente.Direccion}");
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            string NombreProd = tbNombreProd.Text;
            string Categoria = GetCategoria(CbCategoria.SelectedIndex);
            string Precio = tbPrecioProd.Text;
            string Stock = tbCantidadProd.Text;


            decimal PrecioVerificado;
            int StockVerificado;

            // Validaciones

            if (!validator.EsTextoValido(NombreProd))
            {
                MessageBox.Show("El campo Nombre no debe estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombreProd.Focus();
                return;
            }

            if (!validator.EsTextoValido(Categoria))
            {
                MessageBox.Show("El campo Categoria no debe estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CbCategoria.Focus();
                return;
            }

            if (!validator.EsTextoValido(Precio))
            {
                MessageBox.Show("El campo Precio no debe estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPrecioProd.Focus();
                return;
            }

            if (!validator.EsTextoValido(Stock))
            {
                MessageBox.Show("El campo Stock no debe estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPrecioProd.Focus();
                return;
            }

            if (!validator.EsNumeroPositivoDecimal(Precio, out PrecioVerificado))
            {
                MessageBox.Show("El campo Precio debe ser un número positivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbTelefonoCli.Focus();
                return;
            }

            if (!validator.EsNumeroPositivo(Stock, out StockVerificado))
            {
                MessageBox.Show("El campo Cantidad debe ser un número positivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbTelefonoCli.Focus();
                return;
            }

            // Crear Producto

            Producto producto = new Producto(NombreProd,Categoria,PrecioVerificado, StockVerificado);

            inventario.AgregarInventario(Categoria, producto);

            CargarInventarioEnListBox(listBoxProductos);

            tbNombreProd.Clear();
            tbCantidadProd.Clear(); 
            tbPrecioProd.Clear();
        }
        public void CargarInventarioEnListBox(ListBox listBox)
        {
            listBox.Items.Clear();

            // Obtener los productos como lista de cadenas
            string[] productos = inventario.ObtenerProductosParaMostrar();

            // Agregar los productos al ListBox
            foreach (var producto in productos)
            {
                listBox.Items.Add(producto);
            }
        }
        public void CargarProductosEnListBox(ListBox listBox)
        {
            // Limpiar el ListBox antes de cargar nuevos datos
            listBox.Items.Clear();

            // Obtener los productos como lista de cadenas
            string[] productos = inventario.ObtenerSoloProductos();

            // Agregar los productos al ListBox
            foreach (var producto in productos)
            {
                listBox.Items.Add(producto);
            }
        }
        public  void CargarClientes()
        {
            List<Cliente> listclientes = gestorCli.ListadoClientes;
            List<string> Nombres = new List<string>();

            foreach (var clientes in listclientes)
            {
                Nombres.Add(clientes.Nombre);
            }


            cbClientesVenta.DataSource = Nombres;
        }
        private static string GetCategoria(int indice)
        {
            if (indice == 0) { return "Alimentos"; }
            if (indice == 1) { return "Bebidas"; }
            if (indice == 2) { return "Electricidad"; }
            if (indice == 3) { return "Accesorios"; }
            if (indice == 4) { return "Ropa"; }

            return "Sin Categoria";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string textoSeleccionado = cbClientesVenta.SelectedItem.ToString();
            CargarProductosEnListBox(listBoxProductosVenta);

        }
        private void listBoxProductosVenta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProductoSeleccionado.Visible = true;
            CantidadLabel.Visible = true;
            tbCantidadVenta.Visible = true;
            btnAgregar.Visible = true;

            string seleccion = listBoxProductosVenta.SelectedItem.ToString().ToLower();
            ProductoSeleccionado.Text = $"Producto Selecinado: {seleccion}";

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que un cliente haya sido seleccionado
            if (cbClientesVenta.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente cliente = gestorCli.BuscarClientePorNombre(cbClientesVenta.SelectedItem.ToString());

            // Validar que un producto haya sido seleccionado
            if (listBoxProductosVenta.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreProducto = listBoxProductosVenta.SelectedItem.ToString();

            // Buscar el producto en el inventario
            Producto productoEnInventario = inventario.BuscarProductoPorNombre(nombreProducto);

            if (productoEnInventario == null)
            {
                MessageBox.Show("El producto seleccionado no existe en el inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que la cantidad ingresada sea válida
            if (!int.TryParse(tbCantidadVenta.Text, out int cantidadVenta) || cantidadVenta <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida para la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar si ya está en el carrito para sumar la cantidad
            Producto productoCarrito = carrito.FirstOrDefault(p => p.Nombre == productoEnInventario.Nombre);

            if (productoCarrito != null)
            {
                productoCarrito.Cantidad += cantidadVenta; // Si ya está, solo sumamos la cantidad
            }
            else
            {
                carrito.Add(new Producto(productoEnInventario.Nombre, productoEnInventario.Categoria, productoEnInventario.Precio, cantidadVenta));
            }

            // Actualizar el ListBox del carrito
            ActualizarListCarrito();

            // Limpiar campo de cantidad
            tbCantidadVenta.Clear();
        }
        private void ActualizarListCarrito()
        {
            listCarrito.Items.Clear(); // Limpiar antes de actualizar

            foreach (var producto in carrito)
            {
                listCarrito.Items.Add($"{producto.Nombre} - {producto.Cantidad} unidades - ${producto.Precio * producto.Cantidad}");
            }
        }
        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            // Validar que haya productos en el carrito
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agregue productos antes de realizar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbClientesVenta.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente cliente = gestorCli.BuscarClientePorNombre(cbClientesVenta.SelectedItem.ToString());

            Venta venta = new Venta(cliente);

            decimal totalVenta = 0;

            foreach (Producto productoCarrito in carrito)
            {
                Producto productoInventario = inventario.BuscarProductoPorNombre(productoCarrito.Nombre);

                if (productoInventario == null || productoInventario.Cantidad < productoCarrito.Cantidad)
                {
                    MessageBox.Show($"No hay suficiente stock de {productoCarrito.Nombre}. La venta no se puede realizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                productoInventario.Cantidad -= productoCarrito.Cantidad;

                venta.AgregarProducto(productoCarrito);

                totalVenta += productoCarrito.Cantidad * productoCarrito.Precio;
            }

            gestorVenta.AgregarVentas(venta.ID, venta);

            // Mostrar confirmación de la venta
            MessageBox.Show($"Venta realizada con éxito.\nCliente: {cliente.Nombre}\nTotal: ${totalVenta}",
                            "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            carrito.Clear();
            listCarrito.Items.Clear();
            llenarHistorialVentas();

            // Actualizar la vista del inventario en `listBoxProductosVenta`
            CargarProductosEnListBox(listBoxProductosVenta);
            CargarInventarioEnListBox(listBoxProductos);
        }
        private void llenarHistorialVentas()
        {
            listHistorial.Items.Clear();

            foreach (var venta in gestorVenta.Ventas)
            {
                string clienteNombre = venta.Value.cliente.Nombre;
                decimal totalVenta = venta.Value.Total(); 

                // Convertir lista de productos en una sola línea
                string productosVendidos = venta.Value.Productos.Any()
                    ? string.Join(", ", venta.Value.Productos.Select(p => $"{p.Nombre} ({p.Cantidad} unidades - ${p.Precio * p.Cantidad})"))
                    : "Ningún producto";

            
                listHistorial.Items.Add($"{venta.Key} - Cliente: {clienteNombre} - Productos: {productosVendidos} - 🔹 Total: ${totalVenta}");
            }
        }
        private void BtnEliminarVentaHis_Click(object sender, EventArgs e)
        {
            string idHistorial = tbIdHistorial.Text;
            int id;

            // Validar que el campo no esté vacío
            if (!validator.EsTextoValido(idHistorial))
            {
                MessageBox.Show("El campo Id no debe estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbIdHistorial.Focus();
                return;
            }

            // Validar que el ID ingresado sea un número positivo
            if (!validator.EsNumeroPositivo(idHistorial, out id))
            {
                MessageBox.Show("El campo Id debe ser un número positivo sin caracteres especiales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbIdHistorial.Focus();
                return;
            }

            // Buscar la venta en el historial
            Venta VentaSeleccionada = gestorVenta.BuscarVentaPorId(id);

            if (VentaSeleccionada == null)
            {
                MessageBox.Show("Venta no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Reabastecer el inventario antes de eliminar la venta
            foreach (Producto producto in VentaSeleccionada.Productos)
            {
                Producto productoInventario = inventario.BuscarProductoPorNombre(producto.Nombre);

                if (productoInventario != null)
                {
                    productoInventario.Cantidad += producto.Cantidad; // ✅ Se devuelve la cantidad al stock
                }
            }

            // Eliminar la venta del historial
            gestorVenta.EliminarVenta(id);

            // Actualizar la vista del historial y el inventario
            llenarHistorialVentas();
            CargarInventarioEnListBox(listBoxProductos); // ✅ Actualizar inventario visualmente

            // Limpiar el campo de ID
            tbIdHistorial.Clear();

            MessageBox.Show("Venta eliminada y productos restablecidos en el inventario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

