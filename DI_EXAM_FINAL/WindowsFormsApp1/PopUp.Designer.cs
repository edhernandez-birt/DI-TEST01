
namespace WindowsFormsApp1
{
    partial class PopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelPopUp = new System.Windows.Forms.Label();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaCHMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.textBoxPopUp = new System.Windows.Forms.TextBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelPopUp
            // 
            this.labelPopUp.AutoSize = true;
            this.labelPopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this.labelPopUp, "");
            this.helpProvider1.SetHelpString(this.labelPopUp, "Label del popUp");
            this.labelPopUp.Location = new System.Drawing.Point(120, 30);
            this.labelPopUp.Name = "labelPopUp";
            this.helpProvider1.SetShowHelp(this.labelPopUp, true);
            this.labelPopUp.Size = new System.Drawing.Size(121, 32);
            this.labelPopUp.TabIndex = 1;
            this.labelPopUp.Text = "POP UP";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaCHMToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaCHMToolStripMenuItem
            // 
            this.ayudaCHMToolStripMenuItem.Name = "ayudaCHMToolStripMenuItem";
            this.ayudaCHMToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ayudaCHMToolStripMenuItem.Text = "Ayuda CHM";
            this.ayudaCHMToolStripMenuItem.Click += new System.EventHandler(this.ayudaCHMToolStripMenuItem_Click);
            // 
            // textBoxPopUp
            // 
            this.textBoxPopUp.Location = new System.Drawing.Point(47, 108);
            this.textBoxPopUp.Multiline = true;
            this.textBoxPopUp.Name = "textBoxPopUp";
            this.textBoxPopUp.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBoxPopUp, false);
            this.textBoxPopUp.Size = new System.Drawing.Size(274, 78);
            this.textBoxPopUp.TabIndex = 2;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(246, 218);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 3;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.textBoxPopUp);
            this.Controls.Add(this.labelPopUp);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopUp";
            this.Text = "PopUp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelPopUp;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaCHMToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox textBoxPopUp;
        private System.Windows.Forms.Button buttonCerrar;
    }
}