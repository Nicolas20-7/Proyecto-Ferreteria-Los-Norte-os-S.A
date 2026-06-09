using System.Collections.Generic;
using GestionProveedoresApp;

namespace Ferreteria_Los_Norteños_S.A
{
    /// <summary>
    /// Interfaz para las operaciones básicas de gestión de proveedores.
    /// </summary>
    public interface IGestionProveedor
    {
        List<Proveedor> GetAll();
        Proveedor GetById(int id);
        void Add(Proveedor proveedor);
        void Update(Proveedor proveedor);
        void Remove(int id);
    }
}
