using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea15_Inventario_ListasEnlazadasSimples
{
    class Inventario
    {
        private Producto _primero;
        private Producto _ultimo;

        public Inventario()
        {
            _primero = null;
            _ultimo = null;
        }

        public void agregarProducto(Producto productoNuevo)
        {
            if (_primero == null)
                _primero = productoNuevo;
            else
                _ultimo.siguiente = productoNuevo;
            _ultimo = productoNuevo;
        }

        public void agregarProductoEnInicio(Producto productoNuevo)
        {
            if (_primero == null)
                _primero = productoNuevo;
            else
            {
                productoNuevo.siguiente = _primero;
                _primero = productoNuevo;
            }
        }

        public Producto buscarProducto(int codigoProducto)
        {
            Producto actual = _primero;
            while (actual != null)
            {
                if (actual.codigo == codigoProducto)
                    return actual;
                actual = actual.siguiente;
            }
            return null;
        }

        private Producto _buscarProductoAnterior(int codigoProducto)
        {
            Producto actual = _primero;
            while (actual != null)
            {
                if (actual.siguiente.codigo == codigoProducto)
                    return actual;
                actual = actual.siguiente;
            }
            return null;
        }

        public string borrarProducto(int codigoProducto)
        {
            string mensaje = "Producto no encontrado";
            Producto busquedaProducto = buscarProducto(codigoProducto);
            if (busquedaProducto != null)
            {
                if (busquedaProducto == _primero)
                {
                    _primero = busquedaProducto.siguiente;
                    mensaje = "Producto eliminado";
                }
                else if (busquedaProducto == _ultimo)
                {
                    Producto anteriorUltimo = _buscarProductoAnterior(codigoProducto);
                    anteriorUltimo.siguiente = null;
                    _ultimo = anteriorUltimo;
                    mensaje = "Producto eliminado";
                }
                else
                {
                    _buscarProductoAnterior(codigoProducto).siguiente = busquedaProducto.siguiente;
                    mensaje = "Producto eliminado";
                }

            }
            return mensaje;
        }

        public string reporte()
        {
            string reporte = "";
            Producto actual = _primero;
            while (actual != null)
            {
                reporte += actual.ToString() + Environment.NewLine + "----------------------------" + Environment.NewLine;
                actual = actual.siguiente;
            }
            return reporte;
        }
    }
}
