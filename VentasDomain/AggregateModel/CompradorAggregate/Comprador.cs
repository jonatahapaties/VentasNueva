using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Domain.Common;

namespace VentasDomain.AggregateModel.NewFolder.CompradorAggregate
{
    class Comprador
    {
        public string IdentityGuid { get; private set; }
        public string Name { get; private set; }

        private List<MetodosPago> _metodosPagos;
        public IEnumerable<MetodosPago> MetodosPago => _metodosPagos.AsReadOnly();

        protected Comprador()
        {
            _metodosPagos = new List<MetodosPago>();
        }
        protected Comprador(string identity, string name) : this()
        {
            IdentityGuid = identity;
            Name = name;
        }
    }
}
