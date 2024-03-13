using HC.View;
using SkiaSharp;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void skControl1_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var canvas = e.Surface.Canvas;
            canvas.Clear(SKColors.White);
            SKPaint text_paint = new SKPaint
            {
                TextSize = 16,
                IsAntialias = true,
                Color = SKColors.Black,
                TextAlign = SKTextAlign.Left,
                Typeface = SkiaChinaFont.ChinaFont,
            };
            canvas.DrawText("1234567890我是中国人", 50, 50, text_paint);
        }
    }
}
