namespace ColorCoder
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

      

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resistorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resistorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resistorsToolStripMenuItem
            // 
            this.resistorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bandToolStripMenuItem});
            this.resistorsToolStripMenuItem.Name = "resistorsToolStripMenuItem";
            this.resistorsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.resistorsToolStripMenuItem.Text = "Resistors";
            // 
            // bandToolStripMenuItem
            // 
            this.bandToolStripMenuItem.Name = "bandToolStripMenuItem";
            this.bandToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bandToolStripMenuItem.Text = "5 band";
            this.bandToolStripMenuItem.Click += new System.EventHandler(this.bandToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 583);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resistorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bandToolStripMenuItem;
    }
}