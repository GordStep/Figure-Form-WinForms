namespace Figure
{
    public partial class Form1 : Form
    {
        Rectangle rectangle = new Rectangle();
        int indOfColor = 0;
        List<Color> colors = new List<Color>()
        {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Magenta,
            Color.Yellow
        };
        public Form1()
        {
            InitializeComponent();
            LabelUpdate();
        }

        private void LabelUpdate()
        {
            labelColor.Text = "Цвет: " + rectangle.GetColor().Name;
        }

        public void FormPaintAble(Color color)
        {
            rectangle.paintAble();
            RectangleBox.BackColor = color;
            RectangleBox.Update();
        }

        public void FormDrawAble()
        {
            rectangle.drawAble();
            RectangleBox.BorderStyle = BorderStyle.Fixed3D;
            RectangleBox.Update();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (indOfColor < 4)
            {
                indOfColor++;
                rectangle.ChangeColor(colors[indOfColor]);
            }
            else
            {
                indOfColor = 0;
                rectangle.ChangeColor(colors[indOfColor]);
            }
            LabelUpdate();
        }

        private void buttonPaintAble_Click(object sender, EventArgs e)
        {
            rectangle.paintAble();
            FormPaintAble(rectangle.GetColor());
        }

        private void buttonDrawAble_Click(object sender, EventArgs e)
        {
            rectangle.drawAble();
            FormDrawAble();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            double S = rectangle.calculationSquare(RectangleBox.Width, RectangleBox.Height);

            MessageBox.Show($"Площадь прямоугольника: {S}", "Площадь");
        }
    }
}
