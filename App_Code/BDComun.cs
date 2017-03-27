using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Descripción breve de BDComun
/// </summary>
public class BDComun
{
    public static MySqlConnection ObtenerConexion()
    {

        MySqlConnection conectar = new MySqlConnection("server=denunciaambiental.hopto.org; database=denuncia_ambiental; Uid=AdminDB; pwd=12345;");
        //MySqlConnection conectar = new MySqlConnection("server=localhost; database=denunciaambdb; Uid=root; pwd=;"); ANTERIOR CONEXION

        conectar.Open();
        return conectar;
    }
}