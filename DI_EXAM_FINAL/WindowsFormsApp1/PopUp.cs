using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PopUp : Form
    {
        public PopUp(string frase)
        {
            InitializeComponent();

        }

        private void ayudaCHMToolStripMenuItem_Click(object sender, EventArgs e)
        {
 //           Help.ShowHelp(this, @"D:\Usuarios\eduh\Documentos\ULHI\DI\DI_EXAM_FINAL\WindowsFormsApp1\Resources\AyudaDashboard.chm");
 
            Console.WriteLine("Abrir help");
            Console.WriteLine(Environment.CurrentDirectory);
            Help.ShowHelp(this, @"..\..\Resources\AyudaDashboard.chm");
            
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
