using System;
using System.Collections.Generic;
using System.Text;
using VentasDomain.Common;

namespace VentasDomain.AggregateModel.OrdenAggregate
{
    class Direccion : ValueObject
    {
        public String Calle { get; private set; }

        public String Ciudad { get; private set; }

        public String Provincia { get; private set; }

        public String Pais { get; private set; }

        public String CodigoPostal { get; set; }

        public Direccion() { }

        public Direccion(String calle, String ciudad, String provincia, String pais, String codigoPostal)
        {
            Calle = calle;
            Ciudad = ciudad;
            Provincia = provincia;
            Pais = pais;
            CodigoPostal = codigoPostal;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            //
            yield return Calle;
            yield return Ciudad;
            yield return Provincia;
            yield return Pais;
            yield return CodigoPostal;

        }

    }



}
