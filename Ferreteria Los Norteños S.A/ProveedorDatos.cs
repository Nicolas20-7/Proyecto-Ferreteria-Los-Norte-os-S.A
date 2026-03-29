using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionProveedoresApp
{
   
    public static class ProveedorDatos
    {
        private static List<Proveedor> listaProveedores = new List<Proveedor>();
        private static int proximoId = 1;

      
        static ProveedorDatos()
        {
            listaProveedores.Add(new Proveedor { Id = proximoId++, Nombre = "Proveedor Ejemplo S.A.", Correo = "contacto@ejemplo.com", Telefono = "12345678", Direccion = "Calle Principal 123", Cedula = "123-456789-0001", Contrasena = "admin123" });
            listaProveedores.Add(new Proveedor { Id = proximoId++, Nombre = "Soluciones Globales", Correo = "ventas@soluciones.co", Telefono = "87654321", Direccion = "Av. Central 45", Cedula = "987-654321-0002", Contrasena = "secure5" });
        }

       
        public static List<Proveedor> ObtenerTodos()
        {
            return listaProveedores;
        }

        public static Proveedor ObtenerPorId(int id)
        {
            return listaProveedores.FirstOrDefault(p => p.Id == id);
        }

        public static void Insertar(Proveedor proveedor)
        {
            proveedor.Id = proximoId++;
            listaProveedores.Add(proveedor);
        }

        public static void Actualizar(Proveedor proveedorActualizado)
        {
            var proveedorExistente = listaProveedores.FirstOrDefault(p => p.Id == proveedorActualizado.Id);
            if (proveedorExistente != null)
            {
                proveedorExistente.Nombre = proveedorActualizado.Nombre;
                proveedorExistente.Contrasena = proveedorActualizado.Contrasena;
                proveedorExistente.Correo = proveedorActualizado.Correo;
                proveedorExistente.Telefono = proveedorActualizado.Telefono;
                proveedorExistente.Direccion = proveedorActualizado.Direccion;
                proveedorExistente.Cedula = proveedorActualizado.Cedula;
            }
        }

        public static void Eliminar(int id)
        {
            var proveedor = listaProveedores.FirstOrDefault(p => p.Id == id);
            if (proveedor != null)
            {
                listaProveedores.Remove(proveedor);
            }
        }

       
        public static List<Proveedor> Buscar(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro)) return ObtenerTodos();
            return listaProveedores.Where(p =>
                p.Nombre.ToLower().Contains(filtro.ToLower()) ||
                p.Cedula.Contains(filtro)).ToList();
        }
    }
}