using System.Drawing;
namespace ColorCoder
{
    public class ResistorColor
    {
        public Color Color { get; set; }
        public double Value { get; set; }
        public ResistorColor()
        {

        }
        public ResistorColor(Color color, double value)
        {
            Color = color;
            Value = value;
        }
    }
}
