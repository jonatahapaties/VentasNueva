using System;
using System.Collections.Generic;
using System.Text;
using VentasDomain.Common;

namespace VentasDomain.AggregateModel.NewFolder.CompradorAggregate
{ 
  class MetodosPago : Entity
{
    private string _alias;
    private string _numeroTarjeta;
    private string _numeroSeguridad;
    private string _nombreTitular;
    private DateTime _fechaExpiracion;

    private int _IdTipoTarjeta;
    public TipoTarjeta TipoTarjeta { get; private set; }

    protected MetodosPago() { }

    public MetodosPago(int IdTipoTarjeta, string alias, string numeroTarjeta, string numeroSeguridad, string nombreTitular, DateTime fechaExpiracion)
    {
        _numeroTarjeta = numeroTarjeta;
        _numeroSeguridad = numeroSeguridad;
        _nombreTitular = nombreTitular;
        _fechaExpiracion = fechaExpiracion;
        _alias = alias;
        _IdTipoTarjeta = IdTipoTarjeta;

    }

    public bool IsEqualsto(int IdTipoTarjeta, string numeroTarjeta, DateTime fechaExpiracion)
    {
        return _IdTipoTarjeta == IdTipoTarjeta
            && _numeroTarjeta == numeroTarjeta
            && _fechaExpiracion == fechaExpiracion;
    }
}
}
