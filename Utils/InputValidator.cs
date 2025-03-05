using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Das_Tienda.Utils
{
    class InputValidator
    {
        public  bool EsTextoValido(string texto) => !string.IsNullOrEmpty(texto);

        public bool EsNumeroPositivo(string input,out int numero) => int.TryParse (input,out numero) && numero > 0;

        public bool EsNumeroPositivoDecimal(string input, out decimal numero) => decimal.TryParse(input, out numero) && numero > 0;
        
    }
}

