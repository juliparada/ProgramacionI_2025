using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Librería que me permite usar comandos para trabajar con Bases de Datos.
using System.Data.SqlClient; //Esta librería me permite trabajar con SQL Server.
//Librerias solo para ADO.NET

namespace PrimerProyectoCsharp
{
    internal class Conexion{
        //Definir miembros de la clase, atributos y métodos.

        //Atributos
        SqlConnection objConexion = new SqlConnection(); //Conectarme a la BD (agarro datos)
        SqlCommand objComandos = new SqlCommand(); //Ejecutar comandos SQL (ejecuto sentencias) lectura, eliminación, actualizar, etc
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //Puente entre la BD y la aplicación 
        DataSet objDs = new DataSet(); //Representación de la arquitectura de la BD en memoria (tablas, relaciones, etc)

        public Conexion(){ //Constructor: se llama así porque el método tiene el mismo nombre de la clase(Inicializador de los atributos)
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;//Definimos valor 
            objConexion.Open(); //Abro la conexión a la BD
        }

        public DataSet obtenerDatos(){
            objDs.Clear(); //Limpio el DataSet
            objComandos.Connection = objConexion; //Establezco la conexión para ejecutar comandos

            objAdaptador.SelectCommand = objComandos; //Establezco el comando de selección

            objComandos.CommandText = "SELECT * FROM alumnos"; // "SELECT(seleccione) *(TODOS los campos"idAlumnos, direccion, telefono, nombre") FROM(de la tabla) Alumnos"
            objAdaptador.Fill(objDs, "alumnos"); //Tomo los datos de la BD y los lleno en el DataSet

            return objDs;//Devolvemos el DataSet con los datos
        }

        public string administrarDatosAlumnos(String[] datos, string accion){
            String sql = "";
            if (accion== "nuevo"){
                sql = "INSERT INTO alumnos (codigo, nombre, direccion, telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
            }else if (accion== "modificar"){
                sql = "UPDATE alumnos SET codigo=@codigo, nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE idAlumno=@idAlumno";
            }else if (accion== "eliminar"){
                sql = "DELETE FROM alumnos WHERE idAlumno=@idAlumno";
            }
            return ejecutarSQL(sql, datos);
        }

        private String ejecutarSQL(String sql, String[] datos){ //try catch para manejar errores
            try { 
                objComandos.Connection = objConexion; //Establezco la conexión para ejecutar comandos
                objComandos.CommandText = sql; //Establezco el comando de selección

                objComandos.Parameters.Clear(); //Limpio los parámetros anteriores

                objComandos.Parameters.AddWithValue("@idAlumno", datos[0]);
                objComandos.Parameters.AddWithValue("@codigo", datos[1]);
                objComandos.Parameters.AddWithValue("@nombre", datos[2]);
                objComandos.Parameters.AddWithValue("@direccion", datos[3]);
                objComandos.Parameters.AddWithValue("@telefono", datos[4]);

                return objComandos.ExecuteNonQuery().ToString();//Ejecuta el comando y devuelve la cantidad de filas afectadas
            }
            catch (Exception ex) {
                return ex.Message;
            }

        }
    }
}
