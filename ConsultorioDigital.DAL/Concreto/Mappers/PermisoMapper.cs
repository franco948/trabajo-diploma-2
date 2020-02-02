using ConsultorioDigital.Seguridad;
using System;
using System.Data;

namespace ConsultorioDigital.DAL.Mappers
{
  internal class PermisoMapper : Mapper<Permiso>
  {
    public override Permiso Map(DataRow row)
    {
      Permiso permiso;

      // TODO poner un string real
      if (DBNull.Value == row["Permiso_Codigo"])
      {
        permiso = new Familia();
      }
      else
      {
        permiso = new Patente((CodigoPermiso)row["Permiso_Codigo"]);
      }

      permiso.Id = Convert.ToInt32(row["Permiso_Id"]);
      permiso.Nombre = Convert.ToString(row["Permiso_Nombre"]);

      return permiso;
    }
  }
}
