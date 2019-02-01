using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAbrirDocumento.Filter = "Archivos csv (*.csv)|*.csv|Documentos Excel 2003 (*.xls)|*.xls|Documentos Excel 2007-2010 (*.xlsx)|*.xlsx";
                DataTable DtReporte196 = new DataTable();

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        public DataTable(String ruta196)   
        {
            try
            {
                String LineaTexto = String.Empty;
                String nombre_archivo196;
                DataTable dtReporte196 = new DataTable("Reporte196");

                dtReporte196.Columns.Add("Unidad de Negocio", typeof(String));
                dtReporte196.Columns.Add("Fecha", typeof(DateTime));
                dtReporte196.Columns.Add("PPU", typeof(String));
                dtReporte196.Columns.Add("Tipo de GPS", typeof(String));
                dtReporte196.Columns.Add("Servicio", typeof(String));
                dtReporte196.Columns.Add("Sentido", typeof(String));
                dtReporte196.Columns.Add("Intervalo", typeof(String));
                dtReporte196.Columns.Add("Operativo",typeof(String));
                dtReporte196.Columns.Add("KM Intervalo", typeof(Double));
                dtReporte196.Columns.Add("KM del viaje en intervalo", typeof(Double));
                dtReporte196.Columns.Add("Fecha Inicio Viaje", typeof(DateTime));
                dtReporte196.Columns.Add("Fecha Fin Viaje",typeof(DateTime));
                dtReporte196.Columns.Add("Tiempo de este viaje", typeof(Double));
                dtReporte196.Columns.Add("Tiempo total de viaje del intervalo", typeof(Double));
                dtReporte196.Columns.Add("Tiempo de Viaje", typeof(String));
                dtReporte196.Columns.Add("Inicio y Fin de Ruta", typeof(String));
                dtReporte196.Columns.Add("120 Minutos Antes", typeof(String));
                dtReporte196.Columns.Add("120 Minutos Despues", typeof(String));
                dtReporte196.Columns.Add("PC cada 2 Km", typeof(String));
                dtReporte196.Columns.Add("Igual Servicio", typeof(String));

                String[] SplitLine; ;
                Int32 intContador=0;
                nombre_archivo196 = System.IO.Path.GetFileName(ruta196);

                label1.Text = nombre_archivo196;

                if (System.IO.File.Exists(ruta196) == true)
                {
                    Int32 contColumnas = 0;
                    var objReader = new System.IO.StreamReader(ruta196);
                    while (objReader.Peek() != -1)
                    {
                        LineaTexto = objReader.ReadLine();
                        SplitLine = LineaTexto.Split(';');
                        contColumnas = SplitLine.Count();

                        if (intContador > 7)
                        {
                            Dictionary<String, String> diccionario = new Dictionary<string, string>();
                            diccionario.Add("I", "Ida");
                            diccionario.Add("IDA", "Ida");
                            diccionario.Add("R", "Ret");
                            diccionario.Add("RETORNO", "Ret");
                            diccionario.Add("REGRESO", "Ret");

                            String unidad_negocio = SplitLine[0].Trim();
                            String PPU = SplitLine[2].Trim();
                            String GPS = SplitLine[3].Trim();
                            String Servicio = SplitLine[4].Replace(" ","").ToUpper();
                            String Sentido = SplitLine[5].Trim().ToUpper();
                            String Intervalo = SplitLine[6].Trim();
                            String Operativo = SplitLine[7].Trim();
                        }
                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            


        }
    }
}
