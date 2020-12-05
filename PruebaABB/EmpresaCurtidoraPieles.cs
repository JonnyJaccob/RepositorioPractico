using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaABB
{
    class EmpresaCurtidoraPieles : IComparable<EmpresaCurtidoraPieles>, IEquatable<EmpresaCurtidoraPieles>, IEnumerable<EmpresaCurtidoraPieles>, IEnumerator<EmpresaCurtidoraPieles>
    {
        public EmpresaCurtidoraPieles()
        {

        }
        public bool Equals(EmpresaCurtidoraPieles obj)
        {
            try
            {
                if ((obj.ID == this.ID))//|| !this.GetType().Equals(obj.GetType()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                throw new Exception("+" + ex);
            }
        }

        public int CompareTo(EmpresaCurtidoraPieles other)
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

        public IEnumerator<EmpresaCurtidoraPieles> GetEnumerator()
        {
            throw new NotImplementedException();
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        private int _intID;

        public int ID
        {
            get { return _intID; }
            set { _intID = value; }
        }
        private double _dblSueldoXAño;

        public double Sueldo
        {
            get { return _dblSueldoXAño; }
            set { _dblSueldoXAño = value; }
        }
        private string _strNombreEmpleado;

        public string Nombre
        {
            get { return _strNombreEmpleado; }
            set { _strNombreEmpleado = value; }
        }
        private char _chrInicialEmpleado;

        public char Inicial
        {
            get { return _chrInicialEmpleado; }
            set { _chrInicialEmpleado = value; }
        }
        private DateTime _dtmFechaIngreso;

        public DateTime Fecha
        {
            get { return _dtmFechaIngreso; }
            set { _dtmFechaIngreso = value; }
        }
        private bool _blnSeguroMedico;

        public bool Seguro
        {
            get { return _blnSeguroMedico; }
            set { _blnSeguroMedico = value; }
        }
        private string _DireccionPath;

        public string Direccion
        {
            get { return _DireccionPath; }
            set { _DireccionPath = value; }
        }
        private string _intPuesto;

        public string Puesto
        {
            get { return _intPuesto; }
            set { _intPuesto = value; }
        }

        private string _strGenero;

        public string Genero
        {
            get { return _strGenero; }
            set { _strGenero = value; }
        }

        public EmpresaCurtidoraPieles Current => throw new NotImplementedException();

        //object IEnumerator.Current => throw new NotImplementedException();

        object System.Collections.IEnumerator.Current => throw new NotImplementedException();

        ~EmpresaCurtidoraPieles()
        {

        }
        public override string ToString()
        {
            return $"{this.ID}";

        }
        public string ToStringAll()
        {
            string x;
            if (this.Seguro)
            {
                x = "Si";
            }
            else
            {
                x = "No";
            }
            return $"Nombre: {this.Nombre} \nNumero ID: {this.ID}\nSueldo: {this.Sueldo}\nLetra inicial: {this.Inicial}\nFecha de ingreso a la empresa: {this.Fecha}\nGenero: {this.Genero}\nPuesto del trabajador: {this.Puesto}\n¿Tiene seguro?: {x}";

        }

        

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
