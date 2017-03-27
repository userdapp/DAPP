using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Descripción breve de ConexionBD
/// </summary>
public class ConexionBD
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructor
    public ConexionBD()
    {
        Initialize();
    }

    //Initialize values
    private void Initialize()
    {
        server = "localhost";
        database = "denunciaambdb";
        uid = "root";
        password = "";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }

    //open connection to database
    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
           
          throw new Exception("Cannot connect to server.  Contact administrator");
            
        }
       
    }

    //Close connection
    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            throw new Exception("Cannot connect to server.  Contact administrator");
        }
    }

    //Insert statement
    public void Insert()
    {
        string query = "insert into denuncia (K_ID_TIPODEN,K_ID_DENUNCIA,N_DESC_DENUNCIA,N_PRIORIDAD_DEN,F_FECHA_DEN,K_TOKEN) values('3','20134','animalitos encerrados','2','2017-01-30','hjk1130');";

        //open connection
        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }



}