using System;
using System.Collections.Generic;

#nullable disable

namespace ApiCakeDigitalFactory.Models
{
    public partial class Orden
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
