using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

//para conexion de ACcess
using System.Data.OleDb;

using System.Windows.Forms;

namespace pryCargasRapidasMolinaSP4
{
    internal class Clase_bd
    {
       
        
            //cadena de conexion
            //sql - string cadenaConexion = "Server=localhost;Database=Ventas2;Trusted_Connection=True;";
            string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\BaseDeDatos\\control_transporte.accdb";
            //conector
            //SqlConnection coneccionBaseDatos;
            OleDbConnection coneccionBaseDatos;
            //comando
            //SqlCommand comandoBaseDatos;
            OleDbCommand comandoBaseDatos;

            OleDbDataReader lectorDataReader;

            public string nombreBaseDeDatos;

            public void ConectarBD(System.Windows.Forms.ToolStripLabel lblMensaje)
            {
                try
                {
                    //coneccionBaseDatos = new SqlConnection(cadenaConexion);
                    coneccionBaseDatos = new OleDbConnection(cadenaConexion);

                    nombreBaseDeDatos = coneccionBaseDatos.Database;

                    coneccionBaseDatos.Open();

                    lblMensaje.Text = "Conexión Acces éxitosa";
                    lblMensaje.BackColor = System.Drawing.Color.LightGreen;
                   
                }
                catch (Exception error)
                {
                    lblMensaje.Text = error.Message;
                    lblMensaje.BackColor = System.Drawing.Color.LightCyan;
                }


            }

            public void cargarCategoria(ComboBox cmbcate)
            {
                //creo en memoria el objeto
                comandoBaseDatos = new OleDbCommand();
                //cargo la conexion a la base
                comandoBaseDatos.Connection = coneccionBaseDatos;

                //dar indicaciones 
                comandoBaseDatos.CommandType = System.Data.CommandType.Text;
                // sentencia SQL para consultar la base
                comandoBaseDatos.CommandText = "SELECT marca_nombre FROM productosuno";
                lectorDataReader = comandoBaseDatos.ExecuteReader();

                while (lectorDataReader.Read())
                {
                    cmbcate.Items.Add(lectorDataReader[0]);
                }
            }
            
        }
    }

