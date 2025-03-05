using Das_Tienda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Das_Tienda.Servicios
{
    class Inventario
    {

        private Producto[,] productos = new Producto[5, 10];  // Matriz que almacena productos completos

        private string[] categorias = { "Alimentos", "Bebidas", "Electronicos", "Accesorios", "Ropa" };


        // Método para agregar un producto
        public void AgregarInventario(string categoria, Producto producto)
        {
            int indexCategoria = GetFilaCategoria(categoria);

            if (indexCategoria == -1)
            {
                MessageBox.Show("Categoría no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el producto ya existe y actualizar stock
            for (int i = 0; i < 10; i++)
            {
                if (productos[indexCategoria, i] != null && productos[indexCategoria, i].Nombre == producto.Nombre)
                {
                    productos[indexCategoria, i].Cantidad += producto.Cantidad;  // ✅ Usamos la cantidad dentro del objeto Producto
                    MessageBox.Show($"El stock de {producto.Nombre} ha sido actualizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Agregar un nuevo producto si hay espacio
            for (int i = 0; i < 10; i++)
            {
                if (productos[indexCategoria, i] == null)  // Espacio vacío
                {
                    productos[indexCategoria, i] = producto;  // Guardar el objeto completo
                    return;
                }
            }

            MessageBox.Show("No hay espacio suficiente en la categoría para agregar más productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Método para obtener productos con su stock
        public string[] ObtenerProductosParaMostrar()
        {
            var listaProductos = new List<string>();

            for (int i = 0; i < 5; i++)  // Recorrer categorías
            {
                listaProductos.Add($"Categoría: {categorias[i]}");

                bool categoriaTieneProductos = false;

                for (int j = 0; j < 10; j++)  // Recorrer productos dentro de la categoría
                {
                    if (productos[i, j] != null)  // Si hay un producto en esta posición
                    {
                        listaProductos.Add($"  - {productos[i, j].Nombre}: {productos[i, j].Cantidad} unidades - ${productos[i, j].Precio}");
                        categoriaTieneProductos = true;
                    }
                }

                if (!categoriaTieneProductos)
                {
                    listaProductos.Add("  (Sin productos registrados)");
                }

                listaProductos.Add("");  // Espacio entre categorías
            }

            return listaProductos.ToArray();
        }


        // Obtener solo nombres de productos
        public string[] ObtenerSoloProductos()
        {
            var listaProductos = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (productos[i, j] != null)
                    {
                        listaProductos.Add(productos[i, j].Nombre);
                    }
                }
            }

            return listaProductos.ToArray();
        }

        private static int GetFilaCategoria(string categoria)
        {

            switch (categoria)
            {

                case "Alimentos":
                    return 0;

                case "Bebidas":
                    return 1;

                case "Electronica":
                    return 2;

                case "Accesorios":
                    return 3;

                case "Ropa":
                    return 4;

                default:
                    return -1;
            }
        }

        public Producto BuscarProductoPorNombre(string nombre)
        {
            for (int i = 0; i < 5; i++) // Recorrer categorías
            {
                for (int j = 0; j < 10; j++) // Recorrer productos dentro de la categoría
                {
                    if (productos[i, j] != null && productos[i, j].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        return productos[i, j]; // Retorna el objeto producto encontrado
                    }
                }
            }
            return null;
        }
    }



}
