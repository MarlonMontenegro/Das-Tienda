﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Das_Tienda.Models
{
    class Venta
    {
       private static int contadorId = 0;
       public int ID { get; }

       public Cliente cliente;

       public int Cantidad;

       public List<Producto> productos;

        public List<Producto> Productos
        {
            get { return productos; }
        }

        public Venta(Cliente cliente)
        {
            this.ID = ++contadorId;
            this.cliente = cliente;
            this.productos = new List<Producto>();
        }


        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach (Producto producto in productos)
            {
                total += producto.Precio * producto.Cantidad;
            }
            return total;
        }

    }
}
