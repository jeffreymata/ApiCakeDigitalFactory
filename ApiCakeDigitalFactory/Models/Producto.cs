﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ApiCakeDigitalFactory.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Img { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        //public int idDetalle { get; set; }
        //public Detalle Detalle { get; set; }
    }
}
