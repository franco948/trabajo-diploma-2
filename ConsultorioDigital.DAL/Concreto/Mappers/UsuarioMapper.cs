using System;
using System.Data;
using ConsultorioDigital.Seguridad;

namespace ConsultorioDigital.DAL.Mappers
{
  internal class UsuarioMapper : Mapper<Usuario>
  {
    public override Usuario Map(DataRow row)
    {
      return new Usuario((string)row["Usuario_Email"], null)
      {
        Id = (Guid)row["Usuario_Id"],
        PasswordCifrado = Convert.ToString(row["Usuario_PasswordCifrado"]),
        Intentos = Convert.ToUInt32(row["Usuario_Intentos"])
      };
    }
  }
}
