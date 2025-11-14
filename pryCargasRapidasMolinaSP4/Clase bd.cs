using System;
using System.Collections.Generic;
//para conexion de ACcess
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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


                nombreBaseDeDatos = Path.GetFileName(coneccionBaseDatos.DataSource);
                coneccionBaseDatos.Open();

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
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

        public void cargarChart(Chart chtCamiones)
        {
            try
            {
                chtCamiones.Series.Clear();                
                chtCamiones.Series.Add("Camiones");
                chtCamiones.ChartAreas[0].AxisX.Title = "Camiones";
                chtCamiones.ChartAreas[0].AxisY.Maximum = 6000;                
                chtCamiones.ChartAreas[0].AxisY.Interval = 500;
                chtCamiones.ChartAreas[0].AxisY.Title = "Kilometros";
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = "SELECT Camión, Kilómetros FROM transporte";
                lectorDataReader = comandoBaseDatos.ExecuteReader();
                while (lectorDataReader.Read())
                {
                    string camion = lectorDataReader[0].ToString();
                    Int32 kilometros = Convert.ToInt32(lectorDataReader[1]);
                    int index = chtCamiones.Series[0].Points.AddY(kilometros);
                    chtCamiones.Series[0].Points[index].AxisLabel = camion;
                }


            }
            catch
            {
                MessageBox.Show("No se pudieron obtener los datos solicitados.");
            }
        }
        public void cargarChartGastos(Chart chtCamiones)
        {
            try
            {
                chtCamiones.Series.Add("Camiones");
                chtCamiones.ChartAreas[0].AxisX.Title = "Kilómetros";
                chtCamiones.ChartAreas[0].AxisY.Title = "Litros";
                chtCamiones.ChartAreas[0].AxisY.Maximum = 500;
                chtCamiones.ChartAreas[0].AxisY.Interval = 50;
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = "SELECT Camión, Litros FROM transporte";
                lectorDataReader = comandoBaseDatos.ExecuteReader();
                while (lectorDataReader.Read())
                {
                    string camion = lectorDataReader[0].ToString();
                    Int32 litros = Convert.ToInt32(lectorDataReader[1]);
                    int index = chtCamiones.Series[0].Points.AddY(litros);
                    chtCamiones.Series[0].Points[index].AxisLabel = camion;
                }
            }
            catch
            {
                MessageBox.Show("No se pudieron obtener los datos solicitados.");
            }

        }
        public void cargarChartKilog(Chart chtCamiones)
        {
            try
            {
                chtCamiones.Series.Add("Camiones");
                chtCamiones.ChartAreas[0].AxisX.Title = "Camiones";
                chtCamiones.ChartAreas[0].AxisY.Title = "kg";
                chtCamiones.ChartAreas[0].AxisY.Maximum = 500;
                chtCamiones.ChartAreas[0].AxisY.Interval = 50;
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = "SELECT Camión, Litros FROM transporte";
                lectorDataReader = comandoBaseDatos.ExecuteReader();
                while (lectorDataReader.Read())
                {
                    string camion = lectorDataReader[0].ToString();
                    Int32 litros = Convert.ToInt32(lectorDataReader[1]);
                    int index = chtCamiones.Series[0].Points.AddY(litros);
                    chtCamiones.Series[0].Points[index].AxisLabel = camion;
                }
            }
            catch
            {
                MessageBox.Show("No se pudieron obtener los datos solicitados.");
            }

        }
    }
}

