using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace PrimerProyectoCsharp
{
    // Clase para gestionar la conexión y operaciones con la base de datos
    internal class Conexion
    {
        SqlConnection objConexion = new SqlConnection();

        public Conexion()
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;}

        public DataSet obtenerDatos()
        {
            try
            {
                DataSet ds = new DataSet();
                using (SqlCommand cmd = new SqlCommand())
                using (SqlDataAdapter adaptador = new SqlDataAdapter())
                {
                    cmd.Connection = objConexion;
                    if (objConexion.State != ConnectionState.Open)
                        objConexion.Open();

                    cmd.CommandText = "SELECT * FROM alumnos";
                    adaptador.SelectCommand = cmd;
                    adaptador.Fill(ds, "alumnos");

                    cmd.CommandText = "SELECT * FROM docente";
                    adaptador.Fill(ds, "docente");

                    cmd.CommandText = "SELECT * FROM materias";
                    adaptador.Fill(ds, "materias");

                    objConexion.Close();
                }
                return ds;
            }
            catch (Exception ex)
            {
                LogError("Error al obtener datos: " + ex.Message, ex);
                if (objConexion.State == ConnectionState.Open)
                    objConexion.Close();
                throw new Exception("Error al obtener datos de la base de datos.", ex);
            }
        }

        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            try
            {
                if (accion == "nuevo" && (datos.Length < 5 || datos.Skip(1).Any(d => string.IsNullOrWhiteSpace(d))))
                    return "Datos insuficientes o vacíos para crear un alumno.";
                if (accion == "modificar" && (datos.Length < 5 || datos.Any(d => string.IsNullOrWhiteSpace(d))))
                    return "Datos insuficientes o vacíos para modificar un alumno.";
                if (accion == "eliminar" && (datos.Length < 1 || string.IsNullOrWhiteSpace(datos[0])))
                    return "ID de alumno requerido para eliminar.";

                string sql = "";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = objConexion;

                    if (accion == "nuevo")
                    {
                        // Inserta un nuevo alumno
                        sql = "INSERT INTO alumnos(codigo, nombre, direccion, telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@codigo", datos[1]);
                        cmd.Parameters.AddWithValue("@nombre", datos[2]);
                        cmd.Parameters.AddWithValue("@direccion", datos[3]);
                        cmd.Parameters.AddWithValue("@telefono", datos[4]);
                    }
                    else if (accion == "modificar")
                    {
                        // Modifica un alumno existente
                        sql = "UPDATE alumnos SET codigo=@codigo, nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE idAlumno=@idAlumno";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@codigo", datos[1]);
                        cmd.Parameters.AddWithValue("@nombre", datos[2]);
                        cmd.Parameters.AddWithValue("@direccion", datos[3]);
                        cmd.Parameters.AddWithValue("@telefono", datos[4]);
                        cmd.Parameters.AddWithValue("@idAlumno", datos[0]);
                    }
                    else if (accion == "eliminar")
                    {
                        // Elimina un alumno por id
                        sql = "DELETE FROM alumnos WHERE idAlumno=@idAlumno";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@idAlumno", datos[0]);
                    }

                    return ejecutarSQL(cmd);
                }
            }
            catch (Exception ex)
            {
                LogError("Error general en administrarDatosAlumnos: " + ex.Message, ex);
                return "Ocurrió un error inesperado.";
            }
        }

        public string administrarDatosDocente(String[] datos, String accion)
        {
            try
            {
                if (accion == "nuevo" && (datos.Length < 5 || datos.Skip(1).Any(d => string.IsNullOrWhiteSpace(d))))
                    return "Datos insuficientes o vacíos para crear un docente.";
                if (accion == "modificar" && (datos.Length < 5 || datos.Any(d => string.IsNullOrWhiteSpace(d))))
                    return "Datos insuficientes o vacíos para modificar un docente.";
                if (accion == "eliminar" && (datos.Length < 1 || string.IsNullOrWhiteSpace(datos[0])))
                    return "ID de docente requerido para eliminar.";

                string sql = "";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = objConexion;

                    if (accion == "nuevo")
                    {
                        // Inserta un nuevo docente
                        sql = "INSERT INTO docente(codigo, nombre, direccion, telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@codigo", datos[1]);
                        cmd.Parameters.AddWithValue("@nombre", datos[2]);
                        cmd.Parameters.AddWithValue("@direccion", datos[3]);
                        cmd.Parameters.AddWithValue("@telefono", datos[4]);
                    }
                    else if (accion == "modificar")
                    {
                        // Modifica un docente existente
                        sql = "UPDATE docente SET codigo=@codigo, nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE idDocente=@idDocente";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@codigo", datos[1]);
                        cmd.Parameters.AddWithValue("@nombre", datos[2]);
                        cmd.Parameters.AddWithValue("@direccion", datos[3]);
                        cmd.Parameters.AddWithValue("@telefono", datos[4]);
                        cmd.Parameters.AddWithValue("@idDocente", datos[0]);
                    }
                    else if (accion == "eliminar")
                    {
                        // Elimina un docente por id
                        sql = "DELETE FROM docente WHERE idDocente=@idDocente";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@idDocente", datos[0]);
                    }

                    return ejecutarSQL(cmd);
                }
            }
            catch (Exception ex)
            {
                LogError("Error general en administrarDatosDocente: " + ex.Message, ex);
                return "Ocurrió un error inesperado.";
            }
        }

        public string administrarDatosMaterias(String[] datos, String accion)
        {
            try
            {
                if (accion == "nuevo" && (datos.Length < 4 || datos.Skip(1).Any(d => string.IsNullOrWhiteSpace(d))))
                    return "Datos insuficientes o vacíos para crear una materia.";
                if (accion == "modificar" && (datos.Length < 4 || datos.Any(d => string.IsNullOrWhiteSpace(d))))
                    return "Datos insuficientes o vacíos para modificar una materia.";
                if (accion == "eliminar" && (datos.Length < 1 || string.IsNullOrWhiteSpace(datos[0])))
                    return "ID de materia requerido para eliminar.";

                string sql = "";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = objConexion;

                    if (accion == "nuevo")
                    {
                        // Inserta una nueva materia
                        sql = "INSERT INTO materias(codigo, nombre, uv) VALUES (@codigo, @nombre, @uv)";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@codigo", datos[1]);
                        cmd.Parameters.AddWithValue("@nombre", datos[2]);
                        cmd.Parameters.AddWithValue("@uv", datos[3]);
                    }
                    else if (accion == "modificar")
                    {
                        // Modifica una materia existente
                        sql = "UPDATE materias SET codigo=@codigo, nombre=@nombre, uv=@uv WHERE idMateria=@idMateria";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@codigo", datos[1]);
                        cmd.Parameters.AddWithValue("@nombre", datos[2]);
                        cmd.Parameters.AddWithValue("@uv", datos[3]);
                        cmd.Parameters.AddWithValue("@idMateria", datos[0]);
                    }
                    else if (accion == "eliminar")
                    {
                        // Elimina una materia por id
                        sql = "DELETE FROM materias WHERE idMateria=@idMateria";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@idMateria", datos[0]);
                    }

                    return ejecutarSQL(cmd);
                }
            }
            catch (Exception ex)
            {
                LogError("Error general en administrarDatosMaterias: " + ex.Message, ex);
                return "Ocurrió un error inesperado.";
            }
        }

        // Ejecuta el comando SQL recibido y maneja errores
        private string ejecutarSQL(SqlCommand cmd)
        {
            try
            {
                if (objConexion.State != ConnectionState.Open)
                    objConexion.Open();

                cmd.Connection = objConexion;
                string result = cmd.ExecuteNonQuery().ToString();

                objConexion.Close();
                return result;
            }
            catch (Exception ex)
            {
                LogError("Error en ejecutarSQL: " + ex.Message, ex);
                if (objConexion.State == ConnectionState.Open)
                    objConexion.Close();
                throw new Exception("Error al ejecutar la operación en la base de datos.", ex);
            }
        }

        // Método para registrar errores en un archivo de log
        private void LogError(string mensaje, Exception ex)
        {
            try
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory + "errores_conexion.log";
                using (StreamWriter sw = new StreamWriter(ruta, true))
                {
                    sw.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {mensaje}");
                    sw.WriteLine(ex.ToString());
                    sw.WriteLine("--------------------------------------------------");
                }
            }
            catch
            {
                // Si falla el log, no hacer nada para no interrumpir la aplicación
            }
        }
    }
}
