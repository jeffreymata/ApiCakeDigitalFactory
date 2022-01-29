using System;
using System.Collections.Generic;

#nullable disable

namespace ApiCakeDigitalFactory.Models
{
    public partial class OrdenDetalle
    {
        public int Id { get; set; }
        public int IdOrden { get; set; }
        public int IdDetalle { get; set; }
        public decimal PrecioDetalle { get; set; }
    }
}
