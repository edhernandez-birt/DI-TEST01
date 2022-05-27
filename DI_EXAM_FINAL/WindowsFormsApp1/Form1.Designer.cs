
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tlpGrande = new System.Windows.Forms.TableLayoutPanel();
            this.tlpVertical = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUC2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCadena = new System.Windows.Forms.Button();
            this.buttonDataGridView = new System.Windows.Forms.Button();
            this.buttonUC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpCentro = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCadena = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTipForm = new System.Windows.Forms.ToolTip(this.components);
            this.tlpGrande.SuspendLayout();
            this.tlpVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tlpCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpGrande
            // 
            this.tlpGrande.ColumnCount = 2;
            this.tlpGrande.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpGrande.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpGrande.Controls.Add(this.tlpVertical, 0, 2);
            this.tlpGrande.Controls.Add(this.pictureBox1, 0, 1);
            this.tlpGrande.Controls.Add(this.menuStrip1, 1, 0);
            this.tlpGrande.Controls.Add(this.tlpCentro, 1, 2);
            this.tlpGrande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGrande.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tlpGrande.Location = new System.Drawing.Point(0, 0);
            this.tlpGrande.Margin = new System.Windows.Forms.Padding(4);
            this.tlpGrande.Name = "tlpGrande";
            this.tlpGrande.RowCount = 3;
            this.tlpGrande.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpGrande.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpGrande.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpGrande.Size = new System.Drawing.Size(1904, 1040);
            this.tlpGrande.TabIndex = 0;
            // 
            // tlpVertical
            // 
            this.tlpVertical.ColumnCount = 1;
            this.tlpVertical.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVertical.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpVertical.Controls.Add(this.buttonUC2, 0, 4);
            this.tlpVertical.Controls.Add(this.button2, 0, 1);
            this.tlpVertical.Controls.Add(this.buttonCadena, 0, 0);
            this.tlpVertical.Controls.Add(this.buttonDataGridView, 0, 2);
            this.tlpVertical.Controls.Add(this.buttonUC, 0, 3);
            this.tlpVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVertical.Location = new System.Drawing.Point(4, 212);
            this.tlpVertical.Margin = new System.Windows.Forms.Padding(4);
            this.tlpVertical.Name = "tlpVertical";
            this.tlpVertical.RowCount = 5;
            this.tlpVertical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVertical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVertical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVertical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVertical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVertical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVertical.Size = new System.Drawing.Size(372, 824);
            this.tlpVertical.TabIndex = 0;
            // 
            // buttonUC2
            // 
            this.buttonUC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUC2.Location = new System.Drawing.Point(4, 660);
            this.buttonUC2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUC2.Name = "buttonUC2";
            this.buttonUC2.Size = new System.Drawing.Size(364, 160);
            this.buttonUC2.TabIndex = 4;
            this.buttonUC2.Text = "UserControl 2";
            this.buttonUC2.UseVisualStyleBackColor = true;
            this.buttonUC2.Click += new System.EventHandler(this.buttonUC2_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 166);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(366, 160);
            this.button2.TabIndex = 1;
            this.button2.Text = "Grafica Regiones Circular";
            this.toolTipForm.SetToolTip(this.button2, "Grafico quesito regiones");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCadena
            // 
            this.buttonCadena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCadena.Location = new System.Drawing.Point(3, 2);
            this.buttonCadena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCadena.Name = "buttonCadena";
            this.buttonCadena.Size = new System.Drawing.Size(366, 160);
            this.buttonCadena.TabIndex = 0;
            this.buttonCadena.Text = "Cadena BD Categorias";
            this.toolTipForm.SetToolTip(this.buttonCadena, "Muestra texto de categorías");
            this.buttonCadena.UseVisualStyleBackColor = true;
            this.buttonCadena.Click += new System.EventHandler(this.buttonCadena_Click);
            // 
            // buttonDataGridView
            // 
            this.buttonDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDataGridView.Location = new System.Drawing.Point(3, 330);
            this.buttonDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDataGridView.Name = "buttonDataGridView";
            this.buttonDataGridView.Size = new System.Drawing.Size(366, 160);
            this.buttonDataGridView.TabIndex = 2;
            this.buttonDataGridView.Text = "DataGridView";
            this.buttonDataGridView.UseVisualStyleBackColor = true;
            this.buttonDataGridView.Click += new System.EventHandler(this.buttonDataGridView_Click);
            // 
            // buttonUC
            // 
            this.buttonUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUC.Location = new System.Drawing.Point(4, 496);
            this.buttonUC.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUC.Name = "buttonUC";
            this.buttonUC.Size = new System.Drawing.Size(364, 156);
            this.buttonUC.TabIndex = 3;
            this.buttonUC.Text = "UserControl";
            this.buttonUC.UseVisualStyleBackColor = true;
            this.buttonUC.Click += new System.EventHandler(this.buttonUC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTipForm.SetToolTip(this.pictureBox1, "Logo de NW");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(380, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1524, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirToolStripMenuItem.Text = "Abrir...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.manualToolStripMenuItem.Text = "PopUP";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // tlpCentro
            // 
            this.tlpCentro.ColumnCount = 2;
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentro.Controls.Add(this.textBoxCadena, 0, 0);
            this.tlpCentro.Controls.Add(this.chart1, 1, 0);
            this.tlpCentro.Controls.Add(this.dataGridView1, 0, 1);
            this.tlpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCentro.Location = new System.Drawing.Point(383, 210);
            this.tlpCentro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpCentro.Name = "tlpCentro";
            this.tlpCentro.RowCount = 2;
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCentro.Size = new System.Drawing.Size(1518, 828);
            this.tlpCentro.TabIndex = 3;
            // 
            // textBoxCadena
            // 
            this.textBoxCadena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCadena.Location = new System.Drawing.Point(3, 2);
            this.textBoxCadena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCadena.Multiline = true;
            this.textBoxCadena.Name = "textBoxCadena";
            this.textBoxCadena.ReadOnly = true;
            this.textBoxCadena.Size = new System.Drawing.Size(753, 410);
            this.textBoxCadena.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend2";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(762, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend2";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(753, 410);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Name = "Title1";
            title1.Text = "Titulo";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Frame;
            this.chart1.Titles.Add(title1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 416);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 410);
            this.dataGridView1.TabIndex = 2;
            // 
            // toolTipForm
            // 
            this.toolTipForm.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1040);
            this.Controls.Add(this.tlpGrande);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Formulario Test Examen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpGrande.ResumeLayout(false);
            this.tlpGrande.PerformLayout();
            this.tlpVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlpCentro.ResumeLayout(false);
            this.tlpCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGrande;
        private System.Windows.Forms.TableLayoutPanel tlpVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.Button buttonCadena;
        private System.Windows.Forms.TableLayoutPanel tlpCentro;
        private System.Windows.Forms.TextBox textBoxCadena;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUC;
        private System.Windows.Forms.Button buttonUC2;
        public System.Windows.Forms.ToolTip toolTipForm;
    }
}

