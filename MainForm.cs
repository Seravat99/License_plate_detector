using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace SS_OpenCV
{ 
    public partial class MainForm : Form
    {
        Image<Bgr, Byte> img = null; // working image
        Image<Bgr, Byte> imgUndo = null; // undo backup image - UNDO
        string title_bak = "";

        public MainForm()
        {
            InitializeComponent();
            title_bak = Text;
        }

        /// <summary>
        /// Opens a new image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = new Image<Bgr, byte>(openFileDialog1.FileName);
                Text = title_bak + " [" +
                        openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf("\\") + 1) +
                        "]";
                imgUndo = img.Copy();
                ImageViewer.Image = img.Bitmap;
                ImageViewer.Refresh();
            }
        }

        /// <summary>
        /// Saves an image with a new name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageViewer.Image.Save(saveFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// restore last undo copy of the working image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgUndo == null) // verify if the image is already opened
                return; 
            Cursor = Cursors.WaitCursor;
            img = imgUndo.Copy();

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        /// <summary>
        /// Change visualization mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zoom
            if (autoZoomToolStripMenuItem.Checked)
            {
                ImageViewer.SizeMode = PictureBoxSizeMode.Zoom;
                ImageViewer.Dock = DockStyle.Fill;
            }
            else // with scroll bars
            {
                ImageViewer.Dock = DockStyle.None;
                ImageViewer.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        /// <summary>
        /// Show authors form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorsForm form = new AuthorsForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Calculate the image negative
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.Negative(img);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        /// <summary>
        /// Call automated image processing check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvalForm eval = new EvalForm();
            eval.ShowDialog();
        }

        /// <summary>
        /// Call image convertion to gray scale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.ConvertToGray(img);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        /// <summary>
        /// Call image convertion to red scale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.RedChannel(img);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void brightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();

            InputBox form1 = new InputBox("brilho?(int entre 0 e 255)");
            form1.ShowDialog();
            int bright = Convert.ToInt32(form1.ValueTextBox.Text);

            InputBox form2 = new InputBox("contraste?(float entre 0 e 3)");
            form2.ShowDialog();
            double contrast = Convert.ToDouble(form2.ValueTextBox.Text);

            ImageClass.BrightContrast(img,bright,contrast);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void translationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            InputBox form1 = new InputBox("Quanto quer andar no x?");
            form1.ShowDialog();
            int dx = Convert.ToInt32(form1.ValueTextBox.Text);

            InputBox form2 = new InputBox("Quanto quer andar no y?");
            form2.ShowDialog();
            int dy = Convert.ToInt32(form2.ValueTextBox.Text);

            ImageClass.Translation(img, imgCopy, dx, dy);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void rotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            InputBox form1 = new InputBox("Quanto quer rodar?");
            form1.ShowDialog();
            int angle = Convert.ToInt32(form1.ValueTextBox.Text);

            ImageClass.Rotation(img, imgCopy, angle);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            InputBox form1 = new InputBox("Qual é a escala?");
            form1.ShowDialog();
            int scale = Convert.ToInt32(form1.ValueTextBox.Text);

            ImageClass.Scale(img, imgCopy, scale);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void zoomOnPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            InputBox form1 = new InputBox("Qual é o fator de escala?");
            form1.ShowDialog();
            int scaleFactor = Convert.ToInt32(form1.ValueTextBox.Text);

            InputBox form2 = new InputBox("Qual é o x?");
            form2.ShowDialog();
            int centerx = Convert.ToInt32(form2.ValueTextBox.Text);

            InputBox form3 = new InputBox("Qual é o y?");
            form3.ShowDialog();
            int centery = Convert.ToInt32(form3.ValueTextBox.Text);

            ImageClass.Scale_point_xy(img, imgCopy, scaleFactor, centerx, centery);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }
        
        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            ImageClass.Mean(img, imgCopy);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            ImageClass.Sobel(img, imgCopy);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void differentiationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            ImageClass.Diferentiation(img, imgCopy);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void medianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            ImageClass.Median(img, imgCopy);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void grayToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();

            int[] hist = ImageClass.Histogram_Gray(img);

            Histogram form = new Histogram(hist);
            form.Show();

            Cursor = Cursors.Default; // normal cursor 
        }

        private void robertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            ImageClass.Roberts(img, imgCopy);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void whitesInXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();

            int[][] hist = ImageClass.WhiteGraph(img);

            HistogramWhiteX form = new HistogramWhiteX(hist[0]);
            form.Show();

            Cursor = Cursors.Default; // normal cursor
        }

        private void whitesInYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();

            int[][] hist = ImageClass.WhiteGraph(img);

            HistogramWhiteY form = new HistogramWhiteY(hist[1]);
            form.Show();

            Cursor = Cursors.Default; // normal cursor
        }

        private void dilatationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            ImageClass.Dilatation(img, imgCopy);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            ImageClass.Erosion(img, imgCopy);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void sobelVerticalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            ImageClass.Sobel_vertical(img, imgCopy);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void sobelHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            ImageClass.Sobel_horizontal(img, imgCopy);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();

            int[] hist = ImageClass.Histogram_Blue(img);

            HistogramWhiteX form = new HistogramWhiteX(hist);
            form.Show();

            Cursor = Cursors.Default; // normal cursor
        }

        private void characterRecognitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            ImageClass.CharacterRecognize(img, imgCopy);

            ImageViewer.Image = imgCopy.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void characterSeparationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            Rectangle[] charPositions = ImageClass.CharacterSeparate(img);
            for (int i = 0; i < charPositions.Length; i++)
            {
                CvInvoke.cvShowImage("Character" + i, imgCopy.Copy(charPositions[i]));
            }

            ImageViewer.Image = imgCopy.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void findLicensePlateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            ImageClass.LicensePlateRecognition(img, imgCopy);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }
        private void aLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle LP_Location; // rectangulo(x,y,largura, altura) contendo a matricula
            Rectangle LP_Chr1; // rectangulo contendo o primeiro carater
            Rectangle LP_Chr2; // rectangulo contendo o segundo carater
            Rectangle LP_Chr3; // rectangulo contendo o terceiro carater
            Rectangle LP_Chr4; // rectangulo contendo o quarto carater
            Rectangle LP_Chr5; // rectangulo contendo o quinto carater
            Rectangle LP_Chr6; // rectangulo contendo o sexto carater
            string LP_C1; // valor do primeiro carater
            string LP_C2; // valor do segundo carater
            string LP_C3; // valor do terceiro carater
            string LP_C4; // valor do quarto carater
            string LP_C5; // valor do quinto carater
            string LP_C6; // valor do sexto carater
            Image<Bgr, Byte> imgCopy; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            LP_Location = ImageClass.LicensePlateRecognition(img, imgCopy);

            Image<Bgr, byte> LicensePlate = imgCopy.Copy(LP_Location);
            CvInvoke.cvShowImage("License plate alone", LicensePlate);

            Rectangle[] charPositionsRect = ImageClass.CharacterSeparate(LicensePlate);     //Obtem os caracteres da matricula separados
            LP_Chr1 = charPositionsRect[0];
            LP_Chr2 = charPositionsRect[1];
            LP_Chr3 = charPositionsRect[2];
            LP_Chr4 = charPositionsRect[3];
            LP_Chr5 = charPositionsRect[4];
            LP_Chr6 = charPositionsRect[5];

            for (int i = 0; i < charPositionsRect.Length; i++)
            {
                CvInvoke.cvShowImage("Character" + i, LicensePlate.Copy(charPositionsRect[i]));
            }

            Image<Bgr, byte>[] imgCharacters = new Image<Bgr, byte>[6];
            string[] listCharacters = new string[6];

            for (int i = 0; i < charPositionsRect.Length; i++)
            {
                LicensePlate.ROI = charPositionsRect[i];
                imgCharacters[i] = LicensePlate.Copy();
            }
            for (int i = 0; i < imgCharacters.Length; i++)
            {
                listCharacters[i] = ImageClass.CharacterRecognize(imgCharacters[i], imgCharacters[i].Copy());      //Identifica o caracter
            }
            LP_C1 = listCharacters[0];
            LP_C2 = listCharacters[1];
            LP_C3 = listCharacters[2];
            LP_C4 = listCharacters[3];
            LP_C5 = listCharacters[4];
            LP_C6 = listCharacters[5];

            ImageViewer.Image = imgCopy.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            MessageBox.Show(listCharacters[0] + listCharacters[1] + "-" + listCharacters[2] + listCharacters[3] + "-" + listCharacters[4] + listCharacters[5]);

            Cursor = Cursors.Default; // normal cursor 
        }

        private void oTSUToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            ImageClass.ConvertToBW_Otsu(img);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void convertToBWToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Image<Bgr, Byte> imgCopy = null; // new image

            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();
            imgCopy = img.Copy();

            InputBox form1 = new InputBox("Qual o threashold?(int entre 0 e 255)");
            form1.ShowDialog();
            int threshold = Convert.ToInt32(form1.ValueTextBox.Text);

            ImageClass.ConvertToBW(img, threshold);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();

            int[,] hist = ImageClass.Histogram_RGB(img);

            HistogramRGB form = new HistogramRGB(hist);
            form.Show();

            Cursor = Cursors.Default; // normal curso
        }

        private void grayAndRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();

            int[,] hist = ImageClass.Histogram_All(img);

            HistogramAll form = new HistogramAll(hist);
            form.Show();

            Cursor = Cursors.Default; // normal curso
        }

        private void blueChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.BlueChannel(img);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void greenChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            imgUndo = img.Copy();

            ImageClass.GreenChannel(img);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }
    }
}