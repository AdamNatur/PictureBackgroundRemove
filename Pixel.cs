
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using Color = System.Drawing.Color;
using System.Net;


namespace PictureBackgroundRemove_WinForm
{
    internal class Pixel
    {
        public int x;
        public int y;
        Color pixelColor;
        public Pixel(int x, int y, Color pixelColor)
        {
            this.x = x;
            this.y = y;
            this.pixelColor = pixelColor;
        }

        public Pixel(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.pixelColor = Color.Transparent;
        }

    }

    class MyPicture
    {
        private Bitmap picture;
        private List<Pixel> BackgroundPixels;
        private List<Pixel> ObjectPixels;
        private List<Pixel> ContourPixels;

        public MyPicture(Bitmap picture, int tolerance)
        {
            this.picture = picture;
            ImageByPixels(tolerance);
        }

        private Color BackgroundColor(Bitmap picture)
        {
            int n = 10;

            int R = 0, G = 0, B = 0;

            Color backgroundColor;

            for (int i = 0; i < n; i++)
            {
                R += picture.GetPixel(i, i).R;
                G += picture.GetPixel(i, i).G;
                B += picture.GetPixel(i, i).B;
            }

            R = R / n;
            G = G / n;
            B = B / n;

            backgroundColor = Color.FromArgb(R, G, B);

            return backgroundColor;
        }

        public void ImageByPixels(int tolerance)
        { 
            Color currentColor, oldColor = picture.GetPixel(0, 0); ;

            Pixel currentPixel;

            List<Pixel> BackgroundPixels = new List<Pixel>();
            List<Pixel> ObjectPixels = new List<Pixel>();
            List<Pixel> ContourPixels = new List<Pixel>();



            for (int i = 0; i < picture.Width - 1; i++)
            {
                for (int j = 0; j < picture.Height - 1; j++)
                {
                    currentColor = picture.GetPixel(i, j);
                    currentPixel = new Pixel(i, j, currentColor);

                    if(Math.Abs(oldColor.R - currentColor.R) <= tolerance &&
                    Math.Abs(oldColor.G - currentColor.G) <= tolerance &&
                    Math.Abs(oldColor.B - currentColor.B) <= tolerance)
                    {
                        BackgroundPixels.Add(currentPixel);
                    }
                    else
                    {
                        ContourPixels.Add(currentPixel);
                        break;
                    }

                }
            }

            for (int i = 0; i < picture.Width - 1; i++)
            {
                for (int j = picture.Height - 1; j > 0; j--)
                {
                    currentColor = picture.GetPixel(i, j);
                    currentPixel = new Pixel(i, j, currentColor);

                    if (Math.Abs(oldColor.R - currentColor.R) <= tolerance &&
                    Math.Abs(oldColor.G - currentColor.G) <= tolerance &&
                    Math.Abs(oldColor.B - currentColor.B) <= tolerance)
                    {
                        BackgroundPixels.Add(currentPixel);
                    }
                    else
                    {
                        ContourPixels.Add(currentPixel);
                        break;
                    }

                }
            }

            for (int j = 0; j < picture.Height - 1; j++)
            {
                for (int i = 0; i < picture.Width - 1; i++)
                {
                    currentColor = picture.GetPixel(i, j);
                    currentPixel = new Pixel(i, j, currentColor);

                    if (Math.Abs(oldColor.R - currentColor.R) <= tolerance &&
                    Math.Abs(oldColor.G - currentColor.G) <= tolerance &&
                    Math.Abs(oldColor.B - currentColor.B) <= tolerance)
                    {
                        BackgroundPixels.Add(currentPixel);
                    }
                    else
                    {
                        ContourPixels.Add(currentPixel);
                        break;
                    }

                }
            }

            for (int j = 0; j < picture.Height - 1; j++)
            {
                for (int i = picture.Width - 1; i > 0; i--)
                {
                    currentColor = picture.GetPixel(i, j);
                    currentPixel = new Pixel(i, j, currentColor);

                    if (Math.Abs(oldColor.R - currentColor.R) <= tolerance &&
                    Math.Abs(oldColor.G - currentColor.G) <= tolerance &&
                    Math.Abs(oldColor.B - currentColor.B) <= tolerance)
                    {
                        BackgroundPixels.Add(currentPixel);
                    }
                    else
                    {
                        ContourPixels.Add(currentPixel);
                        break;
                    }

                }
            }

            //for (int i = 1; i < picture.Width - 1; i++)
            //{
            //    for (int j = picture.Height-1; j < 0; j--)
            //    {
            //        currentColor = picture.GetPixel(i, j);
            //        currentPixel = new Pixel(i, j, currentColor);

            //        if (Math.Abs(oldColor.R - currentColor.R) <= tolerance &&
            //        Math.Abs(oldColor.G - currentColor.G) <= tolerance &&
            //        Math.Abs(oldColor.B - currentColor.B) <= tolerance)
            //        {
            //            BackgroundPixels.Add(currentPixel);
            //        }
            //        else
            //        {
            //            ContourPixels.Add(currentPixel);
            //            break;
            //        }

            //    }
            //}

            //for (int i = 1; i < picture.Width - 1; i++)
            //{
            //    for (int j = picture.Height - 1; j < 0; j--)
            //    {
            //        currentColor = picture.GetPixel(i, j);
            //        currentPixel = new Pixel(i, j, currentColor);

            //        if (Math.Abs(oldColor.R - currentColor.R) <= tolerance &&
            //        Math.Abs(oldColor.G - currentColor.G) <= tolerance &&
            //        Math.Abs(oldColor.B - currentColor.B) <= tolerance)
            //        {
            //            BackgroundPixels.Add(currentPixel);
            //        }
            //        else
            //        {
            //            ContourPixels.Add(currentPixel);
            //            break;
            //        }

            //    }
            //}

            //for (int i = 1; i < picture.Width - 1; i++)
            //{
            //    for (int j = picture.Height - 1; j < 0; j--)
            //    {
            //        currentColor = picture.GetPixel(i, j);
            //        currentPixel = new Pixel(i, j, currentColor);

            //        if (Math.Abs(oldColor.R - currentColor.R) <= tolerance &&
            //        Math.Abs(oldColor.G - currentColor.G) <= tolerance &&
            //        Math.Abs(oldColor.B - currentColor.B) <= tolerance)
            //        {
            //            BackgroundPixels.Add(currentPixel);
            //        }
            //        else
            //        {
            //            ContourPixels.Add(currentPixel);
            //            break;
            //        }

            //    }
            //}



            for (int i = 0; i < picture.Width; i++)
            {
                for (int j = 0; j < picture.Height; j++)
                {
                    currentColor = picture.GetPixel(i, j);
                    currentPixel = new Pixel(i, j, currentColor);



                    if (Math.Abs(oldColor.R - currentColor.R) < tolerance &&
                    Math.Abs(oldColor.G - currentColor.G) < tolerance &&
                    Math.Abs(oldColor.B - currentColor.B) < tolerance &&
                    Math.Abs(currentColor.R - BackgroundColor(picture).R) < tolerance &&
                    Math.Abs(currentColor.G - BackgroundColor(picture).G) < tolerance &&
                    Math.Abs(currentColor.B - BackgroundColor(picture).B) < tolerance)
                    {
                        //BackgroundPixels.Add(currentPixel);

                        int y = 1;

                    }
                    else if(Math.Abs(oldColor.R - currentColor.R) < tolerance &&
                    Math.Abs(oldColor.G - currentColor.G) < tolerance &&
                    Math.Abs(oldColor.B - currentColor.B) < tolerance &&
                    Math.Abs(currentColor.R - BackgroundColor(picture).R) > tolerance &&
                    Math.Abs(currentColor.G - BackgroundColor(picture).G) > tolerance &&
                    Math.Abs(currentColor.B - BackgroundColor(picture).B) > tolerance)
                    {
                        //ObjectPixels.Add(currentPixel);
                        //BackgroundPixels.Add(currentPixel);

                        int y = 1;
                    }

                    else if(Math.Abs(oldColor.R - currentColor.R) > tolerance &&
                    Math.Abs(oldColor.G - currentColor.G) > tolerance &&
                    Math.Abs(oldColor.B - currentColor.B) > tolerance)
                    {
                        /*ContourPixels.Add(currentPixel)*/;
                    }

                    oldColor = currentColor;
                }
            }

            this.BackgroundPixels = BackgroundPixels;
            this.ObjectPixels = ObjectPixels;
            this.ContourPixels = ContourPixels;

        }

        public Bitmap changeBackgroundColorTo(Color color)
        {
            return changeColor(BackgroundPixels, color);
        }

        public Bitmap changeContourColorTo(Color color)
        {
            return changeColor(ContourPixels, color);
        }

        public Bitmap changeObjectColorTo(Color color)
        {
            return changeColor(ObjectPixels, color);
        }

        private Bitmap changeColor(List<Pixel> arr, Color color)
        {
            Bitmap clone = (Bitmap)picture.Clone();

            foreach (Pixel p in arr)
            {
                clone.SetPixel(p.x, p.y, color);
            }


            return clone;
        }


    }
}