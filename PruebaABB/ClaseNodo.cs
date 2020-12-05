using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaABB
{
    public class ClaseNodo<Tipo>
    {
        public ClaseNodo()
        {

        }
        private Tipo _ObjetoconDatos;

        public Tipo ObjetoConDatos
        {
            get { return _ObjetoconDatos; }
            set { _ObjetoconDatos = value; }
        }
        private ClaseNodo<Tipo> _HijoIzq;

        public ClaseNodo<Tipo> HijoIzq
        {
            get { return _HijoIzq; }
            set { _HijoIzq = value; }
        }
        private ClaseNodo<Tipo> _HijoDer;

        public ClaseNodo<Tipo> HijoDer
        {
            get { return _HijoDer; }
            set { _HijoDer = value; }
        }
        ~ClaseNodo()
        {
            ObjetoConDatos = default(Tipo);
        }
    }
}
