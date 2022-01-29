using System;
using System.Collections.Generic;

#nullable disable

namespace ApiCakeDigitalFactory.Models
{
    public partial class Detalle
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}
