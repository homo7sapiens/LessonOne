namespace LessonOne
{
    public class Sofa
    {
        public bool IsNew { get; set; }
        public decimal Weight { get; set; }
        public int SerialNumber { get; set; }
        public Color Color { get; set; }

        public void Paint(Color newColor)
        {
            Color = newColor;
        }
    }

    public enum Color
    {
        Red,
        Black,
        Blue
    }
}
