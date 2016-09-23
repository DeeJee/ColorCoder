using System.Windows.Forms;

namespace ColorCoder
{
    public partial class Resistor5Bands : Form
    {
        double[] values = new double[4];


        public Resistor5Bands()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            using (var frm = new FirstBand())
            {
                PositionForm(frm);
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    panel.BackColor = frm.ResistorColor.Color;
                    Band1.BackColor = frm.ResistorColor.Color;
                    values[0] = frm.ResistorColor.Value;
                    CalculateValue();
                }
            }
        }   

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            using (var frm = new SecondBand())
            {
                PositionForm(frm);
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    panel.BackColor = frm.ResistorColor.Color;
                    Band2.BackColor = frm.ResistorColor.Color;
                    values[1] = frm.ResistorColor.Value;
                    CalculateValue();
                }
            }
        }


        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            using (var frm = new ThirdBand())
            {
                PositionForm(frm);
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    panel.BackColor = frm.ResistorColor.Color;
                    Band3.BackColor = frm.ResistorColor.Color;
                    values[2] = frm.ResistorColor.Value;
                    CalculateValue();
                }
            }
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            using (var frm = new FourthBand())
            {
                PositionForm(frm);
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    panel.BackColor = frm.ResistorColor.Color;
                    Band4.BackColor = frm.ResistorColor.Color;
                    values[3] = frm.ResistorColor.Value;
                    CalculateValue();
                }
            }
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            using (var frm = new Tolerance())
            {
                PositionForm(frm);
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    panel.BackColor = frm.ResistorColor.Color;
                    Band5.BackColor = frm.ResistorColor.Color;
                    Tolerance.Text = frm.ResistorColor.Value.ToString() + "%";
                }
            }
        }

        private void PositionForm(Form frm)
        {
            frm.StartPosition = FormStartPosition.Manual;
            var position = Cursor.Position;
            position.X -= frm.Width / 2;
            position.Y -= frm.Height / 2;
            frm.Location = position;
        }
        private void CalculateValue()
        {
            double value = (values[0] * 100 + values[1] * 10 + values[2]) * values[3];
            Resistance.Text = value.ToString();
        }
    }
}
