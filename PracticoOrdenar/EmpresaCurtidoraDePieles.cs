using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOrdenar
{
    public class Bomberos: IComparable<Bomberos>, IEquatable<Bomberos>
    {  
        public Bomberos()
        {
            
        }
        private int _intId;

        public int ID
        {
            get { return _intId; }
            set { _intId = value; }
        }
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private double _dblSueldo;

        public double Sueldo
        {
            get { return _dblSueldo; }
            set { _dblSueldo = value; }
        }

        public int CompareTo(Bomberos other)
        {
            if (this.ID < other.ID)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public bool Equals(Bomberos other)
        {
            if(other.ID==this.ID)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre}, ID {this.ID}, Sueldo {this.Sueldo} ";
        }
    }
}
