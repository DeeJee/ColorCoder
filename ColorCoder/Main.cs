using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorCoder
{
    public partial class Main : Form
    {
        Resistor5Bands resistor5bands;

        public Main()
        {
            InitializeComponent();
        }

        private void bandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resistor5bands = new Resistor5Bands();
            resistor5bands.MdiParent = this;
            resistor5bands.Show();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DisposeResource(components);
                DisposeResource(resistor5bands);
            }
            base.Dispose(disposing);
        }

        private void DisposeResource(IDisposable disposable)
        {
            if (disposable != null)
            {
                disposable.Dispose();
            }
        }
    }
}
