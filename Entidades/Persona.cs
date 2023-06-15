using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public interface Persona {
        public abstract string Nombre { get; set; }
        public abstract string Apellido { get; set; }
        public abstract string Usuario { get; set; }

        public abstract string ToString();
    }
}
