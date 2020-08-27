using System;
using System.Collections.Generic;
using System.Text;
using VentasDomain.Common;

namespace VentasDomain.AggregateModel.NewFolder.CompradorAggregate
{
    public class TipoTarjeta : Enumeration
    {
        public static TipoTarjeta Amex = new TipoTarjeta(1, "Amex");
        public static TipoTarjeta Visa = new TipoTarjeta(2, "Visa");
        public static TipoTarjeta Masterdcard = new TipoTarjeta(3, "Masterdcard");

        public TipoTarjeta(int id, string nombre) : base(id, nombre)
        {
        }
    }
}
