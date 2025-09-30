using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Figure
    {
        protected Color figureColor;

        public Figure() { figureColor = Color.White; }
        public Figure(Color figureColor)
        {
            this.figureColor = figureColor;
        }

        public Color GetColor() { return figureColor; }

        public void ChangeColor(Color newColor)
        {
            try
            {
                figureColor = newColor;
            }
            catch { MessageBox.Show($"Неверный цвет{newColor.ToString}", "Ошибка"); }
        }
    }
}
