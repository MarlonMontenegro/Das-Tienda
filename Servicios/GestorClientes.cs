using Das_Tienda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Das_Tienda.Servicios
{
    class GestorClientes
    {

        List<Cliente> ListadoClientes;

        public GestorClientes()
        {
            ListadoClientes = new List<Cliente>();
        }

        public void AgregarCliente(Cliente cliente)
        {
            ListadoClientes.Add(cliente);
        }


        public void EliminarCliente(Cliente cliente)
        {
            ListadoClientes.Remove(cliente);
        }


    }
}
