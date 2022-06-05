using System;
using System.Collections.Generic;

namespace PizzaDelivery.Core.Models
{
    public partial class Sucursal
    {
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public int? IdGerente { get; set; }
    }
}
