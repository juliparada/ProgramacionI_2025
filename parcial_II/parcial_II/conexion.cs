using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient; 


namespace parcial_II
{
    internal class conexion{
        SqlConnection objConexion = new SqlConnection(); //Conectarme a la BD.
        SqlCommand objComando = new SqlCommand(); //Ejecutar SQL en la BD. Lectura, Actualizacion, Eliminacion, Insercion.
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //un puente entre la BD y la aplicacion.
        DataSet objDs = new DataSet(); //Es una representacion de la arquitectura de la BD en memoria.

        public conexion()
        { //Constructor. inicializador de los atributos
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_parcialII.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD
        }
        public DataSet obtenerDatos()
        {
            objDs.Clear(); //Limpiar el DataSet
            objComando.Connection = objConexion; //Establecer la conexion para ejecutar los comandos.

            objAdaptador.SelectCommand = objComando; //Establecer el comando de seleccion

            objComando.CommandText = "SELECT * FROM usuarios";
            objAdaptador.Fill(objDs, "usuarios");//Tomando los datos de la BD y llenando el DataSet

            return objDs;
        }
        public string administrarDatosUsuarios(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO usuarios(idUsuarios,clave,usuario,nombre,direccion,telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '" + datos[5] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE usuarios SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" + datos[4] + "' WHERE idAlumno='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM usuarios WHERE idUsuario='" + datos[0] + "'";
            }
            return ejecutarSQL(sql, datos);
        }
        private String ejecutarSQL(String sql, String[] datos)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


    }
}