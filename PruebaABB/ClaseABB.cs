using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaABB
{
    public class ClaseABB<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>
    {
        public ClaseABB()
        {
            _raiz = null;
        }
        private ClaseNodo<Tipo> _raiz;

        public ClaseNodo<Tipo> Raiz
        {
            get { return _raiz; }
            private set { _raiz = value; }
        }

        public bool Vacio
        {
            get
            {
                if (_raiz == null)
                {
                    return true;
                }
                return false;
            }
        }
        
         
        public void AgregarNodo1(Tipo objeto)
        {
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            if (Vacio)
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.HijoDer = null;
                nodoNuevo.HijoIzq = null;
                this.Raiz = nodoNuevo;
                return;
            }
            else
            {
                nodoActual = this.Raiz;
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("Esta duplicado");
                    }
                    else
                    {
                        if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                        {
                            if (nodoActual.Equals(Raiz))
                            {
                                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                                nodoNuevo.ObjetoConDatos = objeto;
                                nodoNuevo.HijoIzq = this.Raiz;
                                this.Raiz = nodoNuevo;
                                return;
                            }
                            else
                            {
                                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                                nodoNuevo.ObjetoConDatos = objeto;
                                nodoNuevo.HijoIzq = nodoPrevio.HijoIzq;
                                nodoPrevio.HijoIzq = nodoNuevo;
                                return;
                            }
                        }
                        else
                        if (objeto.CompareTo(nodoActual.ObjetoConDatos) == 1)
                        {
                            if (nodoActual.Equals(Raiz))
                            {
                                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                                nodoNuevo.ObjetoConDatos = objeto;
                                nodoNuevo.HijoDer = this.Raiz;
                                this.Raiz = nodoNuevo;
                                return;
                            }
                            else
                            {
                                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                                nodoNuevo.ObjetoConDatos = objeto;
                                nodoNuevo.HijoDer = nodoPrevio.HijoDer;
                                nodoPrevio.HijoDer = nodoNuevo;
                                return;
                            }
                        }
                        else
                        {
                            nodoPrevio = nodoActual;
                            nodoActual = nodoActual.HijoDer;
                        }
                    }
                } while (nodoActual != null);
                ClaseNodo<Tipo> nodoNuevos = new ClaseNodo<Tipo>();
                nodoNuevos.ObjetoConDatos = objeto;
                if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                {
                    nodoPrevio.HijoIzq = nodoNuevos;
                }
                if (objeto.CompareTo(nodoActual.ObjetoConDatos) == 1)
                {
                    nodoPrevio.HijoDer = nodoNuevos;
                }
                nodoNuevos.HijoDer = null;
                nodoNuevos.HijoIzq = null;
                return;
            }

        }
        public void AgregarNodo(Tipo objeto)
        {
            if (Vacio)
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                Raiz = nodoNuevo;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                nodoActual = this.Raiz;
                while (nodoActual != null)
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("Esta duplicado");
                    }
                    else
                    {
                        if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                        {
                            nodoPrevio = nodoActual;
                            nodoActual = nodoActual.HijoIzq;
                        }
                        else
                        {
                            nodoPrevio = nodoActual;
                            nodoActual = nodoActual.HijoDer;
                        }
                    }

                }
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                if (objeto.CompareTo(nodoPrevio.ObjetoConDatos) == -1)
                {
                    nodoPrevio.HijoIzq = nodoNuevo;
                }
                else
                {
                    nodoPrevio.HijoDer = nodoNuevo;
                }
            }
        }
        
        public Tipo EliminarNodo1(Tipo objeto)
        {

            if (Vacio)
            {
                throw new Exception("Esta vacio");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoRevisado = new ClaseNodo<Tipo>();
                nodoActual = this.Raiz;
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    if (nodoActual.HijoDer == null && nodoActual.HijoIzq == null)
                    {
                        nodoEliminado = this.Raiz;
                        this.Raiz = null;
                        nodoActual = null;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    if (nodoActual.HijoDer == null)
                    {
                        nodoEliminado = this.Raiz;
                        this.Raiz = nodoActual.HijoIzq;
                        nodoActual = null;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    if (nodoActual.HijoIzq == null)
                    {
                        nodoEliminado = this.Raiz;
                        this.Raiz = nodoActual.HijoDer;
                        nodoActual = null;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    else
                    {
                        ClaseNodo<Tipo> nodo1, nodo2;
                        nodo1 = nodoActual.HijoIzq;
                        nodo2 = nodoActual.HijoDer;
                        nodoEliminado = this.Raiz;
                        if (nodo1.ObjetoConDatos.CompareTo(nodo2.ObjetoConDatos) == -1)
                        {
                            this.Raiz.HijoIzq = nodo1.HijoIzq;
                            this.Raiz.ObjetoConDatos = nodo1.ObjetoConDatos;
                            return nodoEliminado.ObjetoConDatos;
                        }
                        else
                        {
                            this.Raiz = nodo2;
                            return nodoEliminado.ObjetoConDatos;
                        }
                    }
                }
                else
                {
                    
                    do
                    {
                        if (objeto.Equals(nodoActual.ObjetoConDatos))
                        {
                            if (nodoActual.HijoDer == null && nodoActual.HijoIzq == null)
                            {
                                nodoEliminado = nodoActual;

                                nodoActual = null;
                                return nodoEliminado.ObjetoConDatos;
                            }
                            if (nodoActual.HijoDer == null)
                            {
                                nodoEliminado = nodoActual;
                                nodoPrevio.HijoIzq = nodoActual.HijoIzq;
                                nodoActual = null;
                                return nodoEliminado.ObjetoConDatos;
                            }
                            if (nodoActual.HijoIzq == null)
                            {
                                nodoEliminado = nodoActual;
                                nodoPrevio.HijoDer = nodoActual.HijoDer;
                                nodoActual = null;
                                return nodoEliminado.ObjetoConDatos;
                            }
                            else
                            {
                                ClaseNodo<Tipo> nodo1, nodo2;
                                nodo1 = nodoActual.HijoIzq;
                                nodo2 = nodoActual.HijoDer;
                                if (nodo1.ObjetoConDatos.CompareTo(nodo2.ObjetoConDatos) == -1)
                                {
                                    nodoEliminado = nodoActual;
                                    nodoActual = null;
                                    nodoPrevio.HijoIzq = nodo1;
                                    return nodoEliminado.ObjetoConDatos;
                                }
                                else
                                {
                                    nodoEliminado = nodoActual;
                                    nodoActual = null;
                                    nodoPrevio.HijoDer = nodo2;
                                    return nodoEliminado.ObjetoConDatos;
                                }
                            }
                        }
                        else
                        {

                            if (nodoActual.HijoIzq != nodoRevisado && nodoActual.HijoIzq != null)
                            {
                                nodoPrevio.HijoIzq = nodoActual;
                                nodoActual = nodoActual.HijoIzq;
                                nodoRevisado = nodoActual;
                            }
                            else if (nodoActual.HijoDer != nodoPrevio && nodoActual.HijoDer != null)
                            {
                                nodoPrevio.HijoDer = nodoActual;
                                nodoActual = nodoActual.HijoDer;
                                nodoRevisado = nodoActual.HijoDer;
                            }
                            else
                            {
                                nodoActual = nodoPrevio;
                            }

                        }
                    } while (nodoActual != null);
                }
                throw new Exception("No se encontro el objeto que borrara");
            }
        }
        public Tipo EliminarNodo(Tipo objeto)
        {

            ClaseNodo<Tipo> NodoActual = Raiz, Padre = null;

            if (Vacio == true)
            {
                throw new Exception("El árbol de busqueda está vacio");
            }
            else
            {
                while (objeto.Equals(NodoActual.ObjetoConDatos) == false)
                {
                    if (objeto.CompareTo(NodoActual.ObjetoConDatos) == -1)
                    {
                        Padre = NodoActual;
                        NodoActual = NodoActual.HijoIzq;
                    }
                    else
                    {
                        if (objeto.CompareTo(NodoActual.ObjetoConDatos) == 1)
                        {
                            Padre = NodoActual;
                            NodoActual = NodoActual.HijoDer;
                        }

                    }
                    if (NodoActual == null)
                    {
                        throw new Exception("No se elimino");
                    }
                }

            }
            if (NodoActual.HijoDer == null)
            {
                if (Padre == null)
                {
                    Raiz = NodoActual.HijoIzq;
                }
                else
                {
                    if (Padre.ObjetoConDatos.CompareTo(NodoActual.ObjetoConDatos) == 1)
                    {
                        Padre.HijoIzq = NodoActual.HijoIzq;
                    }
                    else if (Padre.ObjetoConDatos.CompareTo(NodoActual.ObjetoConDatos) == -1)

                    {
                        Padre.HijoDer = NodoActual.HijoIzq;

                    }
                }
            }
            else
            {
                if (NodoActual.HijoDer.HijoIzq == null)
                {
                    NodoActual.HijoDer.HijoIzq = NodoActual.HijoIzq;
                    if (Padre == null)
                    {
                        Raiz = NodoActual.HijoDer;
                    }
                    else
                    {
                        if (Padre.ObjetoConDatos.CompareTo(NodoActual.ObjetoConDatos) == 1)

                            Padre.HijoIzq = NodoActual.HijoDer;


                        else if (Padre.ObjetoConDatos.CompareTo(NodoActual.ObjetoConDatos) == -1)
                        {
                            Padre.HijoDer = NodoActual.HijoDer;
                        }
                    }

                }
                else 

                {
                    ClaseNodo<Tipo> NodoMenor = NodoActual.HijoDer.HijoIzq, PadreDelNodoMenor = NodoActual.HijoDer;
                    while (NodoMenor.HijoIzq != null)
                    {
                        PadreDelNodoMenor = NodoMenor;
                        NodoMenor = NodoMenor.HijoIzq;
                    }
                    PadreDelNodoMenor.HijoIzq = NodoMenor.HijoDer;
                    NodoMenor.HijoIzq = NodoActual.HijoIzq;
                    NodoMenor.HijoDer = NodoActual.HijoDer;
                    if (Padre == null)
                    {
                        Raiz = NodoMenor;
                    }
                    else
                    {
                        if (Padre.ObjetoConDatos.CompareTo(NodoActual.ObjetoConDatos) == 1)
                        {
                            Padre.HijoIzq = NodoMenor;
                        }
                        else
                        {
                            if (Padre.ObjetoConDatos.CompareTo(NodoActual.ObjetoConDatos) == -1)
                            {
                                Padre.HijoDer = NodoMenor;
                            }
                        }
                    }

                }

            }
            return NodoActual.ObjetoConDatos;
        }

        public Tipo BuscarNodo(Tipo objeto)
        {
            if (Vacio)
            {
                throw new Exception("Esta vacio");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = Raiz;
                while (nodoActual != null)
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        return (nodoActual.ObjetoConDatos);
                    }
                    else
                    {
                        if (objeto.CompareTo(nodoActual.ObjetoConDatos) > -1)
                        {
                            nodoActual = nodoActual.HijoDer;
                        }
                        else
                        {
                            nodoActual = nodoActual.HijoIzq;
                        }
                    }
                }
                throw new Exception("No  se encontro el nodo");
            }
        }
        public void Vaciar()
        {
            if(Vacio)
            {
                return;
            }else
            {
                this.RecorrerYBorrar(this.Raiz);
                this.Raiz = null;
            }
        }
        public IEnumerable<Tipo> RecorrerPreOrden()
        {
            /*foreach (Tipo miNodo in RecorrerPreOrden(this.Raiz))
            {
                yield return (miNodo);
            }
            yield break;*/
            return this.RecorrerPreOrden(this.Raiz);
        }
        private IEnumerable<Tipo> RecorrerPreOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {
                yield return nodoActual.ObjetoConDatos;
                foreach (Tipo miNodo in RecorrerPreOrden(nodoActual.HijoIzq))
                {
                    yield return miNodo;
                }
                foreach (Tipo miNodo in RecorrerPreOrden(nodoActual.HijoDer))
                {
                    yield return miNodo;
                }
                //yield break;
            }
            //yield break;

        }
        
        public void PreOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {


            }
            return;
        }
        public IEnumerable<Tipo> RecorrerInOrden()
        {
            /*foreach (Tipo miNodo in RecorrerInOrden(this.Raiz))
            {
                yield return (miNodo);
            }
            yield break;*/
            return this.RecorrerInOrden(this.Raiz);
        }
        private IEnumerable<Tipo> RecorrerInOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {
                foreach (Tipo miNodo in RecorrerInOrden(nodoActual.HijoIzq))
                {
                    yield return miNodo;
                }
                yield return nodoActual.ObjetoConDatos;
                foreach (Tipo miNodo in RecorrerInOrden(nodoActual.HijoDer))
                {
                    yield return miNodo;
                }
                //yield break;
            }
            //yield break;
        }
        
        public IEnumerable<Tipo> RecorrerPostOrden()
        {
            /*foreach (Tipo miNodo in RecorrerPostOrden(this.Raiz))
            {
                yield return (miNodo);
            }
            yield break;*/
            return this.RecorrerPostOrden(this.Raiz);
        }
        private IEnumerable<Tipo> RecorrerPostOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {
               
                foreach (Tipo miNodo in RecorrerPostOrden(nodoActual.HijoIzq))
                {
                    yield return miNodo;
                }
                foreach (Tipo miNodo in RecorrerPostOrden(nodoActual.HijoDer))
                {
                    yield return miNodo;
                }
                yield return nodoActual.ObjetoConDatos;
                //yield break;
            }
            //yield break;
        }
        public void Vaciar1()
        {
            Raiz.HijoDer = null;
            Raiz.HijoIzq = null;
            this.Raiz = null;
        }
        private void RecorrerYBorrar(ClaseNodo<Tipo> nodoActual)
        {
            if(nodoActual!=null)
            {
                this.RecorrerYBorrar(nodoActual.HijoIzq);
                this.RecorrerYBorrar(nodoActual.HijoDer);
                this.EliminarNodo(nodoActual.ObjetoConDatos);
                return;
            }
            return;
        }
        public void CrearArchivoDot(ref string Resultado)
        {
            if (!Vacio) // Si no está vacío ...
            {
                Resultado = Resultado + "digraph Figura {";
                Resultado = Resultado + "\nRaíz->" + Raiz.ObjetoConDatos.ToString() + ";";
                RecorrerNodos(Raiz, ref Resultado);
                Resultado = Resultado + "\n}";
            }
        }
        public void RecorrerNodos(ClaseNodo<Tipo> nodoActual, ref string strResultado)
        {
            if (nodoActual != null)
            {
                if (nodoActual.HijoIzq != null)
                { 
                    strResultado = strResultado + "\n" + nodoActual.ObjetoConDatos.ToString() + "->" +
                    nodoActual.HijoIzq.ObjetoConDatos.ToString() + ";";
                }
                if (nodoActual.HijoDer != null)
                { 
                    strResultado = strResultado + "\n" + nodoActual.ObjetoConDatos.ToString() + "->" +
                    nodoActual.HijoDer.ObjetoConDatos.ToString() + ";";
                }
                RecorrerNodos(nodoActual.HijoIzq, ref strResultado); 

                RecorrerNodos(nodoActual.HijoDer, ref strResultado); 

            }
        }
        ~ClaseABB()
        {
            Vaciar();
        }
    }
}
