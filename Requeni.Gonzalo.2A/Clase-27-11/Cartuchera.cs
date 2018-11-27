using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_27_11
{
    public class Cartuchera<T>
    {
        protected string _marca;
        protected byte _capacidad;
        protected List<T> _elementos;

        private Cartuchera(byte capacidad)
        {
            this._capacidad = capacidad;
            this._elementos = new List<T>();
        }

        public Cartuchera(byte capacidad,string marca) : this(capacidad)
        {
            this._marca = marca;
        }

        public static implicit operator Cartuchera(byte capacidad)
        {

        }
    }
}
