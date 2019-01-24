namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.клиентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новКлиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настоящиКлиентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентиToolStripMenuItem,
            this.справкиToolStripMenuItem,
            this.данниToolStripMenuItem,
            this.изходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // клиентиToolStripMenuItem
            // 
            this.клиентиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новКлиентToolStripMenuItem,
            this.настоящиКлиентиToolStripMenuItem});
            this.клиентиToolStripMenuItem.Name = "клиентиToolStripMenuItem";
            this.клиентиToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.клиентиToolStripMenuItem.Text = "Clients";
            // 
            // новКлиентToolStripMenuItem
            // 
            this.новКлиентToolStripMenuItem.Name = "новКлиентToolStripMenuItem";
            this.новКлиентToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.новКлиентToolStripMenuItem.Text = "Import a Client";
            this.новКлиентToolStripMenuItem.Click += new System.EventHandler(this.новКлиентToolStripMenuItem_Click);
            // 
            // настоящиКлиентиToolStripMenuItem
            // 
            this.настоящиКлиентиToolStripMenuItem.Name = "настоящиКлиентиToolStripMenuItem";
            this.настоящиКлиентиToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.настоящиКлиентиToolStripMenuItem.Text = "Exporting data for the clients";
            this.настоящиКлиентиToolStripMenuItem.Click += new System.EventHandler(this.настоящиКлиентиToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операторToolStripMenuItem,
            this.търсенеToolStripMenuItem});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.справкиToolStripMenuItem.Text = "Reference";
            // 
            // операторToolStripMenuItem
            // 
            this.операторToolStripMenuItem.Name = "операторToolStripMenuItem";
            this.операторToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.операторToolStripMenuItem.Text = "Mobile operator";
            this.операторToolStripMenuItem.Click += new System.EventHandler(this.операторToolStripMenuItem_Click);
            // 
            // търсенеToolStripMenuItem
            // 
            this.търсенеToolStripMenuItem.Name = "търсенеToolStripMenuItem";
            this.търсенеToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.търсенеToolStripMenuItem.Text = "Searching";
            this.търсенеToolStripMenuItem.Click += new System.EventHandler(this.търсенеToolStripMenuItem_Click);
            // 
            // данниToolStripMenuItem
            // 
            this.данниToolStripMenuItem.Name = "данниToolStripMenuItem";
            this.данниToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.данниToolStripMenuItem.Text = "Data";
            this.данниToolStripMenuItem.Click += new System.EventHandler(this.данниToolStripMenuItem_Click);
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.изходToolStripMenuItem.Text = "Exit";
            this.изходToolStripMenuItem.Click += new System.EventHandler(this.изходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(684, 488);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Import/Export Data";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem клиентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новКлиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настоящиКлиентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данниToolStripMenuItem;
    }
}

