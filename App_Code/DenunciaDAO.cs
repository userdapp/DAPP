using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


/// <summary>
/// Descripción breve de DenunciaDAO
/// </summary>
public class DenunciaDAO
{
    public static int Agregar(DenunciaVO denunciaVO)
    {

        int retorno = 0;

        MySqlCommand comando = new MySqlCommand(string.Format("insert into denuncia (K_ID_TIPODEN,K_ID_DENUNCIA,N_DESC_DENUNCIA,N_PRIORIDAD_DEN,F_FECHA_DEN,K_TOKEN) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
           denunciaVO.IdTipoDenuncia, denunciaVO.IdDenuncia, denunciaVO.DescDenuncia, denunciaVO.PrioridadDenuncia, denunciaVO.FechaDenuncia, denunciaVO.Token), BDComun.ObtenerConexion());

        retorno = comando.ExecuteNonQuery();

        return retorno;
    }


    public static List<DenunciaVO> Buscar(String denToken)
    {
        
        String sqlConsulta = "select K_TOKEN, F_FECHA_DEN, N_DESC_DENUNCIA from denuncia where K_TOKEN ='"+denToken+ "'";
       
        List<DenunciaVO> _lista = new List<DenunciaVO>();

      
            MySqlCommand _comando = new MySqlCommand(sqlConsulta, BDComun.ObtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                DenunciaVO denunciaVO = new DenunciaVO();
                denunciaVO.Token = _reader.GetString(0);
                denunciaVO.FechaDenuncia = _reader.GetDateTime(1);
                // denunciaVO.PrioridadDenuncia = _reader.GetDecimal(2);
                denunciaVO.DescDenuncia = _reader.GetString(2);
                //denunciaVO.IdDenuncia = _reader.GetInt32(5);
                //denunciaVO.IdTipoDenuncia = _reader.GetString(4);
    
                _lista.Add(denunciaVO);
            }

             _reader.Close();
            return _lista;
        }
    
}


  