using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.Class
{
    public class clsClientes
    {
        //variables Globables
        string stConexion = "";
        SqlCommand sqlCommand = null; //permite ejecutar un comando sql una sentencia o un procedimiento
        SqlConnection sqlConnection = null; //permite establecer la conexion con el servidor de db
        SqlParameter sqlParameter = null; //trabajar a nivel de parametros con procedimientos
        SqlDataAdapter sqlDataAdapter = null; //adaptar un origen de datos a una variable dataset datatable  variable etc 

        //variables Globables
        public clsClientes()
        {
            clsConexion obclsConexion = new clsConexion(); 
            stConexion= obclsConexion.stGetConexion(); // esta variable se le asigna el retorno de la conexio
        }
        //METODO CONSULTAR
        public DataSet stConsultarClientes(long lnIdentifcicacion)
        {
            try
            {
                int entero = 0;
                DataSet dsConsulta = new DataSet();
                sqlConnection = new SqlConnection(stConexion); //Aqui se crea la conexion
                sqlConnection.Open();//Abrimos la conexion
                sqlCommand = new SqlCommand("spConsultarClientes", sqlConnection);//Recibo el nombre del procedimiento
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parametros que recibe este procedimiento 
                sqlCommand.Parameters.Add(new SqlParameter("@nIdentificacion", lnIdentifcicacion));
                //Parametros que recibe este procedimiento 

                sqlCommand.ExecuteNonQuery();
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dsConsulta);

                return dsConsulta; //retorna un dataset
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }
        //METODO INSERTAR
        public string stInsertarClientes(long lnIdentifcicacion , string stNombres, string stApellidos) 
        {
            try 
            { 
                sqlConnection = new SqlConnection(stConexion); //Aqui se crea la conexion
                sqlConnection.Open();//Abrimos la conexion
                sqlCommand = new SqlCommand("spInsertarClientes",sqlConnection);//Recibo el nombre del procedimiento
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parametros que recibe este procedimiento 
                sqlCommand.Parameters.Add(new SqlParameter("@nIdentificacion", lnIdentifcicacion));
                sqlCommand.Parameters.Add(new SqlParameter("@cNombres", stNombres));
                sqlCommand.Parameters.Add(new SqlParameter("@cApellidos", stApellidos));
                //Parametros que recibe este procedimiento 

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@cMensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                return sqlParameter.Value.ToString(); ;
            }catch(Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }
        //METODO MODIFICAR
        public string stModifcarClientes(long lnIdentifcicacion, string stNombres, string stApellidos)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion); //Aqui se crea la conexion
                sqlConnection.Open();//Abrimos la conexion
                sqlCommand = new SqlCommand("spModificarClientes", sqlConnection);//Recibo el nombre del procedimiento
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parametros que recibe este procedimiento 
                sqlCommand.Parameters.Add(new SqlParameter("@nIdentificacion", lnIdentifcicacion));
                sqlCommand.Parameters.Add(new SqlParameter("@cNombres", stNombres));
                sqlCommand.Parameters.Add(new SqlParameter("@cApellidos", stApellidos));
                //Parametros que recibe este procedimiento 

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@cMensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                var parametroMSalida = sqlParameter.Value.ToString();
                return parametroMSalida;
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }
        // METODO ELIMINAR
        public string stEliminarClientes(long lnIdentifcicacion)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion); //Aqui se crea la conexion
                sqlConnection.Open();//Abrimos la conexion
                sqlCommand = new SqlCommand("spEliminarClientes", sqlConnection);//Recibo el nombre del procedimiento
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parametros que recibe este procedimiento 
                sqlCommand.Parameters.Add(new SqlParameter("@nIdentificacion", lnIdentifcicacion));
                //Parametros que recibe este procedimiento 

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@cMensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                var parametroMSalida = sqlParameter.Value.ToString();
                return parametroMSalida;
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }


    }
}
