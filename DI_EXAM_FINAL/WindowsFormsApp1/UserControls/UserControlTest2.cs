using ProyectoBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UtilidadesNW;

namespace WindowsFormsApp1.UserControls
{
    public partial class UserControlTest2 : UserControl
    {
        public UserControlTest2()
        {
            InitializeComponent();
            // Resetea puntos de las series  https://stackoverflow.com/questions/11019086/net-chart-clear-and-re-add
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }

            //https://help.syncfusion.com/windowsforms/chart/overview
            List<FacturacionRegionesDTO> datosRegiones;
            datosRegiones = ClaseBLL.PideListaFacturacionRegiones();
            chart2.Series["Series1"].IsValueShownAsLabel = true;
            for (int i = 0; i < datosRegiones.Count; i++)
            {
                chart2.Series["Series1"].Points.AddXY(datosRegiones[i].RegionNombre, datosRegiones[i].RegionFacturacion);
            }

        }
    }
}
