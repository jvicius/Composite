using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Componente;

namespace Composite.Hoja
{
    public class ElementoRecambio : ComponenteRecambio
    {
        // Atributos propios del nodo hoja.
        private string _nombre;
        private string _descripcion;
        private double _precio;

        // Constructor
        public ElementoRecambio(string nombre, string descripcion, double precio)
        {
            this._nombre = nombre;
            this._descripcion = descripcion;
            this._precio = precio;
        }

        // Sobrecargamos únicamente los métodos propios de los nodos hoja, destinados
        // a devolver la información y a asignarla

        // NOMBRE
        public override string getNombre()
        {
            return _nombre;
        }

        public override void setNombre(string nombre)
        {
            this._nombre = nombre;
        }

        // DESCRIPCION
        public override string getDescripcion()
        {
            return _descripcion;
        }

        public override void setDescripcion(string descripcion)
        {
            this._descripcion = descripcion;
        }

        // PRECIO
        public override double getPrecio()
        {
            return _precio;
        }

        public override void setPrecio(double precio)
        {
            this._precio = precio;
        }
        // Los métodos add, remove y getElemento no se sobrecargarán, ya que
        // el nodo hoja no estará compuesto por más elementos que él mismo.
    }
}
