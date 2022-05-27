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
    public partial class UserControlTest : UserControl
    {
        public UserControlTest()
        {
            InitializeComponent();
            // Resetea puntos de las series  https://stackoverflow.com/questions/11019086/net-chart-clear-and-re-add
            foreach (Series series in chartUc.Series)
            {
                series.Points.Clear();
            }
           

            //https://help.syncfusion.com/windowsforms/chart/overview
            List<FacturacionRegionesDTO> datosRegiones;
            datosRegiones = ClaseBLL.PideListaFacturacionRegiones();
            List<string> x1 = new List<string>();
            List<double> y1 = new List<double>();

            for (int i = 0; i < datosRegiones.Count; i++)
            {
                x1.Add(datosRegiones[i].RegionNombre);
                y1.Add(datosRegiones[i].RegionFacturacion);
            }

            //Para que ponga todos los datos en el eje X
            chartUc.ChartAreas[0].AxisX.Interval = 1;

            //OJO TO ARRAY
            chartUc.Series["Series1"].Points.DataBindXY(x1.ToArray(), y1.ToArray());

            chartUc.ChartAreas[0].AxisX.Title = "Region";
            chartUc.ChartAreas[0].AxisY.Title = "Facturacion Region";

            chartUc.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        }
    }
}
