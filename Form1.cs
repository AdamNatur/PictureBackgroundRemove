
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
    public partial class Form1 : Form
    {
        string ImagePath;
        string FolderPath;

        Color neededColor;

        Bitmap originalImage;

        MyPicture mainPicture;

        int rdBtnCheck = -1;

        int precision = 30;

        public Form1()
        {
            InitializeComponent();

            this.pictureBoxCurrentImage.MouseEnter += (sender, args) => this.pictureBoxMagnifier.Show();

            this.pictureBoxCurrentImage.MouseLeave += (sender, args) => this.pictureBoxMagnifier.Hide();

            this.pictureBoxCurrentImage.MouseMove += (sender, args) => DoMagnification();

        }

        private void DoMagnification()
        {
            // clean up after our last run
            var oldImage = this.pictureBoxMagnifier.BackgroundImage;
            if (oldImage != null)
                oldImage.Dispose();

            this.label3.Text = $"X: {Cursor.Position.X} Y: {Cursor.Position.Y}";
            
            var position = this.pictureBoxCurrentImage.PointToClient(Cursor.Position);
            this.label7.Text = $"X: {position.X} Y: {position.Y}";
            position.X += pictureBoxCurrentImage.Location.X;   
            position.Y += pictureBoxCurrentImage.Location.Y;
            var pboxWidth = pictureBoxMagnifier.Width / 2;
            var pboxHeight = pictureBoxMagnifier.Height / 2;

            Bitmap image = new Bitmap(pictureBoxCurrentImage.Width, pictureBoxCurrentImage.Height);

            pictureBoxCurrentImage.DrawToBitmap(image, pictureBoxCurrentImage.Bounds);

            // ensure we dont go out of bounds
            Rectangle cloneRect = new Rectangle(Math.Max(position.X, 0) - 5, Math.Max(position.Y, 0) - 5, pboxWidth, pboxHeight);

            if (cloneRect.Width + cloneRect.X > image.Width)
                cloneRect.X -= (image.Width - cloneRect.Width);
            

            if (cloneRect.Height + cloneRect.Y > image.Height)
                cloneRect.Y -= (image.Height - cloneRect.Height);

            System.Drawing.Imaging.PixelFormat format = image.PixelFormat;
            // Clone a portion of the Bitmap object.
            Bitmap cloneBitmap = image.Clone(cloneRect, format);

            // Draw the cloned portion of the Bitmap object.

            pictureBoxMagnifier.BackgroundImage = cloneBitmap;

            pictureBoxMagnifier.BackgroundImageLayout = ImageLayout.Zoom;

            pictureBoxMagnifier.Location = OffsetByAFewPixels(position);
        }

        private Point OffsetByAFewPixels(Point location)
        {
            int a = 10;
            return new Point(location.X + a, location.Y + a);
        }

        public Bitmap LoadBitmap(string path)
        {
            if (File.Exists(path))
            {
                // open file in read only mode
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                // get a binary reader for the file stream
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    // copy the content of the file into a memory stream
                    var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                    // make a new Bitmap object the owner of the MemoryStream
                    return new Bitmap(memoryStream);
                }
            }
            else
            {
                MessageBox.Show("Error Loading File.", "Error!", MessageBoxButtons.OK);
                return null;
            }
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";

            if (openImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCurrentImage.Image = LoadBitmap(openImage.FileName);

                originalImage = (Bitmap)pictureBoxCurrentImage.Image;

                txtB_FilePath.Text = openImage.FileName;
                ImagePath = openImage.FileName;

            }
            else
            {
                MessageBox.Show("Failed to open a picture", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         

        }

        private void txtB_FilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";

            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCurrentImage.Image.Save(saveImage.FileName);
                MessageBox.Show("Succesfully saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool isCheckedContour = false;

        private void radBtnContour_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedContour = radBtnContour.Checked;
        }

        private void radBtnContour_Click(object sender, EventArgs e)
        {
            //if (radBtnContour.Checked && !isCheckedContour)
            //{
            //    pictureBoxCurrentImage.Image = (Image)originalImage.Clone();
            //    Invalidate();
            //    radBtnContour.Checked = false;
            //}              
            //else
            //{
            //    radBtnContour.Checked = true;
            //    pictureBoxCurrentImage.Image = CreateContour((Bitmap)pictureBoxCurrentImage.Image.Clone(), precision);
            //    isCheckedContour = false;
            //}


            //pictureBoxCurrentImage.Image = mainPicture.changeBackgroundColorTo(Color.Transparent);
        }

        bool isCheckedDeleteBackground = false;

        private void radioDeleteBackground_CheckedChanged(object sender, EventArgs e)
        {
           isCheckedDeleteBackground = radioDeleteBackground.Checked;
        }

        private void radioDeleteBackground_Click(object sender, EventArgs e)
        {
            //if (radioDeleteBackground.Checked && !isCheckedDeleteBackground)
            //{ 
            //    pictureBoxCurrentImage.Image = (Image)originalImage.Clone();
            //    Invalidate();
            //    radioDeleteBackground.Checked = false;
            //}             
            //else
            //{
            //    radioDeleteBackground.Checked = true;
            //    pictureBoxCurrentImage.Image = DeleteBackground((Bitmap)originalImage.Clone(), precision);
            //    isCheckedDeleteBackground = false;
            //}
        }

        bool isCheckedDeleteObject = false;

        private void radBtnDeleteObject_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedDeleteObject = radBtnDeleteObject.Checked;
        }

        private void radBtnDeleteObject_Click(object sender, EventArgs e)
        {

        }

        bool customColorCheck = false;

        private void btnBackgroundSelect_Click(object sender, EventArgs e)
        {
            colorPalette.ShowDialog();
            neededColor = colorPalette.Color;
            customColorCheck = true;
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {

            var picture = new MyPicture((Bitmap)originalImage.Clone(), precision);

            var neededColor = colorPalette.Color;

            if(radioDeleteBackground.Checked == true)
            {
                neededColor = Color.Transparent;
            }

            if (radBtnContour.Checked)
            {
                pictureBoxCurrentImage.Image = picture.changeContourColorTo(colorPalette.Color);

            } else if (radioDeleteBackground.Checked) 
            {
                pictureBoxCurrentImage.Image = picture.changeBackgroundColorTo(Color.Transparent);
            } else if (radBtnDeleteObject.Checked)
            {
                pictureBoxCurrentImage.Image = picture.changeObjectColorTo(Color.Transparent);
            } else if(radBtnBackground.Checked)
            {
                pictureBoxCurrentImage.Image = picture.changeBackgroundColorTo(colorPalette.Color);
            }

            Invalidate();
        }

        private void radBtnBackground_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}




