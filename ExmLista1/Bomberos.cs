using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimpleBomberos
{
    public class Bomberos: IEquatable<Bomberos>, IComparable<Bomberos>
    {
        public Bomberos()
        {

        }
        private int _intID;

        public int ID
        {
            get { return _intID; }
            set { _intID = value; }
        }
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private char _chrLetraInicial;

        public char Inicial
        {
            get { return _chrLetraInicial; }
            set { _chrLetraInicial = value; }
        }
        private double _dblSueldoMes;

        public double Sueldo
        {
            get { return _dblSueldoMes; }
            set { _dblSueldoMes = value; }
        }
        private DateTime dtmFechaIngreso;

        public DateTime Fecha
        {
            get { return dtmFechaIngreso; }
            set { dtmFechaIngreso = value; }
        }
        private bool chkSeguro;

        public bool Seguro
        {
            get { return chkSeguro; }
            set { chkSeguro = value; }
        }
        private string strPuestoPrefrido;

        public string Puesto
        {
            get { return strPuestoPrefrido; }
            set { strPuestoPrefrido = value; }
        }
        public bool Equals(Bomberos other)
        {
            if(this.ID==other.ID)
            {
                return true;
            }
            return false;
        }

        public int CompareTo(Bomberos other)
        { 
            if(this.ID>other.ID)
            {
                return 1;
            }
            if(this.ID<other.ID)
            {
                return -1;
            }
            return 0;
        }
        public override string ToString()
        {
            string b="No";
            if(this.Seguro)
            {
                b = "Si";
            }
            return ($"ID: {this.ID},Nombre {this.Nombre} Datos: {this.Inicial}, {this.dtmFechaIngreso},Puesto {this.Puesto}, Tiene seguro? {b}");
        }

        
    }
}
