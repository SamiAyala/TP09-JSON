using System;
using System.Collections.Generic;

namespace tp09_JSON.Models{
    public class Restaurante{
        private int _Id;
        public int Id{ get{return _Id;} set {_Id=value;}}

        private string _Nombre;
        public string Nombre{ get{return _Nombre;}set {_Nombre=value;}}
        private int _AñoApertura;
        public int AñoApertura{get{return _AñoApertura;} set {_AñoApertura=value;}}

        private string _Dueño;
        public string Dueño{get{return _Dueño;}set {_Dueño=value;}}
        private int[] _Ubicacion;
        public int[] Ubicacion { get{return _Ubicacion;} set {_Ubicacion=value;}}

        public string _Logo;
        private string Logo { get{return _Logo;} set {_Logo=value;}}

        private List<Plato> _MenuPrincipal;

        public List<Plato> MenuPrincipal { get { return _MenuPrincipal;} set { _MenuPrincipal=value;}}

        private List<Reseña> _Reseñas;

        public List<Reseña> Reseñas { get { return _Reseñas;} set { _Reseñas=value;}}
    }
}