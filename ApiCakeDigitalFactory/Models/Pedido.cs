using System;
using System.Collections.Generic;

#nullable disable

namespace ApiCakeDigitalFactory.Models
{
    public partial class Pedido
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Estado { get; set; }
        public decimal Isv { get; set; }
        public decimal Total { get; set; }
    }
}
