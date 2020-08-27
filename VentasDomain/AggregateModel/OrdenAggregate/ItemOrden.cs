using System;
using System.Collections.Generic;
using System.Text;
using VentasDomain.Common;

namespace VentasDomain.AggregateModel.OrdenAggregate
{ 
  class ItemOrden : Entity
{
    private string _nombreProducto;
    private string _fotoUrl;
    private decimal _precioUnitario;
    private decimal _descuento;
    private int _unidades;

    public int ProductID { get; private set; }

    protected ItemOrden() { }

    public ItemOrden(int productId, string nombreProducto, decimal precioUnitario, decimal descuento, string fotoUrl, int unidades = 1)
    {

        ProductID = productId;
        _nombreProducto = nombreProducto;
        _precioUnitario = precioUnitario;
        _descuento = descuento;
        _unidades = unidades;
        _fotoUrl = fotoUrl;
    }
    public string GetfotoUri() => _fotoUrl;

}
}
