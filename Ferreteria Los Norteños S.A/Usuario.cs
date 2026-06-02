using System;

namespace GestionProveedoresApp
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre  { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public bool Activo { get; set; }
        
    }
}
