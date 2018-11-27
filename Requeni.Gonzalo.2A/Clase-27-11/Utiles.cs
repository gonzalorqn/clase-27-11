using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_27_11
{
    public abstract class Utiles
    {
        protected double _precio;
        protected string _marca;

        protected abstract double Precio
        {
            get; set;
        }

        protected abstract string Marca
        {
            get; set;
        }

        public virtual string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Precio: " + this.Precio);
            sb.AppendLine("Marca: " + this.Marca);
            return sb.ToString();
        }
    }
}
