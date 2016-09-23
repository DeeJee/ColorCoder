using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ColorCoder
{
    public partial class FirstBand : Form
    {
        public ResistorColor ResistorColor { get; set; }
        public FirstBand()
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
            ResistorColor.Value = double.Parse((string)panel.Tag,CultureInfo.CreateSpecificCulture("en-us"));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
