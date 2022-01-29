using System;
using System.Collections.Generic;

#nullable disable

namespace ApiCakeDigitalFactory.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Roll { get; set; }
    }
}
