using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


public class UsuarioDAO
{
    public static List<UsuarioVO> Buscar(String uUsr, String uPsw)
    {
        //"select K_TOKEN, F_FECHA_DEN, N_DESC_DENUNCIA from denuncia where K_TOKEN ='" + denToken + "'";

        String sqlConsulta = "select * from usuario where N_Usuario = '" + uUsr + "' and N_Pass = '" + uPsw + "'";

        List<UsuarioVO> _lista = new List<UsuarioVO>();
        
        MySqlCommand _comando = new MySqlCommand(sqlConsulta, BDComun.ObtenerConexion());

        MySqlDataReader _reader = _comando.ExecuteReader();
        while (_reader.Read())
        {
            UsuarioVO usuarioVO = new UsuarioVO();
            usuarioVO.Pass=_reader.GetString(0);
            usuarioVO.Usr=_reader.GetString(1);
            usuarioVO.Email=_reader.GetString(2);
            usuarioVO.Cel=_reader.GetFloat(3);
            usuarioVO.Tel2=_reader.GetFloat(4);
            usuarioVO.Tel1=_reader.GetFloat(5);
            usuarioVO.FechaNacimiento=_reader.GetDateTime(6);
            usuarioVO.NombreUsuario=_reader.GetString(7);
            usuarioVO.DocIdent=_reader.GetFloat(8);
            usuarioVO.IdTipoDoc=_reader.GetString(9);
            usuarioVO.IdUsuario=_reader.GetString(10);
            usuarioVO.IdEntidad=_reader.GetString(11);

            _lista.Add(usuarioVO);

        }

        _reader.Close();
        return _lista;

    }
}