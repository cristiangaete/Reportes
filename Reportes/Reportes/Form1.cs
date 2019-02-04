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
        public static bool IsDate(Object obj)
        {
            string strDate = obj.ToString();
            try
            {
                DateTime dt = DateTime.Parse(strDate);
                if ((dt.Month != System.DateTime.Now.Month) || (dt.Day < 1 && dt.Day > 31) || dt.Year != System.DateTime.Now.Year)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsNumeric(String s)
        {
            return s.All(Char.IsDigit);
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Aqui se cargan y se leen los archivos cvs 

                ofdAbrirDocumento.Filter = "Archivos csv (*.csv)|*.csv|Documentos Excel 2003 (*.xls)|*.xls|Documentos Excel 2007-2010 (*.xlsx)|*.xlsx";

                if (ofdAbrirDocumento.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DataTable dtReporte196 = new DataTable();
                    dtReporte196 = GetDataCSV196(ofdAbrirDocumento.FileName);
                    dgvReporte196.DataSource = dtReporte196;
                    tabReportes.SelectedIndex = 0;
                }
               

               }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        public DataTable GetDataCSV196(string ruta196)   
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
                            String tiempos_viaje = SplitLine[14];
                            String Inicio_fin_ruta = SplitLine[15];
                            String min_120_antes = SplitLine[16];
                            String min_120_despues = SplitLine[17];
                            String pc_cada2km = SplitLine[18];
                            String igual_servicio = SplitLine[19];

                            ///Creamos las filas en el DataTable
                           
                            DataRow NuevaFila = dtReporte196.NewRow();

                            NuevaFila[0] = unidad_negocio;

                            if (IsDate(SplitLine[1]))
                            {
                                NuevaFila[1] = Convert.ToDateTime(SplitLine[1]);
                            }

                            NuevaFila[2] = PPU;
                            NuevaFila[3] = GPS;

                            NuevaFila[4] = Servicio;

                            NuevaFila[5] = Sentido;
                            NuevaFila[6] = Intervalo;
                            NuevaFila[7] = Operativo;

                            if (IsNumeric(SplitLine[8]))
                            {
                                NuevaFila[8] = SplitLine[8];
                            }

                            if (IsNumeric(SplitLine[9]))
                            {
                                NuevaFila[9] = SplitLine[9];
                            }

                            if (IsDate(SplitLine[10]))
                            {
                                NuevaFila[10] = Convert.ToDateTime(SplitLine[10]);
                            }

                            if (IsDate(SplitLine[11]))
                            {
                                NuevaFila[11] = Convert.ToDateTime(SplitLine[11]);
                            }

                            if (IsNumeric(SplitLine[12]))
                            {
                                NuevaFila[12] = SplitLine[12];
                            }

                            if (IsNumeric(SplitLine[13]))
                            {
                                NuevaFila[13] = SplitLine[13];
                            }

                            NuevaFila[14] = tiempos_viaje;
                            NuevaFila[15] = Inicio_fin_ruta;
                            NuevaFila[16] = min_120_antes;
                            NuevaFila[17] = min_120_despues;
                            NuevaFila[18] = pc_cada2km;
                            NuevaFila[19] = igual_servicio;

                            dtReporte196.Rows.Add(NuevaFila);

                        }
                        intContador = intContador + 1;
                    }
                    objReader.Close();

                }
                else
                {
                    MessageBox.Show("No Existe el Archivo");
                }
                return dtReporte196;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }

            
        }
    }
}
