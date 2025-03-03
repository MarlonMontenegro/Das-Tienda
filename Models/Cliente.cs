using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Das_Tienda.Models
{
     class Cliente
     {

        private static int contadorId = 0;
        public int Id { get; set; }
        private string Nombre { get; set; }
        private string Direccion {  get; set; }
        private int Telefono { get; set; }


        public Cliente (string nombre, string direccion, int telefono) 
        { 
            this.Id = ++contadorId;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
        
        }
    }
}
