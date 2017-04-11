using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea15_Inventario_ListasEnlazadasSimples
{
    class Producto
    {
        private int _codigo;
        public int codigo { get { return _codigo; } }
        private string _nombre;
        public string nombre { get { return nombre; } }
        private float _precio;
        public float precio { get { return precio; } }
        private int _cantidad;
        public int cantidad { get { return cantidad; } }
        private Producto _siguiente;
        public Producto siguiente { set { _siguiente = value; } get { return _siguiente; } }

        //public Producto()
        //{
        //    _codigo = 0;
        //    _nombre = "Sin nombre";
        //    _cantidad = 0;
        //    _precio = 0;
        //}

        public Producto(int codigo, string nombre, float precio, int cantidad)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _cantidad = cantidad;
            _siguiente = null;
        }

        public override string ToString()
        {
            return "Código: " + _codigo + Environment.NewLine + "Nombre: " + _nombre + Environment.NewLine + "Precio: " + _precio + Environment.NewLine + "Cantidad: " + _cantidad;
        }

    }
}
