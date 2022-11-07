using System;

namespace tp09_JSON.Models{

    public class Plato{
        private string _Nombre;
        public string Nombre { get {return  _Nombre;} set {_Nombre=value;}}

        private int _PrecioUnitario;
        public int PrecioUnitario { get {return _PrecioUnitario;} set { _PrecioUnitario=value;}}
    }
}