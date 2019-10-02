using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Componente;

namespace Composite.Composite
{
    public class Recambio : ComponenteRecambio
    {
        // Arraylist que contendrá los elementos hijo
        private readonly ArrayList listaRecambios;

        // Atributos
        private string _nombre;
        private string _descripcion;
        private double _precio;

        // Constructor que recibirá el nombre, el precio y la descripción.
        public Recambio(string nombre, string descripcion, double precio)
        {
            // Instanciamos el ArrayList
            listaRecambios = new ArrayList();

            // Asignamos el nombre, la descripción y el precio
            this._nombre = nombre;
            this._descripcion = descripcion;
            this._precio = precio;
        }

        #region Métodos relacionados con el árbol

        // Añade un nuevo elemento al ArrayList
        public override void add(ComponenteRecambio componente)
        {
            listaRecambios.Add(componente);
        }

        // Elimina un elemento del ArrayList
        public override void remove(ComponenteRecambio componente)
        {
            listaRecambios.Remove(componente);
        }

        // Recupera un elemento del ArrayList
        public override ComponenteRecambio getElemento(int indice)
        {
            return (ComponenteRecambio)listaRecambios[indice];
        }

        #endregion

        #region Métodos relacionados con el elemento

        public override string getNombre()
        {
            string nombreCompleto = this._nombre;

            foreach (ComponenteRecambio c in listaRecambios)
                nombreCompleto += "+" + c.getNombre();

            return nombreCompleto;
        }

        public override string getDescripcion()
        {
            string descripcionCompleta = this._descripcion;

            foreach (ComponenteRecambio c in listaRecambios)
                descripcionCompleta += "+"+c.getDescripcion();

            return descripcionCompleta;
        }

        public override double getPrecio()
        {
            double precioTotal = this._precio;

            foreach (ComponenteRecambio c in listaRecambios)
                precioTotal += c.getPrecio();

            return precioTotal;
        }

        #endregion
    }
}
