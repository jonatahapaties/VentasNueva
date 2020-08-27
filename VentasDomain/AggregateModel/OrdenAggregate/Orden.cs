using System;
using System.Collections.Generic;
using System.Text;

namespace VentasDomain.AggregateModel.OrdenAggregate
{
    class Orden : Common.Entity, IAggregateRoot
    {
        private DateTime _FechaOrden;
        public Direccion Direccion;
        public int GetBuyerId => _buyerId;
        private int _buyerId;
        private string _descripcion;
    }
}
