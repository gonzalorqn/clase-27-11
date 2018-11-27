using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_27_11
{
    public class Goma : Utiles
    {
        protected bool _soloLapiz;

        protected override double Precio
        {
            get { return base._precio; }
            set { base._precio = value; }
        }
        protected override string Marca
        {
            get { return base._marca; }
            set { base._marca = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Solo lapiz: " + this._soloLapiz);
            return sb.ToString();
        }
    }
}
