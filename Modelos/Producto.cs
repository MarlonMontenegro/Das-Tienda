using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Das_Tienda.Models
{
     class Producto
    {

        private static int ContadorId = 0;
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }


        public Producto(string nombre, string Categoria, decimal precio, int cantidad)
        {
            this.ID = ++ContadorId;
            this.Nombre = nombre;
            this.Categoria = Categoria;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }
        
        
        
        
     }
    
}
