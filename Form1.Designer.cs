namespace Figure
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RectangleBox = new PictureBox();
            buttonColor = new Button();
            buttonPaintAble = new Button();
            buttonDrawAble = new Button();
            buttonSquare = new Button();
            labelColor = new Label();
            ((System.ComponentModel.ISupportInitialize)RectangleBox).BeginInit();
            SuspendLayout();
            // 
            // RectangleBox
            // 
            RectangleBox.Location = new Point(10, 10);
            RectangleBox.Name = "RectangleBox";
            RectangleBox.Size = new Size(300, 250);
            RectangleBox.TabIndex = 0;
            RectangleBox.TabStop = false;
            // 
            // buttonColor
            // 
            buttonColor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonColor.Location = new Point(316, 28);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(156, 33);
            buttonColor.TabIndex = 1;
            buttonColor.Text = "Смена цвета";
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // buttonPaintAble
            // 
            buttonPaintAble.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPaintAble.Location = new Point(316, 67);
            buttonPaintAble.Name = "buttonPaintAble";
            buttonPaintAble.Size = new Size(156, 33);
            buttonPaintAble.TabIndex = 2;
            buttonPaintAble.Text = "Закрашивание";
            buttonPaintAble.UseVisualStyleBackColor = true;
            buttonPaintAble.Click += buttonPaintAble_Click;
            // 
            // buttonDrawAble
            // 
            buttonDrawAble.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDrawAble.Location = new Point(316, 106);
            buttonDrawAble.Name = "buttonDrawAble";
            buttonDrawAble.Size = new Size(156, 33);
            buttonDrawAble.TabIndex = 3;
            buttonDrawAble.Text = "Рисование";
            buttonDrawAble.UseVisualStyleBackColor = true;
            buttonDrawAble.Click += buttonDrawAble_Click;
            // 
            // buttonSquare
            // 
            buttonSquare.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSquare.Location = new Point(316, 145);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(156, 33);
            buttonSquare.TabIndex = 4;
            buttonSquare.Text = "Площадь";
            buttonSquare.UseVisualStyleBackColor = true;
            buttonSquare.Click += buttonSquare_Click;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(10, 263);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(36, 15);
            labelColor.TabIndex = 5;
            labelColor.Text = "Цвет:";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(484, 321);
            Controls.Add(labelColor);
            Controls.Add(buttonSquare);
            Controls.Add(buttonDrawAble);
            Controls.Add(buttonPaintAble);
            Controls.Add(buttonColor);
            Controls.Add(RectangleBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Rectangle Windows";
            ((System.ComponentModel.ISupportInitialize)RectangleBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonColor;
        private Button buttonPaintAble;
        private Button buttonDrawAble;
        private Button buttonSquare;
        private Label labelColor;
        public PictureBox RectangleBox;
    }
}
