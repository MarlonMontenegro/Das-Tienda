using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Das_Tienda.Models
{
     class Producto
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Precio { get; set; }
        public float Cantidad { get; set; }
        public decimal Valor { get { return Precio * (decimal) Cantidad; } }
    }
}
