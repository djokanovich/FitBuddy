using System;
using System.Drawing;

namespace FitBuddy.WinForms.UI.Animación
{
    internal static class Transformación
    {
        public static Image RotarImagen(Image image, PointF offset, float ángulo)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            var newImage = new Bitmap(image.Width, image.Height);
            newImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(newImage))
            {
                graphics.TranslateTransform(offset.X, offset.Y);
                graphics.RotateTransform(ángulo);
                graphics.TranslateTransform(-offset.X, -offset.Y);
                graphics.DrawImage(image, new PointF(0, 0));
            }

            return newImage;
        }
    }
}
