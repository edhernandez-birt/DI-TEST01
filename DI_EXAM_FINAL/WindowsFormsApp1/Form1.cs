using ProyectoBLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UtilidadesNW;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private UserControl quesitoUserControl;
        private UserControl quesito2;
        public Form1()
        {
            InitializeComponent();
            quesitoUserControl = new UserControls.UserControlTest();
            quesito2 = new UserControls.UserControlTest2();
        }

        private void buttonCadena_Click(object sender, EventArgs e)
        {
            //Llamar al BLL y pintar en textBox

            textBoxCadena.Text = ClaseBLL.PideCadenaDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Resetea puntos de las series  https://stackoverflow.com/questions/11019086/net-chart-clear-and-re-add
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

             //https://help.syncfusion.com/windowsforms/chart/overview
            List<FacturacionRegionesDTO> datosRegiones;
            datosRegiones = ClaseBLL.PideListaFacturacionRegiones();

            chart1.Series["Series1"].IsValueShownAsLabel = true;
            for (int i = 0; i < datosRegiones.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(datosRegiones[i].RegionNombre, datosRegiones[i].RegionFacturacion);
            }

            //https://stackoverflow.com/questions/20204007/change-an-asp-net-chart-label-to-value-and-then-format-only-chart-not-legend
            foreach (Series b in chart1.Series)
            {

                //b.Label = "#VALY{#,##0$}";
                b.Label = "#VALY{#,##0$}";
                // b.LegendText = "#VALX";
                b.LegendText = "#VALX #PERCENT";
            }
        }

        private void buttonDataGridView_Click(object sender, EventArgs e)
        {
            List<FacturacionRegionesDTO> datosRegiones;
            datosRegiones = ClaseBLL.PideListaFacturacionRegiones();
            dataGridView1.DataSource = datosRegiones;
        }

        private void buttonUC_Click(object sender, EventArgs e)
        {

            if (tlpCentro.Controls.Contains(quesitoUserControl))
            {
                //this.newPanelButton.Click -= new System.EventHandler(this.
                //   NewPanelButton_Click);
                tlpCentro.Controls.Remove(quesitoUserControl);
                //   quesitoUserControl.Dispose();
            }

            //System.Collections.IList list = tlpCentro.Controls;
            //for (int i = 0; i < list.Count; i++){
            //    if (list[i].GetType().Equals(typeof(UserControls.UserControlTest)))
            //    {
            //        Console.WriteLine("Limpia UC");
            //        UserControl uc = (UserControl)list[i];
            //        tlpCentro.Controls.Remove(uc);
            //    }
            //} 
            //Control control11 = tlpCentro.GetControlFromPosition(1, 1);
            //control11.GetType();

            //if (tlpCentro.Controls.Contains(quesitoUserControl))
            //{
            //    tlpCentro.Controls.Remove(quesitoUserControl);
            //}

            tlpCentro.Controls.Add(quesitoUserControl, 1, 1);
        }

        private void buttonUC2_Click(object sender, EventArgs e)
        {
            if (tlpCentro.Controls.Contains(quesitoUserControl))
            {
                //this.newPanelButton.Click -= new System.EventHandler(this.
                //   NewPanelButton_Click);
                tlpCentro.Controls.Remove(quesitoUserControl);
                //   quesitoUserControl.Dispose();
            } else if (tlpCentro.Controls.Contains(quesito2))
            {
                tlpCentro.Controls.Remove(quesito2);
            }

            //if (tlpCentro.Controls.Contains(quesitoUserControl))
            //{
            //    tlpCentro.Controls.Remove(quesitoUserControl);
            //}
            tlpCentro.Controls.Add(quesito2, 1, 1);
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopUp popUp = new PopUp("Frase para el PopUp");
            popUp.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport fr = new FormReport();
            fr.Show();
        }
    }
    
}
