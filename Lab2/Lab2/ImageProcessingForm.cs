using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2 {
    public partial class ImageProcessingForm : Form {
        Bitmap target, target2, result;
        private Image loadedImage;
        public ImageProcessingForm() {
            InitializeComponent();
            target = new Bitmap(targetPictureBox.Image);
            target2 = new Bitmap(targetPictureBox.Image);
            result = new Bitmap(resultPictureBox.Image);
        }

        private void redProcessingButton_Click(object sender, EventArgs e) {
            result = new Bitmap(target);
            for (int i = 0; i < result.Height; i++)
                for (int j = 0; j < result.Width; j++) {
                    Color c = result.GetPixel(j, i);
                    int r = (int)(c.R * 1.5);
                    if (r > 255) r = 255;
                    result.SetPixel(j, i, Color.FromArgb((int)r, (int)c.G / 2, (int)c.B / 2));
                }
            resultPictureBox.Image = result;
            resultPictureBox.Refresh();
        }

        private void saveImageButton_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            result.Save(saveFileDialog.FileName + ".png");
        }

        private void differenceButton_Click(object sender, EventArgs e) {
            result = new Bitmap(target);
            Bitmap dummy = new Bitmap(target2);

            for (int i = 0; i < result.Height; i++)
                for (int j = 0; j < result.Width; j++) {
                    Color target1c = result.GetPixel(j, i);
                    Color target2c = dummy.GetPixel(j, i);

                    if (target1c.Equals(target2c)) {
                        result.SetPixel(j, i, Color.FromArgb(255, 255, 255));
                    } else {
                        result.SetPixel(j, i, target1c);
                    }
                }
            resultPictureBox.Image = result;
            resultPictureBox.Refresh();
        }

        private void reverseButton_Click(object sender, EventArgs e) {
            result = new Bitmap(target);
            for (int i = 0; i < result.Height; i++)
                for (int j = 0; j < result.Width; j++) {
                    Color c = result.GetPixel(j, i);
                    result.SetPixel(j, i, Color.FromArgb((int)(255 - c.R), (int)(255 - c.G), (int)(255 - c.B)));
                }
            resultPictureBox.Image = result;
            resultPictureBox.Refresh();
        }

        private void gamaButton_Click(object sender, EventArgs e) {
            Double gamaValue = Double.Parse(gamaTextBox.Text);
            Double cValue = 1;

            Double correctionValue = 1 / gamaValue;

            result = new Bitmap(target);
            for (int i = 0; i < result.Height; i++)
                for (int j = 0; j < result.Width; j++) {
                    Color c = result.GetPixel(j, i);
                    int red = Convert.ToInt32(cValue * 255 * Math.Pow(Convert.ToDouble((decimal)c.R / 255), correctionValue));
                    int green = Convert.ToInt32(cValue * 255 * Math.Pow(Convert.ToDouble((decimal)c.G / 255), correctionValue));
                    int blue = Convert.ToInt32(cValue * 255 * Math.Pow(Convert.ToDouble((decimal)c.B / 255), correctionValue));

                    if (red > 255) {
                        red = red % 255;
                    }
                    if (green > 255) {
                        green = green % 255;
                    }
                    if (blue > 255) {
                        blue = blue % 255;
                    }

                    result.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }
            resultPictureBox.Image = result;
            resultPictureBox.Refresh();
        }

        private void binarizationButton_Click(object sender, EventArgs e) {
            result = new Bitmap(target);
            int comparison = Convert.ToInt32(coparisonTextBox.Text);

            for (int i = 0; i < result.Height; i++)
                for (int j = 0; j < result.Width; j++) {
                    Color target1c = result.GetPixel(j, i);

                    int c = 0;

                    if ((target1c.R + target1c.G + target1c.B) / 3 > comparison) { c = 255; }

                    result.SetPixel(j, i, Color.FromArgb(c, c, c));
                }
            resultPictureBox.Image = result;
            resultPictureBox.Refresh();
        }

        private void gamaTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void pointAButton_Click(object sender, EventArgs e) {
            for (int i = 1; i < target.Height - 1; i++)
                for (int j = 1; j < target.Width - 1; j++) {
                    target.SetPixel(j, i, Color.FromArgb(averagePixel(j, i, "RED"), averagePixel(j, i, "GREEN"), averagePixel(j, i, "BLUE")));
                }
            resultPictureBox.Image = target;
            resultPictureBox.Refresh();
        }

        private void selectSecondButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            loadedImage = Image.FromFile(openFileDialog.FileName);
            target2 = new Bitmap(loadedImage);
            targetPictureBox2.Image = target2;
            targetPictureBox2.Refresh();
        }

        private void medianaFilterButton_Click(object sender, EventArgs e) {
            result = new Bitmap(target);
            for (int i = 1; i < result.Width - 2; i++)
                for (int j = 1; j < result.Height - 2; j++) {
                    Color c1 = result.GetPixel(i - 1, j - 1);
                    Color c2 = result.GetPixel(i, j - 1);
                    Color c3 = result.GetPixel(i + 1, j - 1);
                    Color c4 = result.GetPixel(i - 1, j);
                    Color c5 = result.GetPixel(i + 1, j);
                    Color c6 = result.GetPixel(i - 1, j + 1);
                    Color c7 = result.GetPixel(i, j + 1);
                    Color c8 = result.GetPixel(i + 1, j + 1);
                    result.SetPixel(i, j,
                        Color.FromArgb((int)((c1.R + c2.R + c3.R + c4.R + c5.R + c6.R + c7.R + c8.R) / 9),
                                        (int)((c1.G + c2.G + c3.G + c4.G + c5.G + c6.G + c7.G + c8.G) / 9),
                                        (int)((c1.B + c2.B + c3.B + c4.B + c5.B + c6.B + c7.B + c8.B) / 9)));
                }
            resultPictureBox.Image = result;
            resultPictureBox.Refresh();
        }

        private void medicalButton_Click(object sender, EventArgs e) {
            result = new Bitmap(target);
            List<Color> colorList = new List<Color>();
            for (int i = 0; i < 256; i++) {
                Color dummy = new Color();
                dummy = Color.FromArgb(255, 255 - i, i / 2, i);
                colorList.Add(dummy);
            }
            for (int i = 1; i < result.Width - 2; i++)
                for (int j = 1; j < result.Height - 2; j++) {
                    result.SetPixel(i, j, findMinColor(colorList, result.GetPixel(i, j)));
                }
            resultPictureBox.Image = result;
            resultPictureBox.Refresh();
        }

        private void button1_Click(object sender, EventArgs e) {
            //Laplacian
            int filterA = 9;
            int filterB = -1;


            result = new Bitmap(target);
            for (int i = 1; i < result.Width - 2; i++)
                for (int j = 1; j < result.Height - 2; j++) {
                    Color c0 = result.GetPixel(i, j);
                    Color c1 = result.GetPixel(i - 1, j - 1);
                    Color c2 = result.GetPixel(i, j - 1);
                    Color c3 = result.GetPixel(i + 1, j - 1);
                    Color c4 = result.GetPixel(i - 1, j);
                    Color c5 = result.GetPixel(i + 1, j);
                    Color c6 = result.GetPixel(i - 1, j + 1);
                    Color c7 = result.GetPixel(i, j + 1);
                    Color c8 = result.GetPixel(i + 1, j + 1);

                    int r = c0.R * filterA + (c1.R + c2.R + c3.R + c4.R + c5.R + c6.R + c7.R + c8.R) * filterB;
                    int g = c0.G * filterA + (c1.G + c2.G + c3.G + c4.G + c5.G + c6.G + c7.G + c8.G) * filterB;
                    int b = c0.B * filterA + (c1.B + c2.B + c3.B + c4.B + c5.B + c6.B + c7.B + c8.B) * filterB;

                    if (r > 255) { r = 255; } else if (r < 0) { r = 0; }
                    if (g > 255) { g = 255; } else if (g < 0) { g = 0; }
                    if (b > 255) { b = 255; } else if (b < 0) { b = 0; }

                    result.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            resultPictureBox.Image = result;
            resultPictureBox.Refresh();
        }

        private void button2_Click(object sender, EventArgs e) {
            float l = 5.5F;
            Bitmap temporal = new Bitmap(target);
            result = new Bitmap(target);
            for (int i = 1; i < result.Width - 2; i++)
                for (int j = 1; j < result.Height - 2; j++) {
                    Color c0 = result.GetPixel(i, j);
                    Color c1 = result.GetPixel(i - 1, j);
                    Color c2 = result.GetPixel(i + 1, j);
                    Color c3 = result.GetPixel(i, j - 1);
                    Color c4 = result.GetPixel(i, j + 1);

                    int r = (c1.R + c2.R + c3.R + c4.R) / 4;
                    int g = (c1.G + c2.G + c3.G + c4.G) / 4;
                    int b = (c1.B + c2.B + c3.B + c4.B) / 4;

                    if (r > 255) { r = 255; } else if (r < 0) { r = 0; }
                    if (g > 255) { g = 255; } else if (g < 0) { g = 0; }
                    if (b > 255) { b = 255; } else if (b < 0) { b = 0; }

                    temporal.SetPixel(i, j, Color.FromArgb(r, g, b));
                }

            for (int i = 1; i < result.Width - 2; i++)
                for (int j = 1; j < result.Height - 2; j++) {
                    Color cR = result.GetPixel(i, j);
                    Color cT = temporal.GetPixel(i, j);

                    int r = cR.R + (int)(l * (cR.R - cT.R));
                    int g = cR.G + (int)(l * (cR.G - cT.G));
                    int b = cR.B + (int)(l * (cR.B - cT.B));

                    if (r > 255) { r = 255; } else if (r < 0) { r = 0; }
                    if (g > 255) { g = 255; } else if (g < 0) { g = 0; }
                    if (b > 255) { b = 255; } else if (b < 0) { b = 0; }

                    result.SetPixel(i, j, Color.FromArgb(r, g, b));
                }

            resultPictureBox.Image = result;
            resultPictureBox.Refresh();
        }

        //Contur
        private void button3_Click(object sender, EventArgs e) {
            result = new Bitmap(target);
            Bitmap temporal = new Bitmap(target);
            for (int i = 2; i < result.Width - 2; i++)
                for (int j = 2; j < result.Height - 2; j++) {
                    Color c1 = result.GetPixel(i - 1, j);
                    Color c2 = result.GetPixel(i + 1, j);
                    Color c3 = result.GetPixel(i, j - 1);
                    Color c4 = result.GetPixel(i, j + 1);

                    if (((c1.R == 255 && c1.G == 255 && c1.B == 255) || (c2.R == 255 && c2.G == 255 && c2.B == 255) || (c3.R == 255 && c3.G == 255 && c3.B == 255) || (c4.R == 255 && c4.G == 255 && c4.B == 255))
                        && ((c1.R != 255 && c1.G != 255 && c1.B != 255) || (c2.R != 255 && c2.G != 255 && c2.B != 255) || (c3.R != 255 && c3.G != 255 && c3.B != 255) || (c4.R != 255 && c4.G != 255 && c4.B != 255))) {
                        temporal.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    } else {
                        temporal.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                }
            resultPictureBox.Image = temporal;
            resultPictureBox.Refresh();
        }
        //Subtiere
        private void button4_Click(object sender, EventArgs e) { }



        private void selectImageButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            loadedImage = Image.FromFile(openFileDialog.FileName);
            target = new Bitmap(loadedImage);
            targetPictureBox.Image = target;
            targetPictureBox.Refresh();
        }

        private int averagePixel(int i, int j, string color) {
            int s = 0;
            target.GetPixel(0, 0);
            for (int ii = -1; ii <= 1; ii++)
                for (int jj = -1; jj <= 1; jj++) {
                    if (color.Equals("RED")) {
                        s += target.GetPixel(i + ii, j + jj).R;
                    } else if (color.Equals("GREEN")) {
                        s += target.GetPixel(i + ii, j + jj).G;
                    } else if (color.Equals("BLUE")) {
                        s += target.GetPixel(i + ii, j + jj).B;
                    }
                }
            return s / 9;
        }

        private void button5_Click(object sender, EventArgs e) {
            result = new Bitmap(target);
            for (int i = 1; i < result.Width - 2; i++)
                for (int j = 1; j < result.Height - 2; j++) {
                    Color c0 = result.GetPixel(i, j);
                    Color c1 = result.GetPixel(i - 1, j - 1);
                    Color c2 = result.GetPixel(i - 1, j);
                    Color c3 = result.GetPixel(i - 1, j + 1);
                    Color c4 = result.GetPixel(i, j + 1);
                    Color c5 = result.GetPixel(i + 1, j + 1);
                    Color c6 = result.GetPixel(i + 1, j);
                    Color c7 = result.GetPixel(i + 1, j - 1);
                    Color c8 = result.GetPixel(i, j - 1);

                    int nv = 0;
                    int nt = 0;

                    if (c1.R != 255 && c1.G != 255 && c1.B != 255) {
                        nv = nv + 1;
                    }
                    if (c2.R != 255 && c2.G != 255 && c2.B != 255) {
                        nv = nv + 1;
                    }
                    if (c3.R != 255 && c3.G != 255 && c3.B != 255) {
                        nv = nv + 1;
                    }
                    if (c4.R != 255 && c4.G != 255 && c4.B != 255) {
                        nv = nv + 1;
                    }
                    if (c5.R != 255 && c5.G != 255 && c5.B != 255) {
                        nv = nv + 1;
                    }
                    if (c6.R != 255 && c6.G != 255 && c6.B != 255) {
                        nv = nv + 1;
                    }
                    if (c7.R != 255 && c7.G != 255 && c7.B != 255) {
                        nv = nv + 1;
                    }
                    if (c8.R != 255 && c8.G != 255 && c8.B != 255) {
                        nv = nv + 1;
                    }


                    if (((c1.R != 255 || c1.G != 255 || c1.B != 255) && (c2.R == 255 && c2.G == 255 && c2.B == 255)) ||
                        ((c1.R == 255 && c1.G == 255 && c1.B == 255) && (c2.R != 255 || c2.G != 255 || c2.B != 255))) {
                        nt = nt + 1;
                    }

                    if (((c3.R != 255 || c3.G != 255 || c3.B != 255) && (c2.R == 255 && c2.G == 255 && c2.B == 255)) ||
                        ((c3.R == 255 && c3.G == 255 && c3.B == 255) && (c2.R != 255 || c2.G != 255 || c2.B != 255))) {
                        nt = nt + 1;
                    }

                    if (((c3.R != 255 || c3.G != 255 || c3.B != 255) && (c4.R == 255 && c4.G == 255 && c4.B == 255)) ||
                      ((c3.R == 255 && c3.G == 255 && c3.B == 255) && (c4.R != 255 || c4.G != 255 || c4.B != 255))) {
                        nt = nt + 1;
                    }

                    if (((c5.R != 255 || c5.G != 255 || c5.B != 255) && (c4.R == 255 && c4.G == 255 && c4.B == 255)) ||
                        ((c5.R == 255 && c5.G == 255 && c5.B == 255) && (c4.R != 255 || c4.G != 255 || c4.B != 255))) {
                        nt = nt + 1;
                    }

                    if (((c5.R != 255 || c5.G != 255 || c5.B != 255) && (c6.R == 255 && c6.G == 255 && c6.B == 255)) ||
                     ((c5.R == 255 && c5.G == 255 && c5.B == 255) && (c6.R != 255 || c6.G != 255 || c6.B != 255))) {
                        nt = nt + 1;
                    }

                    if (((c7.R != 255 || c7.G != 255 || c7.B != 255) && (c6.R == 255 && c6.G == 255 && c6.B == 255)) ||
                        ((c7.R == 255 && c7.G == 255 && c7.B == 255) && (c6.R != 255 || c6.G != 255 || c6.B != 255))) {
                        nt = nt + 1;
                    }

                    if (((c7.R != 255 || c7.G != 255 || c7.B != 255) && (c8.R == 255 && c8.G == 255 && c8.B == 255)) ||
                        ((c7.R == 255 && c7.G == 255 && c7.B == 255) && (c8.R != 255 || c8.G != 255 || c8.B != 255))) {
                        nt = nt + 1;
                    }

                    if (((c1.R != 255 || c1.G != 255 || c1.B != 255) && (c6.R == 255 && c6.G == 255 && c6.B == 255)) ||
                        ((c1.R == 255 && c1.G == 255 && c1.B == 255) && (c6.R != 255 || c6.G != 255 || c6.B != 255))) {
                        nt = nt + 1;
                    }

                    if ((nv > 2 && nv <= 6) && ((c0.R != 255 || c0.G != 255 || c0.B != 255) && nt == 2)) {
                        result.SetPixel(i, j, Color.FromArgb(0, 255, 0));
                    }
                }
            for (int i = 2; i < result.Width - 2; i++)
                for (int j = 2; j < result.Height - 2; j++) {
                    Color c0 = result.GetPixel(i, j);

                    if (c0.R == 0 && c0.G == 255 && c0.B == 0) {
                        result.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                }
            resultPictureBox.Image = result;
            resultPictureBox.Refresh();
        }

        private Color findMinColor(List<Color> colorList, Color target) {
            Color result = new Color();
            int min = 255;
            int dummyR = 255;
            int dummyG = 255;
            int dummyB = 255;
            int minG = 255;
            int minB = 255;
            foreach (Color color in colorList) {
                if (compareColor(target, color) < min) {
                    min = compareColor(target, color);
                    result = color;
                }
            }
            return result;
        }

        private int compareColor(Color target, Color color) {
            return target.R - color.R;
        }
    }
}
