using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorCoder
{
    public partial class Tolerance : Form
    {
        public ResistorColor ResistorColor { get; set; }

        public Tolerance()
        {
            InitializeComponent();
            foreach (var ctrl in Controls.OfType<Panel>())
            {
                ctrl.MouseClick += PanelMouseClick;
            }
        }

        private void PanelMouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            ResistorColor = new ResistorColor();
            ResistorColor.Color = panel.BackColor;
            ResistorColor.Value = double.Parse((string)panel.Tag, CultureInfo.CreateSpecificCulture("en-us"));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
