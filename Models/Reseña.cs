using System;
namespace tp09_JSON.Models{
    public class Reseña{
        private string _NombreUsuario;
        public string NombreUsuario { get { return _NombreUsuario;} set { _NombreUsuario=value;}}

        private int _Valoracion;
        public int Valoracion {  get { return _Valoracion;} set { _Valoracion=value;}}

        private string _Descripcion;
        public string Descripcion{ get { return _Descripcion;} set { _Descripcion=value;}}

        private int _CantLikes;
        public int CantLikes { get { return _CantLikes;} set { _CantLikes=value;}}
    }
}