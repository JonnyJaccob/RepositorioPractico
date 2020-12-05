using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaABB
{
    public class ClaseVar : IComparable<ClaseVar>, IEquatable<ClaseVar>
    {
        public ClaseVar()
        {

        }
        private string _strCampo1;

        public string Nombre
        {
            get { return _strCampo1; }
            set { _strCampo1 = value; }
        }
        private int _intCampoID;

        public int ID
        {
            get { return _intCampoID; }
            set { _intCampoID = value; }
        }
        
        private double _dblCampo4;

        public double Sueldo
        {
            get { return _dblCampo4; }
            set { _dblCampo4 = value; }
        }
        
        
        private string _DireccionPath;

        public string Direccion
        {
            get { return _DireccionPath; }
            set { _DireccionPath = value; }
        }
        private string _intPuesto;

        

        public int CompareTo(ClaseVar other)
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

        public bool Equals(ClaseVar obj)
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
            }
            catch (Exception ex)
            {
                throw new Exception("+" + ex);
            }
        }
        public override string ToString()
        {
            return $"{this.ID}";
        }
        public string ToStringAll()
        {
            
            
            return $"Nombre: {this.Nombre} \nNumero ID: {this.ID}\nSueldo: {this.Sueldo}";

        }
    }
}
