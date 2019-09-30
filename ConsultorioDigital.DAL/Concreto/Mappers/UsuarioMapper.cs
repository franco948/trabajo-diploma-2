using System;
using System.Data;
using ConsultorioDigital.Seguridad;

namespace ConsultorioDigital.DAL.Mappers
{
  internal class UsuarioMapper : Mapper<Usuario>
  {
    public override Usuario Map(IDataReader reader)
    {
      return new Usuario((string)reader["Usuario_Email"], null)
      {
        Id = (Guid)reader["Usuario_Id"],
        PasswordCifrado = Convert.ToString(reader["Usuario_PasswordCifrado"]),
        Intentos = Convert.ToUInt32(reader["Usuario_Intentos"])
      };
    }
  }
}
