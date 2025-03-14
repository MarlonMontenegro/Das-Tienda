﻿using Das_Tienda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Das_Tienda.Servicios
{
    class GestorVenta
    {

        public Dictionary<int, Venta> Ventas;

        public GestorVenta()
        {
            Ventas = new Dictionary<int, Venta>();
        } 


        public void AgregarVentas(int id, Venta venta)
        {
            Ventas.Add(id, venta);
        }


        public void EliminarVenta(int id)
        {
            Ventas.Remove(id);
        }

        public Venta BuscarVentaPorId(int id)
        {
            if (Ventas.ContainsKey(id))
            {
                return Ventas[id];
            }
            else
            {
                return null;
            }
        }


    }
}
