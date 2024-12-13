using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Drawing;
using System.IO;
using System.Diagnostics;


namespace SS_OpenCV
{
    class ImageClass
    {

        /// <summary>
        /// Image Negative using EmguCV library
        /// Slower method
        /// </summary>
        /// <param name="img">Image</param>
        public static void Negative(Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte blue, green, red;
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3)
                {// image in RGB
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //retrieve 3 colour components
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            // store in the image
                            dataPtr[0] = (byte)(255 - blue);
                            dataPtr[1] = (byte)(255 - green);
                            dataPtr[2] = (byte)(255 - red);
                            // advance the pointer to the next pixel
                            dataPtr += nChan;
                        }
                        //at the end of the line advance the pointer by the alignment bytes (padding)
                        dataPtr += padding;
                    }
                }
            }
        }

        /// <summary>
        /// Convert to gray
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        public static void ConvertToGray(Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte blue, green, red, gray;

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //retrieve 3 colour components
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            // convert to gray
                            gray = (byte)Math.Round((int)(blue + green + red) / 3.0);

                            // store in the image
                            dataPtr[0] = gray;
                            dataPtr[1] = gray;
                            dataPtr[2] = gray;

                            // advance the pointer to the next pixel
                            dataPtr += nChan;
                        }

                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding;
                    }
                }
            }
        }

        /// <summary>
        /// Convert to red
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        public static void RedChannel(Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte blue, green, red;

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //retrieve 3 colour components
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            // store in the image
                            dataPtr[0] = red;
                            dataPtr[1] = red;
                            dataPtr[2] = red;

                            // advance the pointer to the next pixel
                            dataPtr += nChan;
                        }

                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding;
                    }
                }
            }
        }

        /// <summary>
        /// Convert to blue
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        public static void BlueChannel(Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte blue, green, red;

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //retrieve 3 colour components
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            // store in the image
                            dataPtr[0] = blue;
                            dataPtr[1] = blue;
                            dataPtr[2] = blue;

                            // advance the pointer to the next pixel
                            dataPtr += nChan;
                        }

                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding;
                    }
                }
            }
        }

        /// <summary>
        /// Convert to green
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        public static void GreenChannel(Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte blue, green, red;

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //retrieve 3 colour components
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            // store in the image
                            dataPtr[0] = green;
                            dataPtr[1] = green;
                            dataPtr[2] = green;

                            // advance the pointer to the next pixel
                            dataPtr += nChan;
                        }

                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding;
                    }
                }
            }
        }

        /// <summary>
        /// Convert to BrightContrast
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        public static void BrightContrast(Image<Bgr, byte> img, int bright, double contrast)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte blue, green, red;

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //retrieve 3 colour components
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            // store in the image
                            dataPtr[0] = (byte)Math.Round(contrast * blue + bright);
                            dataPtr[1] = (byte)Math.Round(contrast * green + bright);
                            dataPtr[2] = (byte)Math.Round(contrast * red + bright);

                            // advance the pointer to the next pixel
                            dataPtr += nChan;
                        }

                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding;
                    }
                }
            }
        }

        /// <summary>
        /// Convert to translation
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        /// <param name="imgCopy">image</param>
        public static void Translation(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy, int dx, int dy)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x_origem, y_origem;

                byte* image_pointer;

                for (int y = 0; y < height; y++)
                {
                    y_origem = y - dy;

                    for (int x = 0; x < width; x++)
                    {
                        x_origem = x - dx;

                        if ((x_origem >= width || x_origem < 0) || (y_origem >= height || y_origem < 0))
                        {
                            // store in the image
                            dataPtr[0] = 0;
                            dataPtr[1] = 0;
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            image_pointer = dataPtrC + y_origem * m.widthStep + x_origem * nChan;
                            // store in the image
                            dataPtr[0] = image_pointer[0];
                            dataPtr[1] = image_pointer[1];
                            dataPtr[2] = image_pointer[2];
                        }
                        dataPtr += nChan;
                    }
                    dataPtr += padding;
                }
            }
        }

        /// <summary>
        /// Convert to rotation
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        /// <param name="imgCopy">image</param>
        public static void Rotation(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy, float angle)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x_origem, y_origem;

                byte* image_pointer;

                double cos = Math.Cos(angle);
                double sin = Math.Sin(angle);

                double width_half = width / 2.0;
                double height_half = height / 2.0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        x_origem = (int)Math.Round((x - width_half) * cos - (height_half - y) * sin + width_half);
                        y_origem = (int)Math.Round(height_half - (x - width_half) * sin - (height_half - y) * cos);

                        if ((x_origem >= width || x_origem < 0) || (y_origem >= height || y_origem < 0))
                        {
                            // store in the image
                            dataPtr[0] = 0;
                            dataPtr[1] = 0;
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            image_pointer = dataPtrC + y_origem * m.widthStep + x_origem * nChan;
                            // store in the image
                            dataPtr[0] = image_pointer[0];
                            dataPtr[1] = image_pointer[1];
                            dataPtr[2] = image_pointer[2];
                        }
                        dataPtr += nChan;
                    }
                    dataPtr += padding;
                }
            }
        }

        /// <summary>
        /// Convert to scale
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        /// <param name="imgCopy">image</param>
        public static void Scale(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy, float scaleFactor)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x_origem, y_origem;

                byte* image_pointer;

                for (int y = 0; y < height; y++)
                {
                    y_origem = (int)Math.Round(y / scaleFactor);

                    for (int x = 0; x < width; x++)
                    {
                        x_origem = (int)Math.Round(x / scaleFactor);

                        if ((x_origem >= width || x_origem < 0) || (y_origem >= height || y_origem < 0))
                        {
                            // store in the image
                            dataPtr[0] = 0;
                            dataPtr[1] = 0;
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            image_pointer = dataPtrC + y_origem * m.widthStep + x_origem * nChan;
                            // store in the image
                            dataPtr[0] = image_pointer[0];
                            dataPtr[1] = image_pointer[1];
                            dataPtr[2] = image_pointer[2];
                        }
                        dataPtr += nChan;
                    }
                    dataPtr += padding;

                }
            }
        }

        /// <summary>
        /// Convert to scale point xy
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        /// <param name="imgCopy">image</param>
        public static void Scale_point_xy(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy, float scaleFactor, int centerX, int centerY)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = widthStep - nChan * m.width; // alinhament bytes (padding)
                int x_origem, y_origem;
                double a, b, c, d;

                byte* image_pointer;

                d = width / 2;
                a = centerX - (d / scaleFactor);

                c = height / 2;
                b = centerY - (c / scaleFactor);


                for (int y = 0; y < height; y++)
                {
                    y_origem = (int)Math.Round(y / scaleFactor + b);

                    for (int x = 0; x < width; x++)
                    {
                        x_origem = (int)Math.Round(x / scaleFactor + a);

                        if ((x_origem >= width || x_origem < 0) || (y_origem >= height || y_origem < 0))
                        {
                            // store in the image
                            dataPtr[0] = 0;
                            dataPtr[1] = 0;
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            image_pointer = (dataPtrC + y_origem * widthStep + x_origem * nChan);
                            // store in the image
                            dataPtr[0] = image_pointer[0];
                            dataPtr[1] = image_pointer[1];
                            dataPtr[2] = image_pointer[2];
                        }
                        dataPtr += nChan;
                    }
                    dataPtr += padding;
                }
            }
        }
        
        /// <summary>
        /// Convert to mean
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        /// <param name="imgCopy">image</param>
        public static void Mean(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = widthStep - nChan * m.width; // alinhament bytes (padding)

                dataPtr[0] = (byte)(Math.Round((2 * (2 * dataPtrC[0] + (dataPtrC + nChan)[0]) + 2 * (dataPtrC + widthStep)[0] + (dataPtrC + widthStep + nChan)[0]) / 9.0));
                dataPtr[1] = (byte)(Math.Round((2 * (2 * dataPtrC[1] + (dataPtrC + nChan)[1]) + 2 * (dataPtrC + widthStep)[1] + (dataPtrC + widthStep + nChan)[1]) / 9.0));
                dataPtr[2] = (byte)(Math.Round((2 * (2 * dataPtrC[2] + (dataPtrC + nChan)[2]) + 2 * (dataPtrC + widthStep)[2] + (dataPtrC + widthStep + nChan)[2]) / 9.0));

                dataPtr += nChan;
                dataPtrC += nChan;

                for (int x = 1; x < width - 1; x++)
                {
                    dataPtr[0] = (byte)(Math.Round((2 * (dataPtrC[0] + (dataPtrC + nChan)[0] + (dataPtrC - nChan)[0]) + (dataPtrC + widthStep)[0] + (dataPtrC + widthStep + nChan)[0] + (dataPtrC + widthStep - nChan)[0]) / 9.0));
                    dataPtr[1] = (byte)(Math.Round((2 * (dataPtrC[1] + (dataPtrC + nChan)[1] + (dataPtrC - nChan)[1]) + (dataPtrC + widthStep)[1] + (dataPtrC + widthStep + nChan)[1] + (dataPtrC + widthStep - nChan)[1]) / 9.0));
                    dataPtr[2] = (byte)(Math.Round((2 * (dataPtrC[2] + (dataPtrC + nChan)[2] + (dataPtrC - nChan)[2]) + (dataPtrC + widthStep)[2] + (dataPtrC + widthStep + nChan)[2] + (dataPtrC + widthStep - nChan)[2]) / 9.0));

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                dataPtr[0] = (byte)(Math.Round((2 * (2 * dataPtrC[0] + (dataPtrC - nChan)[0]) + 2 * (dataPtrC + widthStep)[0] + (dataPtrC + widthStep - nChan)[0]) / 9.0));
                dataPtr[1] = (byte)(Math.Round((2 * (2 * dataPtrC[1] + (dataPtrC - nChan)[1]) + 2 * (dataPtrC + widthStep)[1] + (dataPtrC + widthStep - nChan)[1]) / 9.0));
                dataPtr[2] = (byte)(Math.Round((2 * (2 * dataPtrC[2] + (dataPtrC - nChan)[2]) + 2 * (dataPtrC + widthStep)[2] + (dataPtrC + widthStep - nChan)[2]) / 9.0));

                dataPtr += (padding + nChan);
                dataPtrC += (padding + nChan);

                for (int y = 1; y < height-1; y++)
                {

                    dataPtr[0] = (byte)(Math.Round((2 * dataPtrC[0] + (dataPtrC + nChan)[0] + 2 * (dataPtrC - widthStep)[0] + (dataPtrC - widthStep + nChan)[0] + 2 * (dataPtrC + widthStep)[0] + (dataPtrC + widthStep + nChan)[0]) / 9.0));
                    dataPtr[1] = (byte)(Math.Round((2 * dataPtrC[1] + (dataPtrC + nChan)[1] + 2 * (dataPtrC - widthStep)[1] + (dataPtrC - widthStep + nChan)[1] + 2 * (dataPtrC + widthStep)[1] + (dataPtrC + widthStep + nChan)[1]) / 9.0));
                    dataPtr[2] = (byte)(Math.Round((2 * dataPtrC[2] + (dataPtrC + nChan)[2] + 2 * (dataPtrC - widthStep)[2] + (dataPtrC - widthStep + nChan)[2] + 2 * (dataPtrC + widthStep)[2] + (dataPtrC + widthStep + nChan)[2]) / 9.0));

                    dataPtr += nChan;
                    dataPtrC += nChan;

                    for (int x = 1; x < width-1; x++)
                    {
                        // store in the image
                        dataPtr[0] = (byte)(Math.Round((dataPtrC[0] + (dataPtrC + nChan)[0] + (dataPtrC - nChan)[0] + (dataPtrC - widthStep)[0] + (dataPtrC - widthStep + nChan)[0] + (dataPtrC - widthStep - nChan)[0] + (dataPtrC + widthStep)[0] + (dataPtrC + widthStep + nChan)[0] + (dataPtrC + widthStep - nChan)[0]) / 9.0));
                        dataPtr[1] = (byte)(Math.Round((dataPtrC[1] + (dataPtrC + nChan)[1] + (dataPtrC - nChan)[1] + (dataPtrC - widthStep)[1] + (dataPtrC - widthStep + nChan)[1] + (dataPtrC - widthStep - nChan)[1] + (dataPtrC + widthStep)[1] + (dataPtrC + widthStep + nChan)[1] + (dataPtrC + widthStep - nChan)[1]) / 9.0));
                        dataPtr[2] = (byte)(Math.Round((dataPtrC[2] + (dataPtrC + nChan)[2] + (dataPtrC - nChan)[2] + (dataPtrC - widthStep)[2] + (dataPtrC - widthStep + nChan)[2] + (dataPtrC - widthStep - nChan)[2] + (dataPtrC + widthStep)[2] + (dataPtrC + widthStep + nChan)[2] + (dataPtrC + widthStep - nChan)[2]) / 9.0));

                        dataPtr += nChan;
                        dataPtrC += nChan;
                    }

                    dataPtr[0] = (byte)(Math.Round((2 * dataPtrC[0] + (dataPtrC - nChan)[0] + 2 * (dataPtrC - widthStep)[0] + (dataPtrC - widthStep - nChan)[0] + 2 * (dataPtrC + widthStep)[0] + (dataPtrC + widthStep - nChan)[0]) / 9.0));
                    dataPtr[1] = (byte)(Math.Round((2 * dataPtrC[1] + (dataPtrC - nChan)[1] + 2 * (dataPtrC - widthStep)[1] + (dataPtrC - widthStep - nChan)[1] + 2 * (dataPtrC + widthStep)[1] + (dataPtrC + widthStep - nChan)[1]) / 9.0));
                    dataPtr[2] = (byte)(Math.Round((2 * dataPtrC[2] + (dataPtrC - nChan)[2] + 2 * (dataPtrC - widthStep)[2] + (dataPtrC - widthStep - nChan)[2] + 2 * (dataPtrC + widthStep)[2] + (dataPtrC + widthStep - nChan)[2]) / 9.0));

                    dataPtr += (padding + nChan);
                    dataPtrC += (padding + nChan);
                }

                dataPtr[0] = (byte)(Math.Round((2 * (2 * dataPtrC[0] + (dataPtrC + nChan)[0]) + 2 * (dataPtrC - widthStep)[0] + (dataPtrC - widthStep + nChan)[0]) / 9.0));
                dataPtr[1] = (byte)(Math.Round((2 * (2 * dataPtrC[1] + (dataPtrC + nChan)[1]) + 2 * (dataPtrC - widthStep)[1] + (dataPtrC - widthStep + nChan)[1]) / 9.0));
                dataPtr[2] = (byte)(Math.Round((2 * (2 * dataPtrC[2] + (dataPtrC + nChan)[2]) + 2 * (dataPtrC - widthStep)[2] + (dataPtrC - widthStep + nChan)[2]) / 9.0));

                dataPtr += nChan;
                dataPtrC += nChan;

                for (int x = 1; x < width - 1; x++)
                {
                    dataPtr[0] = (byte)(Math.Round((2 * (dataPtrC[0] + (dataPtrC + nChan)[0] + (dataPtrC - nChan)[0]) + (dataPtrC - widthStep)[0] + (dataPtrC - widthStep + nChan)[0] + (dataPtrC - widthStep - nChan)[0]) / 9.0));
                    dataPtr[1] = (byte)(Math.Round((2 * (dataPtrC[1] + (dataPtrC + nChan)[1] + (dataPtrC - nChan)[1]) + (dataPtrC - widthStep)[1] + (dataPtrC - widthStep + nChan)[1] + (dataPtrC - widthStep - nChan)[1]) / 9.0));
                    dataPtr[2] = (byte)(Math.Round((2 * (dataPtrC[2] + (dataPtrC + nChan)[2] + (dataPtrC - nChan)[2]) + (dataPtrC - widthStep)[2] + (dataPtrC - widthStep + nChan)[2] + (dataPtrC - widthStep - nChan)[2]) / 9.0));

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                dataPtr[0] = (byte)(Math.Round((2 * (2 * dataPtrC[0] + (dataPtrC - nChan)[0]) + 2 * (dataPtrC - widthStep)[0] + (dataPtrC - widthStep - nChan)[0]) / 9.0));
                dataPtr[1] = (byte)(Math.Round((2 * (2 * dataPtrC[1] + (dataPtrC - nChan)[1]) + 2 * (dataPtrC - widthStep)[1] + (dataPtrC - widthStep - nChan)[1]) / 9.0));
                dataPtr[2] = (byte)(Math.Round((2 * (2 * dataPtrC[2] + (dataPtrC - nChan)[2]) + 2 * (dataPtrC - widthStep)[2] + (dataPtrC - widthStep - nChan)[2]) / 9.0));

            }
        }

        /// <summary>
        /// Convert to non uniform
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        /// <param name="imgCopy">image</param>
        public static void NonUniform(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy, float[,]matrix, float matrixWeight, float offset)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = widthStep - nChan * m.width; // alinhament bytes (padding)
                int blue, green, red;

                float m1 = matrix[0, 0];
                float m2 = matrix[1, 0];
                float m3 = matrix[2, 0];
                float m4 = matrix[0, 1];
                float m5 = matrix[1, 1];
                float m6 = matrix[2, 1];
                float m7 = matrix[0, 2];
                float m8 = matrix[1, 2];
                float m9 = matrix[2, 2];

                blue = (int)(Math.Round(((dataPtrC[0] * (m1 + m2 + m4 + m5) + (dataPtrC + nChan)[0] * (m3 + m6) + (dataPtrC + widthStep)[0] * (m7 + m8) + (dataPtrC + widthStep + nChan)[0] * m9) / matrixWeight) + offset));
                green = (int)(Math.Round(((dataPtrC[1] * (m1 + m2 + m4 + m5) + (dataPtrC + nChan)[1] * (m3 + m6) + (dataPtrC + widthStep)[1] * (m7 + m8) + (dataPtrC + widthStep + nChan)[1] * m9) / matrixWeight) + offset));
                red = (int)(Math.Round(((dataPtrC[2] * (m1 + m2 + m4 + m5) + (dataPtrC + nChan)[2] * (m3 + m6) + (dataPtrC + widthStep)[2] * (m7 + m8) + (dataPtrC + widthStep + nChan)[2] * m9) / matrixWeight) + offset));
                
                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                for (int x = 1; x < width - 1; x++)
                {
                    blue = (int)(Math.Round(((dataPtrC[0] * (m2 + m5) + (dataPtrC + nChan)[0] * (m3 + m6) + (dataPtrC - nChan)[0] * (m1 + m4) + (dataPtrC + widthStep)[0] * m8 + (dataPtrC + widthStep + nChan)[0] * m9 + (dataPtrC + widthStep - nChan)[0] * m7) / matrixWeight) + offset));
                    green = (int)(Math.Round(((dataPtrC[1] * (m2 + m5) + (dataPtrC + nChan)[1] * (m3 + m6) + (dataPtrC - nChan)[1] * (m1 + m4) + (dataPtrC + widthStep)[1] * m8 + (dataPtrC + widthStep + nChan)[1] * m9 + (dataPtrC + widthStep - nChan)[1] * m7) / matrixWeight) + offset));
                    red = (int)(Math.Round(((dataPtrC[2] * (m2 + m5) + (dataPtrC + nChan)[2] * (m3 + m6) + (dataPtrC - nChan)[2] * (m1 + m4) + (dataPtrC + widthStep)[2] * m8 + (dataPtrC + widthStep + nChan)[2] * m9 + (dataPtrC + widthStep - nChan)[2] * m7) / matrixWeight) + offset));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                blue = (int)(Math.Round(((dataPtrC[0] * (m2 + m3 + m5 + m6) + (dataPtrC - nChan)[0] * (m1 + m4) + (dataPtrC + widthStep)[0] * (m8 + m9) + (dataPtrC + widthStep - nChan)[0] * m7) / matrixWeight) + offset));
                green = (int)(Math.Round(((dataPtrC[1] * (m2 + m3 + m5 + m6) + (dataPtrC - nChan)[1] * (m1 + m4) + (dataPtrC + widthStep)[1] * (m8 + m9) + (dataPtrC + widthStep - nChan)[1] * m7) / matrixWeight) + offset));
                red = (int)(Math.Round(((dataPtrC[2] * (m2 + m3 + m5 + m6) + (dataPtrC - nChan)[2] * (m1 + m4) + (dataPtrC + widthStep)[2] * (m8 + m9) + (dataPtrC + widthStep - nChan)[2] * m7) / matrixWeight) + offset));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                dataPtr += (padding + nChan);
                dataPtrC += (padding + nChan);

                for (int y = 1; y < height - 1; y++)
                {

                    blue = (int)(Math.Round(((dataPtrC[0] * (m4 + m5) + (dataPtrC + nChan)[0] * m6 + (dataPtrC - widthStep)[0] * (m1 + m2) + (dataPtrC - widthStep + nChan)[0] * m3 + (dataPtrC + widthStep)[0] * (m7 + m8) + (dataPtrC + widthStep + nChan)[0] * m9) / matrixWeight) + offset));
                    green = (int)(Math.Round(((dataPtrC[1] * (m4 + m5) + (dataPtrC + nChan)[1] * m6 + (dataPtrC - widthStep)[1] * (m1 + m2) + (dataPtrC - widthStep + nChan)[1] * m3 + (dataPtrC + widthStep)[1] * (m7 + m8) + (dataPtrC + widthStep + nChan)[1] * m9) / matrixWeight) + offset));
                    red = (int)(Math.Round(((dataPtrC[2] * (m4 + m5) + (dataPtrC + nChan)[2] * m6 + (dataPtrC - widthStep)[2] * (m1 + m2) + (dataPtrC - widthStep + nChan)[2] * m3 + (dataPtrC + widthStep)[2] * (m7 + m8) + (dataPtrC + widthStep + nChan)[2] * m9) / matrixWeight) + offset));

                    {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                    dataPtr += nChan;
                    dataPtrC += nChan;

                    for (int x = 1; x < width - 1; x++)
                    {
                        // store in the image
                        blue = (int)(Math.Round(((dataPtrC[0] * m5 + (dataPtrC + nChan)[0] * m6 + (dataPtrC - nChan)[0] * m4 + (dataPtrC - widthStep)[0] * m2 + (dataPtrC - widthStep + nChan)[0] * m3 + (dataPtrC - widthStep - nChan)[0] * m1 + (dataPtrC + widthStep)[0] * m8 + (dataPtrC + widthStep + nChan)[0] * m9 + (dataPtrC + widthStep - nChan)[0] * m7) / matrixWeight) + offset));
                        green = (int)(Math.Round(((dataPtrC[1] * m5 + (dataPtrC + nChan)[1] * m6 + (dataPtrC - nChan)[1] * m4 + (dataPtrC - widthStep)[1] * m2 + (dataPtrC - widthStep + nChan)[1] * m3 + (dataPtrC - widthStep - nChan)[1] * m1 + (dataPtrC + widthStep)[1] * m8 + (dataPtrC + widthStep + nChan)[1] * m9 + (dataPtrC + widthStep - nChan)[1] * m7) / matrixWeight) + offset));
                        red = (int)(Math.Round(((dataPtrC[2] * m5 + (dataPtrC + nChan)[2] * m6 + (dataPtrC - nChan)[2] * m4 + (dataPtrC - widthStep)[2] * m2 + (dataPtrC - widthStep + nChan)[2] * m3 + (dataPtrC - widthStep - nChan)[2] * m1 + (dataPtrC + widthStep)[2] * m8 + (dataPtrC + widthStep + nChan)[2] * m9 + (dataPtrC + widthStep - nChan)[2] * m7) / matrixWeight) + offset));

                        {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                        dataPtr += nChan;
                        dataPtrC += nChan;
                    }

                    blue = (int)(Math.Round(((dataPtrC[0] * (m5 + m6) + (dataPtrC - nChan)[0] * m4 + (dataPtrC - widthStep)[0] * (m2 + m3) + (dataPtrC - widthStep - nChan)[0] * m1 + (dataPtrC + widthStep)[0] * (m8 + m9) + (dataPtrC + widthStep - nChan)[0] * m7) / matrixWeight) + offset));
                    green = (int)(Math.Round(((dataPtrC[1] * (m5 + m6) + (dataPtrC - nChan)[1] * m4 + (dataPtrC - widthStep)[1] * (m2 + m3) + (dataPtrC - widthStep - nChan)[1] * m1 + (dataPtrC + widthStep)[1] * (m8 + m9) + (dataPtrC + widthStep - nChan)[1] * m7) / matrixWeight) + offset));
                    red = (int)(Math.Round(((dataPtrC[2] * (m5 + m6) + (dataPtrC - nChan)[2] * m4 + (dataPtrC - widthStep)[2] * (m2 + m3) + (dataPtrC - widthStep - nChan)[2] * m1 + (dataPtrC + widthStep)[2] * (m8 + m9) + (dataPtrC + widthStep - nChan)[2] * m7) / matrixWeight) + offset));

                    {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                    dataPtr += (padding + nChan);
                    dataPtrC += (padding + nChan);
                }

                blue = (int)(Math.Round(((dataPtrC[0] * (m4 + m5 + m7 + m8) + (dataPtrC + nChan)[0] * (m6 + m9) + (dataPtrC - widthStep)[0] * (m1 + m2) + (dataPtrC - widthStep + nChan)[0] * m3) / matrixWeight) + offset));
                green = (int)(Math.Round(((dataPtrC[1] * (m4 + m5 + m7 + m8) + (dataPtrC + nChan)[1] * (m6 + m9) + (dataPtrC - widthStep)[1] * (m1 + m2) + (dataPtrC - widthStep + nChan)[1] * m3) / matrixWeight) + offset));
                red = (int)(Math.Round(((dataPtrC[2] * (m4 + m5 + m7 + m8) + (dataPtrC + nChan)[2] * (m6 + m9) + (dataPtrC - widthStep)[2] * (m1 + m2) + (dataPtrC - widthStep + nChan)[2] * m3) / matrixWeight) + offset));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                for (int x = 1; x < width - 1; x++)
                {
                    blue = (int)(Math.Round(((dataPtrC[0] * (m5 + m8) + (dataPtrC + nChan)[0] * (m6 + m9) + (dataPtrC - nChan)[0] * (m4 + m7) + (dataPtrC - widthStep)[0] * m2 + (dataPtrC - widthStep + nChan)[0] * m3 + (dataPtrC - widthStep - nChan)[0] * m1) / matrixWeight) + offset));
                    green = (int)(Math.Round(((dataPtrC[1] * (m5 + m8) + (dataPtrC + nChan)[1] * (m6 + m9) + (dataPtrC - nChan)[1] * (m4 + m7) + (dataPtrC - widthStep)[1] * m2 + (dataPtrC - widthStep + nChan)[1] * m3 + (dataPtrC - widthStep - nChan)[1] * m1) / matrixWeight) + offset));
                    red = (int)(Math.Round(((dataPtrC[2] * (m5 + m8) + (dataPtrC + nChan)[2] * (m6 + m9) + (dataPtrC - nChan)[2] * (m4 + m7) + (dataPtrC - widthStep)[2] * m2 + (dataPtrC - widthStep + nChan)[2] * m3 + (dataPtrC - widthStep - nChan)[2] * m1) / matrixWeight) + offset));

                    {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                blue = (int)(Math.Round(((dataPtrC[0] * (m5 + m6 + m8 + m9) + (dataPtrC - nChan)[0] * (m4 + m7) + (dataPtrC - widthStep)[0] * (m2 + m3) + (dataPtrC - widthStep - nChan)[0] * m1) / matrixWeight) + offset));
                green = (int)(Math.Round(((dataPtrC[1] * (m5 + m6 + m8 + m9) + (dataPtrC - nChan)[1] * (m4 + m7) + (dataPtrC - widthStep)[1] * (m2 + m3) + (dataPtrC - widthStep - nChan)[1] * m1) / matrixWeight) + offset));
                red = (int)(Math.Round(((dataPtrC[2] * (m5 + m6 + m8 + m9) + (dataPtrC - nChan)[2] * (m4 + m7) + (dataPtrC - widthStep)[2] * (m2 + m3) + (dataPtrC - widthStep - nChan)[2] * m1) / matrixWeight) + offset));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Convert to non uniform
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        /// <param name="imgCopy">image</param>
        public static void Sobel(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = widthStep - nChan * m.width; // alinhament bytes (padding)
                int blue, green, red;

                blue = (int)(Math.Abs((3 * (dataPtrC)[0] + (dataPtrC + widthStep)[0]) - (3 * (dataPtrC + nChan)[0] + (dataPtrC + widthStep + nChan)[0])) + Math.Abs((3 * (dataPtrC + widthStep)[0] + (dataPtrC + widthStep + nChan)[0]) - (3 * dataPtrC[0] + (dataPtrC + nChan)[0])));
                green = (int)(Math.Abs((3 * (dataPtrC)[1] + (dataPtrC + widthStep)[1]) - (3 * (dataPtrC + nChan)[1] + (dataPtrC + widthStep + nChan)[1])) + Math.Abs((3 * (dataPtrC + widthStep)[1] + (dataPtrC + widthStep + nChan)[1]) - (3 * dataPtrC[1] + (dataPtrC + nChan)[1])));
                red = (int)(Math.Abs((3 * (dataPtrC)[2] + (dataPtrC + widthStep)[2]) - (3 * (dataPtrC + nChan)[2] + (dataPtrC + widthStep + nChan)[2])) + Math.Abs((3 * (dataPtrC + widthStep)[2] + (dataPtrC + widthStep + nChan)[2]) - (3 * dataPtrC[2] + (dataPtrC + nChan)[2])));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                for (int x = 1; x < width - 1; x++)
                {
                    blue = (int)(Math.Abs((3 * (dataPtrC - nChan)[0] + (dataPtrC + widthStep - nChan)[0]) - (3 * (dataPtrC + nChan)[0] + (dataPtrC + widthStep + nChan)[0])) + Math.Abs(((dataPtrC + widthStep - nChan)[0] + 2 * (dataPtrC + widthStep)[0] + (dataPtrC + widthStep + nChan)[0]) - ((dataPtrC - nChan)[0] + 2 * dataPtrC[0] + (dataPtrC + nChan)[0])));
                    green = (int)(Math.Abs((3 * (dataPtrC - nChan)[1] + (dataPtrC + widthStep - nChan)[1]) - (3 * (dataPtrC + nChan)[1] + (dataPtrC + widthStep + nChan)[1])) + Math.Abs(((dataPtrC + widthStep - nChan)[1] + 2 * (dataPtrC + widthStep)[1] + (dataPtrC + widthStep + nChan)[1]) - ((dataPtrC - nChan)[1] + 2 * dataPtrC[1] + (dataPtrC + nChan)[1])));
                    red = (int)(Math.Abs((3 * (dataPtrC - nChan)[2] + (dataPtrC + widthStep - nChan)[2]) - (3 * (dataPtrC + nChan)[2] + (dataPtrC + widthStep + nChan)[2])) + Math.Abs(((dataPtrC + widthStep - nChan)[2] + 2 * (dataPtrC + widthStep)[2] + (dataPtrC + widthStep + nChan)[2]) - ((dataPtrC - nChan)[2] + 2 * dataPtrC[2] + (dataPtrC + nChan)[2])));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                blue = (int)(Math.Abs((3 * (dataPtrC - nChan)[0] + (dataPtrC + widthStep - nChan)[0]) - (3 * dataPtrC[0] + (dataPtrC + widthStep)[0])) + Math.Abs(((dataPtrC + widthStep - nChan)[0] + 3 * (dataPtrC + widthStep)[0]) - ((dataPtrC - nChan)[0] + 3 * dataPtrC[0])));
                green = (int)(Math.Abs((3 * (dataPtrC - nChan)[1] + (dataPtrC + widthStep - nChan)[1]) - (3 * dataPtrC[1] + (dataPtrC + widthStep)[1])) + Math.Abs(((dataPtrC + widthStep - nChan)[1] + 3 * (dataPtrC + widthStep)[1]) - ((dataPtrC - nChan)[1] + 3 * dataPtrC[1])));
                red = (int)(Math.Abs((3 * (dataPtrC - nChan)[2] + (dataPtrC + widthStep - nChan)[2]) - (3 * dataPtrC[2] + (dataPtrC + widthStep)[2])) + Math.Abs(((dataPtrC + widthStep - nChan)[2] + 3 * (dataPtrC + widthStep)[2]) - ((dataPtrC - nChan)[2] + 3 * dataPtrC[2])));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                dataPtr += (padding + nChan);
                dataPtrC += (padding + nChan);

                for (int y = 1; y < height - 1; y++)
                {

                    blue = (int)(Math.Abs(((dataPtrC - widthStep)[0] + 2 * dataPtrC[0] + (dataPtrC + widthStep)[0]) - ((dataPtrC - widthStep + nChan)[0] + 2 * (dataPtrC + nChan)[0] + (dataPtrC + widthStep + nChan)[0])) + Math.Abs((3 * (dataPtrC + widthStep)[0] + (dataPtrC + widthStep + nChan)[0]) - (3 * (dataPtrC - widthStep)[0] + (dataPtrC - widthStep + nChan)[0])));
                    green = (int)(Math.Abs(((dataPtrC - widthStep)[1] + 2 * dataPtrC[1] + (dataPtrC + widthStep)[1]) - ((dataPtrC - widthStep + nChan)[1] + 2 * (dataPtrC + nChan)[1] + (dataPtrC + widthStep + nChan)[1])) + Math.Abs((3 * (dataPtrC + widthStep)[1] + (dataPtrC + widthStep + nChan)[1]) - (3 * (dataPtrC - widthStep)[1] + (dataPtrC - widthStep + nChan)[1])));
                    red = (int)(Math.Abs(((dataPtrC - widthStep)[2] + 2 * dataPtrC[2] + (dataPtrC + widthStep)[2]) - ((dataPtrC - widthStep + nChan)[2] + 2 * (dataPtrC + nChan)[2] + (dataPtrC + widthStep + nChan)[2])) + Math.Abs((3 * (dataPtrC + widthStep)[2] + (dataPtrC + widthStep + nChan)[2]) - (3 * (dataPtrC - widthStep)[2] + (dataPtrC - widthStep + nChan)[2])));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;

                    for (int x = 1; x < width - 1; x++)
                    {
                        // store in the image
                        blue = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[0] + 2 * (dataPtrC - nChan)[0] + (dataPtrC + widthStep - nChan)[0]) - ((dataPtrC - widthStep + nChan)[0] + 2 * (dataPtrC + nChan)[0] + (dataPtrC + widthStep + nChan)[0])) + Math.Abs(((dataPtrC + widthStep - nChan)[0] + 2 * (dataPtrC + widthStep)[0] + (dataPtrC + widthStep + nChan)[0]) - ((dataPtrC - widthStep - nChan)[0] + 2 * (dataPtrC - widthStep)[0] + (dataPtrC - widthStep + nChan)[0])));
                        green = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[1] + 2 * (dataPtrC - nChan)[1] + (dataPtrC + widthStep - nChan)[1]) - ((dataPtrC - widthStep + nChan)[1] + 2 * (dataPtrC + nChan)[1] + (dataPtrC + widthStep + nChan)[1])) + Math.Abs(((dataPtrC + widthStep - nChan)[1] + 2 * (dataPtrC + widthStep)[1] + (dataPtrC + widthStep + nChan)[1]) - ((dataPtrC - widthStep - nChan)[1] + 2 * (dataPtrC - widthStep)[1] + (dataPtrC - widthStep + nChan)[1])));
                        red = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[2] + 2 * (dataPtrC - nChan)[2] + (dataPtrC + widthStep - nChan)[2]) - ((dataPtrC - widthStep + nChan)[2] + 2 * (dataPtrC + nChan)[2] + (dataPtrC + widthStep + nChan)[2])) + Math.Abs(((dataPtrC + widthStep - nChan)[2] + 2 * (dataPtrC + widthStep)[2] + (dataPtrC + widthStep + nChan)[2]) - ((dataPtrC - widthStep - nChan)[2] + 2 * (dataPtrC - widthStep)[2] + (dataPtrC - widthStep + nChan)[2])));

                        {
                            if (blue > 255)
                            {
                                dataPtr[0] = 255;
                            }
                            else
                            {
                                if (blue < 0)
                                {
                                    dataPtr[0] = 0;
                                }
                                else
                                {
                                    dataPtr[0] = (byte)blue;
                                }
                            }
                            if (green > 255)
                            {
                                dataPtr[1] = 255;
                            }
                            else
                            {
                                if (green < 0)
                                {
                                    dataPtr[1] = 0;
                                }
                                else
                                {
                                    dataPtr[1] = (byte)green;
                                }
                            }
                            if (red > 255)
                            {
                                dataPtr[2] = 255;
                            }
                            else
                            {
                                if (red < 0)
                                {
                                    dataPtr[2] = 0;
                                }
                                else
                                {
                                    dataPtr[2] = (byte)red;
                                }
                            }
                        }
                        
                        dataPtr += nChan;
                        dataPtrC += nChan;
                    }

                    blue = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[0] + 2 * (dataPtrC - nChan)[0] + (dataPtrC + widthStep - nChan)[0]) - ((dataPtrC - widthStep)[0] + 2 * dataPtrC[0] + (dataPtrC + widthStep)[0])) + Math.Abs(((dataPtrC + widthStep - nChan)[0] + 3 * (dataPtrC + widthStep)[0]) - ((dataPtrC - widthStep - nChan)[0] + 3 * (dataPtrC - widthStep)[0])));
                    green = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[1] + 2 * (dataPtrC - nChan)[1] + (dataPtrC + widthStep - nChan)[1]) - ((dataPtrC - widthStep)[1] + 2 * dataPtrC[1] + (dataPtrC + widthStep)[1])) + Math.Abs(((dataPtrC + widthStep - nChan)[1] + 3 * (dataPtrC + widthStep)[1]) - ((dataPtrC - widthStep - nChan)[1] + 3 * (dataPtrC - widthStep)[1])));
                    red = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[2] + 2 * (dataPtrC - nChan)[2] + (dataPtrC + widthStep - nChan)[2]) - ((dataPtrC - widthStep)[2] + 2 * dataPtrC[2] + (dataPtrC + widthStep)[2])) + Math.Abs(((dataPtrC + widthStep - nChan)[2] + 3 * (dataPtrC + widthStep)[2]) - ((dataPtrC - widthStep - nChan)[2] + 3 * (dataPtrC - widthStep)[2])));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += (padding + nChan);
                    dataPtrC += (padding + nChan);
                }

                blue = (int)(Math.Abs(((dataPtrC - widthStep)[0] + 3 * dataPtrC[0]) - ((dataPtrC - widthStep + nChan)[0] + 3 * (dataPtrC + nChan)[0])) + Math.Abs((3 * dataPtrC[0] + (dataPtrC + nChan)[0]) - (3 * (dataPtrC - widthStep)[0] + (dataPtrC - widthStep + nChan)[0])));
                green = (int)(Math.Abs(((dataPtrC - widthStep)[1] + 3 * dataPtrC[1]) - ((dataPtrC - widthStep + nChan)[1] + 3 * (dataPtrC + nChan)[1])) + Math.Abs((3 * dataPtrC[1] + (dataPtrC + nChan)[1]) - (3 * (dataPtrC - widthStep)[1] + (dataPtrC - widthStep + nChan)[1])));
                red = (int)(Math.Abs(((dataPtrC - widthStep)[2] + 3 * dataPtrC[2]) - ((dataPtrC - widthStep + nChan)[2] + 3 * (dataPtrC + nChan)[2])) + Math.Abs((3 * dataPtrC[2] + (dataPtrC + nChan)[2]) - (3 * (dataPtrC - widthStep)[2] + (dataPtrC - widthStep + nChan)[2])));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                for (int x = 1; x < width - 1; x++)
                {
                    blue = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[0] + 3 * (dataPtrC - nChan)[0]) - ((dataPtrC - widthStep + nChan)[0] + 3 * (dataPtrC + nChan)[0])) + Math.Abs(((dataPtrC - nChan)[0] + 2 * dataPtrC[0] + (dataPtrC + nChan)[0]) - ((dataPtrC - widthStep - nChan)[0] + 2 * (dataPtrC - widthStep)[0] + (dataPtrC - widthStep + nChan)[0])));
                    green = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[1] + 3 * (dataPtrC - nChan)[1]) - ((dataPtrC - widthStep + nChan)[1] + 3 * (dataPtrC + nChan)[1])) + Math.Abs(((dataPtrC - nChan)[1] + 2 * dataPtrC[1] + (dataPtrC + nChan)[1]) - ((dataPtrC - widthStep - nChan)[1] + 2 * (dataPtrC - widthStep)[1] + (dataPtrC - widthStep + nChan)[1])));
                    red = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[2] + 3 * (dataPtrC - nChan)[2]) - ((dataPtrC - widthStep + nChan)[2] + 3 * (dataPtrC + nChan)[2])) + Math.Abs(((dataPtrC - nChan)[2] + 2 * dataPtrC[2] + (dataPtrC + nChan)[2]) - ((dataPtrC - widthStep - nChan)[2] + 2 * (dataPtrC - widthStep)[2] + (dataPtrC - widthStep + nChan)[2])));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                blue = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[0] + 3 * (dataPtrC - nChan)[0]) - ((dataPtrC - widthStep)[0] + 3 * dataPtrC[0])) + Math.Abs(((dataPtrC - nChan)[0] + 3 * dataPtrC[0]) - ((dataPtrC - widthStep - nChan)[0] + 3 * (dataPtrC - widthStep)[0])));
                green = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[1] + 3 * (dataPtrC - nChan)[1]) - ((dataPtrC - widthStep)[1] + 3 * dataPtrC[1])) + Math.Abs(((dataPtrC - nChan)[1] + 3 * dataPtrC[1]) - ((dataPtrC - widthStep - nChan)[1] + 3 * (dataPtrC - widthStep)[1])));
                red = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[2] + 3 * (dataPtrC - nChan)[2]) - ((dataPtrC - widthStep)[2] + 3 * dataPtrC[2])) + Math.Abs(((dataPtrC - nChan)[2] + 3 * dataPtrC[2]) - ((dataPtrC - widthStep - nChan)[2] + 3 * (dataPtrC - widthStep)[2])));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Convert to non uniform
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        /// <param name="imgCopy">image</param>
        public static void Diferentiation(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = widthStep - nChan * m.width; // alinhament bytes (padding)
                int blue, green, red;

                for (int y = 0; y < height - 1; y++)
                {

                    for (int x = 0; x < width - 1; x++)
                    {
                        // store in the image
                        blue = (int)(Math.Abs(dataPtrC[0] - (dataPtrC + nChan)[0]) + Math.Abs(dataPtrC[0] - (dataPtrC + widthStep)[0]));
                        green = (int)(Math.Abs(dataPtrC[1] - (dataPtrC + nChan)[1]) + Math.Abs(dataPtrC[1] - (dataPtrC + widthStep)[1]));
                        red = (int)(Math.Abs(dataPtrC[2] - (dataPtrC + nChan)[2]) + Math.Abs(dataPtrC[2] - (dataPtrC + widthStep)[2]));

                        {
                            if (blue > 255)
                            {
                                dataPtr[0] = 255;
                            }
                            else
                            {
                                if (blue < 0)
                                {
                                    dataPtr[0] = 0;
                                }
                                else
                                {
                                    dataPtr[0] = (byte)blue;
                                }
                            }
                            if (green > 255)
                            {
                                dataPtr[1] = 255;
                            }
                            else
                            {
                                if (green < 0)
                                {
                                    dataPtr[1] = 0;
                                }
                                else
                                {
                                    dataPtr[1] = (byte)green;
                                }
                            }
                            if (red > 255)
                            {
                                dataPtr[2] = 255;
                            }
                            else
                            {
                                if (red < 0)
                                {
                                    dataPtr[2] = 0;
                                }
                                else
                                {
                                    dataPtr[2] = (byte)red;
                                }
                            }
                        }

                        dataPtr += nChan;
                        dataPtrC += nChan;
                    }

                    blue = (int)Math.Abs(dataPtrC[0] - (dataPtrC + widthStep)[0]);
                    green = (int)Math.Abs(dataPtrC[1] - (dataPtrC + widthStep)[1]);
                    red = (int)Math.Abs(dataPtrC[2] - (dataPtrC + widthStep)[2]);

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += (padding + nChan);
                    dataPtrC += (padding + nChan);
                }

                for (int x = 0; x < width - 1; x++)
                {
                    blue = (int)Math.Abs(dataPtrC[0] - (dataPtrC + nChan)[0]);
                    green = (int)Math.Abs(dataPtrC[1] - (dataPtrC + nChan)[1]);
                    red = (int)Math.Abs(dataPtrC[2] - (dataPtrC + nChan)[2]);

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                dataPtr[0] = 0;
                dataPtr[1] = 0;
                dataPtr[2] = 0;
            }
        }

        /// <summary>
        /// Convert to median
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        /// <param name="imgCopy">image</param>
        public static void Median(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = widthStep - nChan * m.width; // alinhament bytes (padding)

                byte* p0 = null, p1 = null, p2 = null, p3 = null, p4 = null, p5 = null, p6 = null, p7 = null, p8 = null;
                byte*[] p = { p0, p1, p2, p3, p4, p5, p6, p7, p8 };

                //pixel do canto superior esquerdo
                {
                    int a = 0, dist = 2000;
                    p0 = (dataPtrC);
                    p1 = (dataPtrC);
                    p2 = (dataPtrC + nChan);
                    p3 = (dataPtrC);
                    p4 = (dataPtrC);
                    p5 = (dataPtrC + nChan);
                    p6 = (dataPtrC + widthStep);
                    p7 = (dataPtrC + widthStep);
                    p8 = (dataPtrC + widthStep + nChan);
                    p[0] = p0;
                    p[1] = p1;
                    p[2] = p2;
                    p[3] = p3;
                    p[4] = p4;
                    p[5] = p5;
                    p[6] = p6;
                    p[7] = p7;
                    p[8] = p8;


                    for (int j = 0; j < 9; j++)
                    {
                        int ndist = 0;

                        /*for (int i = 0; i < 9; i++)
                        {
                            int d = 0;
                           if (j != i)
                            {
                                d = Math.Abs((p[j])[0] - (p[i])[0]) + Math.Abs((p[j])[1] - (p[i])[1]) + Math.Abs((p[j])[2] - (p[i])[2]); 
                                ndist += d;
                            }
                        }*/

                        ndist = Math.Abs((p[j])[0] - (p0)[0]) + Math.Abs((p[j])[1] - (p0)[1]) + Math.Abs((p[j])[2] - (p0)[2]) +
                                    Math.Abs((p[j])[0] - (p1)[0]) + Math.Abs((p[j])[1] - (p1)[1]) + Math.Abs((p[j])[2] - (p1)[2]) +
                                    Math.Abs((p[j])[0] - (p2)[0]) + Math.Abs((p[j])[1] - (p2)[1]) + Math.Abs((p[j])[2] - (p2)[2]) +
                                    Math.Abs((p[j])[0] - (p3)[0]) + Math.Abs((p[j])[1] - (p3)[1]) + Math.Abs((p[j])[2] - (p3)[2]) +
                                    Math.Abs((p[j])[0] - (p4)[0]) + Math.Abs((p[j])[1] - (p4)[1]) + Math.Abs((p[j])[2] - (p4)[2]) +
                                    Math.Abs((p[j])[0] - (p5)[0]) + Math.Abs((p[j])[1] - (p5)[1]) + Math.Abs((p[j])[2] - (p5)[2]) +
                                    Math.Abs((p[j])[0] - (p6)[0]) + Math.Abs((p[j])[1] - (p6)[1]) + Math.Abs((p[j])[2] - (p6)[2]) +
                                    Math.Abs((p[j])[0] - (p7)[0]) + Math.Abs((p[j])[1] - (p7)[1]) + Math.Abs((p[j])[2] - (p7)[2]) +
                                    Math.Abs((p[j])[0] - (p8)[0]) + Math.Abs((p[j])[1] - (p8)[1]) + Math.Abs((p[j])[2] - (p8)[2]);

                        if (dist > ndist)
                        {
                            dist = ndist;
                            a = j;
                        }
                    }


                    dataPtr[0] = p[a][0];
                    dataPtr[1] = p[a][1];
                    dataPtr[2] = p[a][2];
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                //pixeis da linha superior exceto os cantos
                for (int x = 1; x < width - 1; x++)
                {
                    int a = 0, dist = 2000;
                    p0 = (dataPtrC - nChan);
                    p1 = (dataPtrC);
                    p2 = (dataPtrC + nChan);
                    p3 = (dataPtrC - nChan);
                    p4 = (dataPtrC);
                    p5 = (dataPtrC + nChan);
                    p6 = (dataPtrC + widthStep - nChan);
                    p7 = (dataPtrC + widthStep);
                    p8 = (dataPtrC + widthStep + nChan);
                    p[0] = p0;
                    p[1] = p1;
                    p[2] = p2;
                    p[3] = p3;
                    p[4] = p4;
                    p[5] = p5;
                    p[6] = p6;
                    p[7] = p7;
                    p[8] = p8;


                    for (int j = 0; j < 9; j++)
                    {
                        int ndist = 0;

                        /*for (int i = 0; i < 9; i++)
                        {
                            int d = 0;
                           if (j != i)
                            {
                                d = Math.Abs((p[j])[0] - (p[i])[0]) + Math.Abs((p[j])[1] - (p[i])[1]) + Math.Abs((p[j])[2] - (p[i])[2]); 
                                ndist += d;
                            }
                        }*/

                        ndist = Math.Abs((p[j])[0] - (p0)[0]) + Math.Abs((p[j])[1] - (p0)[1]) + Math.Abs((p[j])[2] - (p0)[2]) +
                                    Math.Abs((p[j])[0] - (p1)[0]) + Math.Abs((p[j])[1] - (p1)[1]) + Math.Abs((p[j])[2] - (p1)[2]) +
                                    Math.Abs((p[j])[0] - (p2)[0]) + Math.Abs((p[j])[1] - (p2)[1]) + Math.Abs((p[j])[2] - (p2)[2]) +
                                    Math.Abs((p[j])[0] - (p3)[0]) + Math.Abs((p[j])[1] - (p3)[1]) + Math.Abs((p[j])[2] - (p3)[2]) +
                                    Math.Abs((p[j])[0] - (p4)[0]) + Math.Abs((p[j])[1] - (p4)[1]) + Math.Abs((p[j])[2] - (p4)[2]) +
                                    Math.Abs((p[j])[0] - (p5)[0]) + Math.Abs((p[j])[1] - (p5)[1]) + Math.Abs((p[j])[2] - (p5)[2]) +
                                    Math.Abs((p[j])[0] - (p6)[0]) + Math.Abs((p[j])[1] - (p6)[1]) + Math.Abs((p[j])[2] - (p6)[2]) +
                                    Math.Abs((p[j])[0] - (p7)[0]) + Math.Abs((p[j])[1] - (p7)[1]) + Math.Abs((p[j])[2] - (p7)[2]) +
                                    Math.Abs((p[j])[0] - (p8)[0]) + Math.Abs((p[j])[1] - (p8)[1]) + Math.Abs((p[j])[2] - (p8)[2]);

                        if (dist > ndist)
                        {
                            dist = ndist;
                            a = j;
                        }
                    }


                    dataPtr[0] = p[a][0];
                    dataPtr[1] = p[a][1];
                    dataPtr[2] = p[a][2];

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }


                //pixel do canto superior direito
                {
                    int a = 0, dist = 2000;
                    p0 = (dataPtrC - nChan);
                    p1 = (dataPtrC);
                    p2 = (dataPtrC);
                    p3 = (dataPtrC - nChan);
                    p4 = (dataPtrC);
                    p5 = (dataPtrC);
                    p6 = (dataPtrC + widthStep - nChan);
                    p7 = (dataPtrC + widthStep);
                    p8 = (dataPtrC + widthStep);
                    p[0] = p0;
                    p[1] = p1;
                    p[2] = p2;
                    p[3] = p3;
                    p[4] = p4;
                    p[5] = p5;
                    p[6] = p6;
                    p[7] = p7;
                    p[8] = p8;


                    for (int j = 0; j < 9; j++)
                    {
                        int ndist = 0;

                        /*for (int i = 0; i < 9; i++)
                        {
                            int d = 0;
                           if (j != i)
                            {
                                d = Math.Abs((p[j])[0] - (p[i])[0]) + Math.Abs((p[j])[1] - (p[i])[1]) + Math.Abs((p[j])[2] - (p[i])[2]); 
                                ndist += d;
                            }
                        }*/

                        ndist = Math.Abs((p[j])[0] - (p0)[0]) + Math.Abs((p[j])[1] - (p0)[1]) + Math.Abs((p[j])[2] - (p0)[2]) +
                                    Math.Abs((p[j])[0] - (p1)[0]) + Math.Abs((p[j])[1] - (p1)[1]) + Math.Abs((p[j])[2] - (p1)[2]) +
                                    Math.Abs((p[j])[0] - (p2)[0]) + Math.Abs((p[j])[1] - (p2)[1]) + Math.Abs((p[j])[2] - (p2)[2]) +
                                    Math.Abs((p[j])[0] - (p3)[0]) + Math.Abs((p[j])[1] - (p3)[1]) + Math.Abs((p[j])[2] - (p3)[2]) +
                                    Math.Abs((p[j])[0] - (p4)[0]) + Math.Abs((p[j])[1] - (p4)[1]) + Math.Abs((p[j])[2] - (p4)[2]) +
                                    Math.Abs((p[j])[0] - (p5)[0]) + Math.Abs((p[j])[1] - (p5)[1]) + Math.Abs((p[j])[2] - (p5)[2]) +
                                    Math.Abs((p[j])[0] - (p6)[0]) + Math.Abs((p[j])[1] - (p6)[1]) + Math.Abs((p[j])[2] - (p6)[2]) +
                                    Math.Abs((p[j])[0] - (p7)[0]) + Math.Abs((p[j])[1] - (p7)[1]) + Math.Abs((p[j])[2] - (p7)[2]) +
                                    Math.Abs((p[j])[0] - (p8)[0]) + Math.Abs((p[j])[1] - (p8)[1]) + Math.Abs((p[j])[2] - (p8)[2]);

                        if (dist > ndist)
                        {
                            dist = ndist;
                            a = j;
                        }
                    }


                    dataPtr[0] = p[a][0];
                    dataPtr[1] = p[a][1];
                    dataPtr[2] = p[a][2];
                }

                dataPtr += (padding + nChan);
                dataPtrC += (padding + nChan);

                for (int y = 1; y < height - 1; y++)
                {
                    //pixeis da coluna da esquerda exceto os cantos
                    {
                        int a = 0, dist = 2000;
                        p0 = (dataPtrC - widthStep);
                        p1 = (dataPtrC - widthStep);
                        p2 = (dataPtrC - widthStep + nChan);
                        p3 = (dataPtrC);
                        p4 = (dataPtrC);
                        p5 = (dataPtrC + nChan);
                        p6 = (dataPtrC + widthStep);
                        p7 = (dataPtrC + widthStep);
                        p8 = (dataPtrC + widthStep + nChan);
                        p[0] = p0;
                        p[1] = p1;
                        p[2] = p2;
                        p[3] = p3;
                        p[4] = p4;
                        p[5] = p5;
                        p[6] = p6;
                        p[7] = p7;
                        p[8] = p8;


                        for (int j = 0; j < 9; j++)
                        {
                            int ndist = 0;

                            /*for (int i = 0; i < 9; i++)
                            {
                                int d = 0;
                               if (j != i)
                                {
                                    d = Math.Abs((p[j])[0] - (p[i])[0]) + Math.Abs((p[j])[1] - (p[i])[1]) + Math.Abs((p[j])[2] - (p[i])[2]); 
                                    ndist += d;
                                }
                            }*/

                            ndist = Math.Abs((p[j])[0] - (p0)[0]) + Math.Abs((p[j])[1] - (p0)[1]) + Math.Abs((p[j])[2] - (p0)[2]) +
                                        Math.Abs((p[j])[0] - (p1)[0]) + Math.Abs((p[j])[1] - (p1)[1]) + Math.Abs((p[j])[2] - (p1)[2]) +
                                        Math.Abs((p[j])[0] - (p2)[0]) + Math.Abs((p[j])[1] - (p2)[1]) + Math.Abs((p[j])[2] - (p2)[2]) +
                                        Math.Abs((p[j])[0] - (p3)[0]) + Math.Abs((p[j])[1] - (p3)[1]) + Math.Abs((p[j])[2] - (p3)[2]) +
                                        Math.Abs((p[j])[0] - (p4)[0]) + Math.Abs((p[j])[1] - (p4)[1]) + Math.Abs((p[j])[2] - (p4)[2]) +
                                        Math.Abs((p[j])[0] - (p5)[0]) + Math.Abs((p[j])[1] - (p5)[1]) + Math.Abs((p[j])[2] - (p5)[2]) +
                                        Math.Abs((p[j])[0] - (p6)[0]) + Math.Abs((p[j])[1] - (p6)[1]) + Math.Abs((p[j])[2] - (p6)[2]) +
                                        Math.Abs((p[j])[0] - (p7)[0]) + Math.Abs((p[j])[1] - (p7)[1]) + Math.Abs((p[j])[2] - (p7)[2]) +
                                        Math.Abs((p[j])[0] - (p8)[0]) + Math.Abs((p[j])[1] - (p8)[1]) + Math.Abs((p[j])[2] - (p8)[2]);

                            if (dist > ndist)
                            {
                                dist = ndist;
                                a = j;
                            }
                        }


                        dataPtr[0] = p[a][0];
                        dataPtr[1] = p[a][1];
                        dataPtr[2] = p[a][2];
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;

                    //core da imagem
                    for (int x = 1; x < width - 1; x++)
                    {
                        // store in the image
                        int a = 0, dist = 2000;
                        p0 = (dataPtrC - widthStep - nChan);
                        p1 = (dataPtrC - widthStep);
                        p2 = (dataPtrC - widthStep + nChan);
                        p3 = (dataPtrC - nChan);
                        p4 = (dataPtrC);
                        p5 = (dataPtrC + nChan);
                        p6 = (dataPtrC + widthStep - nChan);
                        p7 = (dataPtrC + widthStep);
                        p8 = (dataPtrC + widthStep + nChan);
                        p[0] = p0;
                        p[1] = p1;
                        p[2] = p2;
                        p[3] = p3;
                        p[4] = p4;
                        p[5] = p5;
                        p[6] = p6;
                        p[7] = p7;
                        p[8] = p8;


                        for (int j = 0; j < 9; j++)
                        {
                            int ndist = 0;

                            /*for (int i = 0; i < 9; i++)
                            {
                                int d = 0;
                               if (j != i)
                                {
                                    d = Math.Abs((p[j])[0] - (p[i])[0]) + Math.Abs((p[j])[1] - (p[i])[1]) + Math.Abs((p[j])[2] - (p[i])[2]); 
                                    ndist += d;
                                }
                            }*/

                            ndist = Math.Abs((p[j])[0] - (p0)[0]) + Math.Abs((p[j])[1] - (p0)[1]) + Math.Abs((p[j])[2] - (p0)[2]) +
                                        Math.Abs((p[j])[0] - (p1)[0]) + Math.Abs((p[j])[1] - (p1)[1]) + Math.Abs((p[j])[2] - (p1)[2]) +
                                        Math.Abs((p[j])[0] - (p2)[0]) + Math.Abs((p[j])[1] - (p2)[1]) + Math.Abs((p[j])[2] - (p2)[2]) +
                                        Math.Abs((p[j])[0] - (p3)[0]) + Math.Abs((p[j])[1] - (p3)[1]) + Math.Abs((p[j])[2] - (p3)[2]) +
                                        Math.Abs((p[j])[0] - (p4)[0]) + Math.Abs((p[j])[1] - (p4)[1]) + Math.Abs((p[j])[2] - (p4)[2]) +
                                        Math.Abs((p[j])[0] - (p5)[0]) + Math.Abs((p[j])[1] - (p5)[1]) + Math.Abs((p[j])[2] - (p5)[2]) +
                                        Math.Abs((p[j])[0] - (p6)[0]) + Math.Abs((p[j])[1] - (p6)[1]) + Math.Abs((p[j])[2] - (p6)[2]) +
                                        Math.Abs((p[j])[0] - (p7)[0]) + Math.Abs((p[j])[1] - (p7)[1]) + Math.Abs((p[j])[2] - (p7)[2]) +
                                        Math.Abs((p[j])[0] - (p8)[0]) + Math.Abs((p[j])[1] - (p8)[1]) + Math.Abs((p[j])[2] - (p8)[2]);

                            if (dist > ndist)
                            {
                                dist = ndist;
                                a = j;
                            }
                        }


                        dataPtr[0] = p[a][0];
                        dataPtr[1] = p[a][1];
                        dataPtr[2] = p[a][2];

                        dataPtr += nChan;
                        dataPtrC += nChan;
                    }

                    //pixeis da coluna da direita exceto os cantos
                    {
                        int a = 0, dist = 2000;
                        p0 = (dataPtrC - widthStep - nChan);
                        p1 = (dataPtrC - widthStep);
                        p2 = (dataPtrC - widthStep);
                        p3 = (dataPtrC - nChan);
                        p4 = (dataPtrC);
                        p5 = (dataPtrC);
                        p6 = (dataPtrC + widthStep - nChan);
                        p7 = (dataPtrC + widthStep);
                        p8 = (dataPtrC + widthStep);
                        p[0] = p0;
                        p[1] = p1;
                        p[2] = p2;
                        p[3] = p3;
                        p[4] = p4;
                        p[5] = p5;
                        p[6] = p6;
                        p[7] = p7;
                        p[8] = p8;


                        for (int j = 0; j < 9; j++)
                        {
                            int ndist = 0;

                            /*for (int i = 0; i < 9; i++)
                            {
                                int d = 0;
                               if (j != i)
                                {
                                    d = Math.Abs((p[j])[0] - (p[i])[0]) + Math.Abs((p[j])[1] - (p[i])[1]) + Math.Abs((p[j])[2] - (p[i])[2]); 
                                    ndist += d;
                                }
                            }*/

                            ndist = Math.Abs((p[j])[0] - (p0)[0]) + Math.Abs((p[j])[1] - (p0)[1]) + Math.Abs((p[j])[2] - (p0)[2]) +
                                        Math.Abs((p[j])[0] - (p1)[0]) + Math.Abs((p[j])[1] - (p1)[1]) + Math.Abs((p[j])[2] - (p1)[2]) +
                                        Math.Abs((p[j])[0] - (p2)[0]) + Math.Abs((p[j])[1] - (p2)[1]) + Math.Abs((p[j])[2] - (p2)[2]) +
                                        Math.Abs((p[j])[0] - (p3)[0]) + Math.Abs((p[j])[1] - (p3)[1]) + Math.Abs((p[j])[2] - (p3)[2]) +
                                        Math.Abs((p[j])[0] - (p4)[0]) + Math.Abs((p[j])[1] - (p4)[1]) + Math.Abs((p[j])[2] - (p4)[2]) +
                                        Math.Abs((p[j])[0] - (p5)[0]) + Math.Abs((p[j])[1] - (p5)[1]) + Math.Abs((p[j])[2] - (p5)[2]) +
                                        Math.Abs((p[j])[0] - (p6)[0]) + Math.Abs((p[j])[1] - (p6)[1]) + Math.Abs((p[j])[2] - (p6)[2]) +
                                        Math.Abs((p[j])[0] - (p7)[0]) + Math.Abs((p[j])[1] - (p7)[1]) + Math.Abs((p[j])[2] - (p7)[2]) +
                                        Math.Abs((p[j])[0] - (p8)[0]) + Math.Abs((p[j])[1] - (p8)[1]) + Math.Abs((p[j])[2] - (p8)[2]);

                            if (dist > ndist)
                            {
                                dist = ndist;
                                a = j;
                            }
                        }


                        dataPtr[0] = p[a][0];
                        dataPtr[1] = p[a][1];
                        dataPtr[2] = p[a][2];
                    }

                    dataPtr += (padding + nChan);
                    dataPtrC += (padding + nChan);
                }

                //pixel do canto inferior esquerdo
                {
                    int a = 0, dist = 2000;
                    p0 = (dataPtrC - widthStep);
                    p1 = (dataPtrC - widthStep);
                    p2 = (dataPtrC - widthStep + nChan);
                    p3 = (dataPtrC);
                    p4 = (dataPtrC);
                    p5 = (dataPtrC + nChan);
                    p6 = (dataPtrC);
                    p7 = (dataPtrC);
                    p8 = (dataPtrC + nChan);
                    p[0] = p0;
                    p[1] = p1;
                    p[2] = p2;
                    p[3] = p3;
                    p[4] = p4;
                    p[5] = p5;
                    p[6] = p6;
                    p[7] = p7;
                    p[8] = p8;


                    for (int j = 0; j < 9; j++)
                    {
                        int ndist = 0;

                        /*for (int i = 0; i < 9; i++)
                        {
                            int d = 0;
                           if (j != i)
                            {
                                d = Math.Abs((p[j])[0] - (p[i])[0]) + Math.Abs((p[j])[1] - (p[i])[1]) + Math.Abs((p[j])[2] - (p[i])[2]); 
                                ndist += d;
                            }
                        }*/

                        ndist = Math.Abs((p[j])[0] - (p0)[0]) + Math.Abs((p[j])[1] - (p0)[1]) + Math.Abs((p[j])[2] - (p0)[2]) +
                                    Math.Abs((p[j])[0] - (p1)[0]) + Math.Abs((p[j])[1] - (p1)[1]) + Math.Abs((p[j])[2] - (p1)[2]) +
                                    Math.Abs((p[j])[0] - (p2)[0]) + Math.Abs((p[j])[1] - (p2)[1]) + Math.Abs((p[j])[2] - (p2)[2]) +
                                    Math.Abs((p[j])[0] - (p3)[0]) + Math.Abs((p[j])[1] - (p3)[1]) + Math.Abs((p[j])[2] - (p3)[2]) +
                                    Math.Abs((p[j])[0] - (p4)[0]) + Math.Abs((p[j])[1] - (p4)[1]) + Math.Abs((p[j])[2] - (p4)[2]) +
                                    Math.Abs((p[j])[0] - (p5)[0]) + Math.Abs((p[j])[1] - (p5)[1]) + Math.Abs((p[j])[2] - (p5)[2]) +
                                    Math.Abs((p[j])[0] - (p6)[0]) + Math.Abs((p[j])[1] - (p6)[1]) + Math.Abs((p[j])[2] - (p6)[2]) +
                                    Math.Abs((p[j])[0] - (p7)[0]) + Math.Abs((p[j])[1] - (p7)[1]) + Math.Abs((p[j])[2] - (p7)[2]) +
                                    Math.Abs((p[j])[0] - (p8)[0]) + Math.Abs((p[j])[1] - (p8)[1]) + Math.Abs((p[j])[2] - (p8)[2]);

                        if (dist > ndist)
                        {
                            dist = ndist;
                            a = j;
                        }
                    }


                    dataPtr[0] = p[a][0];
                    dataPtr[1] = p[a][1];
                    dataPtr[2] = p[a][2];
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                //pixeis da linha inferior exceto os cantos
                for (int x = 1; x < width - 1; x++)
                {
                    int a = 0, dist = 2000;
                    p0 = (dataPtrC - widthStep - nChan);
                    p1 = (dataPtrC - widthStep);
                    p2 = (dataPtrC - widthStep + nChan);
                    p3 = (dataPtrC - nChan);
                    p4 = (dataPtrC);
                    p5 = (dataPtrC + nChan);
                    p6 = (dataPtrC - nChan);
                    p7 = (dataPtrC);
                    p8 = (dataPtrC + nChan);
                    p[0] = p0;
                    p[1] = p1;
                    p[2] = p2;
                    p[3] = p3;
                    p[4] = p4;
                    p[5] = p5;
                    p[6] = p6;
                    p[7] = p7;
                    p[8] = p8;


                    for (int j = 0; j < 9; j++)
                    {
                        int ndist = 0;

                        /*for (int i = 0; i < 9; i++)
                        {
                            int d = 0;
                           if (j != i)
                            {
                                d = Math.Abs((p[j])[0] - (p[i])[0]) + Math.Abs((p[j])[1] - (p[i])[1]) + Math.Abs((p[j])[2] - (p[i])[2]); 
                                ndist += d;
                            }
                        }*/

                        ndist = Math.Abs((p[j])[0] - (p0)[0]) + Math.Abs((p[j])[1] - (p0)[1]) + Math.Abs((p[j])[2] - (p0)[2]) +
                                    Math.Abs((p[j])[0] - (p1)[0]) + Math.Abs((p[j])[1] - (p1)[1]) + Math.Abs((p[j])[2] - (p1)[2]) +
                                    Math.Abs((p[j])[0] - (p2)[0]) + Math.Abs((p[j])[1] - (p2)[1]) + Math.Abs((p[j])[2] - (p2)[2]) +
                                    Math.Abs((p[j])[0] - (p3)[0]) + Math.Abs((p[j])[1] - (p3)[1]) + Math.Abs((p[j])[2] - (p3)[2]) +
                                    Math.Abs((p[j])[0] - (p4)[0]) + Math.Abs((p[j])[1] - (p4)[1]) + Math.Abs((p[j])[2] - (p4)[2]) +
                                    Math.Abs((p[j])[0] - (p5)[0]) + Math.Abs((p[j])[1] - (p5)[1]) + Math.Abs((p[j])[2] - (p5)[2]) +
                                    Math.Abs((p[j])[0] - (p6)[0]) + Math.Abs((p[j])[1] - (p6)[1]) + Math.Abs((p[j])[2] - (p6)[2]) +
                                    Math.Abs((p[j])[0] - (p7)[0]) + Math.Abs((p[j])[1] - (p7)[1]) + Math.Abs((p[j])[2] - (p7)[2]) +
                                    Math.Abs((p[j])[0] - (p8)[0]) + Math.Abs((p[j])[1] - (p8)[1]) + Math.Abs((p[j])[2] - (p8)[2]);

                        if (dist > ndist)
                        {
                            dist = ndist;
                            a = j;
                        }
                    }


                    dataPtr[0] = p[a][0];
                    dataPtr[1] = p[a][1];
                    dataPtr[2] = p[a][2];

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                //pixel do canto inferior direito
                {
                    int a = 0, dist = 2000;
                    p0 = (dataPtrC - widthStep - nChan);
                    p1 = (dataPtrC - widthStep);
                    p2 = (dataPtrC - widthStep);
                    p3 = (dataPtrC - nChan);
                    p4 = (dataPtrC);
                    p5 = (dataPtrC);
                    p6 = (dataPtrC - nChan);
                    p7 = (dataPtrC);
                    p8 = (dataPtrC);
                    p[0] = p0;
                    p[1] = p1;
                    p[2] = p2;
                    p[3] = p3;
                    p[4] = p4;
                    p[5] = p5;
                    p[6] = p6;
                    p[7] = p7;
                    p[8] = p8;


                    for (int j = 0; j < 9; j++)
                    {
                        int ndist = 0;

                        /*for (int i = 0; i < 9; i++)
                        {
                            int d = 0;
                           if (j != i)
                            {
                                d = Math.Abs((p[j])[0] - (p[i])[0]) + Math.Abs((p[j])[1] - (p[i])[1]) + Math.Abs((p[j])[2] - (p[i])[2]); 
                                ndist += d;
                            }
                        }*/

                        ndist = Math.Abs((p[j])[0] - (p0)[0]) + Math.Abs((p[j])[1] - (p0)[1]) + Math.Abs((p[j])[2] - (p0)[2]) +
                                    Math.Abs((p[j])[0] - (p1)[0]) + Math.Abs((p[j])[1] - (p1)[1]) + Math.Abs((p[j])[2] - (p1)[2]) +
                                    Math.Abs((p[j])[0] - (p2)[0]) + Math.Abs((p[j])[1] - (p2)[1]) + Math.Abs((p[j])[2] - (p2)[2]) +
                                    Math.Abs((p[j])[0] - (p3)[0]) + Math.Abs((p[j])[1] - (p3)[1]) + Math.Abs((p[j])[2] - (p3)[2]) +
                                    Math.Abs((p[j])[0] - (p4)[0]) + Math.Abs((p[j])[1] - (p4)[1]) + Math.Abs((p[j])[2] - (p4)[2]) +
                                    Math.Abs((p[j])[0] - (p5)[0]) + Math.Abs((p[j])[1] - (p5)[1]) + Math.Abs((p[j])[2] - (p5)[2]) +
                                    Math.Abs((p[j])[0] - (p6)[0]) + Math.Abs((p[j])[1] - (p6)[1]) + Math.Abs((p[j])[2] - (p6)[2]) +
                                    Math.Abs((p[j])[0] - (p7)[0]) + Math.Abs((p[j])[1] - (p7)[1]) + Math.Abs((p[j])[2] - (p7)[2]) +
                                    Math.Abs((p[j])[0] - (p8)[0]) + Math.Abs((p[j])[1] - (p8)[1]) + Math.Abs((p[j])[2] - (p8)[2]);

                        if (dist > ndist)
                        {
                            dist = ndist;
                            a = j;
                        }
                    }


                    dataPtr[0] = p[a][0];
                    dataPtr[1] = p[a][1];
                    dataPtr[2] = p[a][2];
                }
            }
        }

        /// <summary>
        /// Convert to histrogram gray
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        /// <param name="imgCopy">image</param>
        public static int[] Histogram_Gray(Emgu.CV.Image<Bgr, byte> img)
        {
            unsafe
            { 
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte blue, green, red, gray;

                int[] hist = new int[256];
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //retrieve 3 colour components
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            // convert to gray
                            gray = (byte)Math.Round((int)(blue + green + red) / 3.0);

                            // store the gray values in array
                            hist[gray]++;

                            // advance the pointer to the next pixel
                            dataPtr += nChan;
                        }

                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding;
                    }
                }
                return hist;
            }
        }

        /// <summary>
        /// Convert to histrogram RGB
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        /// <param name="imgCopy">image</param>
        public static int[,] Histogram_RGB(Emgu.CV.Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                int blue, green, red;

                int[,] hist = new int[3, 256];
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //retrieve 3 colour components
                            blue = (int)dataPtr[0];
                            green = (int)dataPtr[1];
                            red = (int)dataPtr[2];


                            // store the RGB values in array
                            hist[0, blue]++;
                            hist[1, green]++;
                            hist[2, red]++;

                            // advance the pointer to the next pixel
                            dataPtr += nChan;
                        }

                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding;
                    }
                }
                return hist;
            }
        }

        /// <summary>
        /// Convert to histrogram All
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        /// <param name="imgCopy">image</param>
        public static int[,] Histogram_All(Emgu.CV.Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte blue, green, red;
                int b, g, r, gray;

                int[,] hist = new int[4, 256];
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //retrieve 3 colour components
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];
                            b = (int)dataPtr[0];
                            g = (int)dataPtr[1];
                            r = (int)dataPtr[2];

                            // convert to gray
                            gray = (int)Math.Round((b + g + r) / 3.0);

                            // store the gray and RGB values in array
                            hist[0, gray]++;
                            hist[1, blue]++;
                            hist[2, green]++;
                            hist[3, red]++;

                            // advance the pointer to the next pixel
                            dataPtr += nChan;
                        }

                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding;
                    }
                }
                return hist;
            }
        }

        /// <summary>
        /// Convert to convert to black and white with given threshold
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        public static void ConvertToBW(Emgu.CV.Image<Bgr, byte> img, int threshold)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte blue, green, red;
                int gray;

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                 
                for (y = 0; y < height; y++)
                {
                    for (x = 0; x < width; x++)
                    {
                        //retrieve 3 colour components
                        blue = dataPtr[0];
                        green = dataPtr[1];
                        red = dataPtr[2];

                        gray = (byte)Math.Round((int)(blue + green + red) / 3.0);

                        if (gray > threshold)
                        {
                            dataPtr[0] = 255;
                            dataPtr[1] = 255;
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            dataPtr[0] = 0;
                            dataPtr[1] = 0;
                            dataPtr[2] = 0;
                        }
                        
                        
                        // advance the pointer to the next pixel
                        dataPtr += nChan;
                    }

                    //at the end of the line advance the pointer by the aligment bytes (padding)
                    dataPtr += padding;
                }    
            }
        }

        static int OTSU(int[] hist)
        {
            int threshold = 0, i; 
            double sigma = 0;

            for (i = 0; i <= 255; i++)
            {
                double tpixels, sig, tq1=0, tq2=0, q1 = 0, q2 = 0, u1 = 0, u2 = 0, a = 0, b = 0;

                for (int j = 0; j <= i; j++)
                {
                    tq1 += hist[j];
                    a += j * hist[j];
                }
                for (int j = (i + 1); j <= 255; j++)
                {
                    tq2 += hist[j];
                    b += j * hist[j];
                }

                tpixels = tq1 + tq2;
                q1 = tq1 / tpixels;
                q2 = tq2 / tpixels;

                if(q1 != 0)
                {
                    u1 = a / tq1;
                }
                else
                {
                    u1 = 0;
                }

                if (q2 != 0)
                {
                    u2 = b / tq2;
                }
                else
                {
                    u2 = 0;
                }

                sig = q1 * q2 * Math.Pow((u1 - u2), 2);

                if (sig > sigma)
                {
                    sigma = sig;
                    threshold = i;
                }
            }

            return threshold;
        }

        /// <summary>
        /// Convert to convert to black and white with best threshold
        /// Direct access to memory - faster method
        /// </summary>
        /// <param name="img">image</param>
        public static void ConvertToBW_Otsu(Emgu.CV.Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                int threshold = 12345;
                int[] hist = new int[256];

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                
                hist = Histogram_Gray(img);
                threshold = OTSU(hist);
                ConvertToBW(img, threshold);
                
            }
            
        }

        public static void Roberts(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr1 = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtr2 = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int y = 0;
                int x = 0;

                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)

                int blue = 0;
                int green = 0;
                int red = 0;

                // pixel --- right
                // below --- below_right

                for (y = 0; y < (height - 1); y++)
                {
                    //core
                    for (x = 0; x < (width - 1); x++)
                    {

                        blue = (int)(Math.Abs(dataPtr2[0] - (dataPtr2 + widthStep + nChan)[0]) + Math.Abs((dataPtr2 + nChan)[0] - (dataPtr2 + widthStep)[0]));

                        green = (int)(Math.Abs(dataPtr2[1] - (dataPtr2 + widthStep + nChan)[1]) + Math.Abs((dataPtr2 + nChan)[1] - (dataPtr2 + widthStep)[1]));

                        red = (int)(Math.Abs(dataPtr2[2] - (dataPtr2 + widthStep + nChan)[2]) + Math.Abs((dataPtr2 + nChan)[2] - (dataPtr2 + widthStep)[2]));

                        if (blue > 255)
                            blue = 255;

                        if (green > 255)
                            green = 255;

                        if (red > 255)
                            red = 255;

                        dataPtr1[0] = (byte)blue;
                        dataPtr1[1] = (byte)green;
                        dataPtr1[2] = (byte)red;

                        dataPtr1 += nChan;
                        dataPtr2 += nChan;
                    }

                    //coluna da direita

                    blue = (int)(2 * Math.Abs(dataPtr2[0] - (dataPtr2 + widthStep)[0]));

                    green = (int)(2 * Math.Abs(dataPtr2[1] - (dataPtr2 + widthStep)[1]));

                    red = (int)(2 * Math.Abs(dataPtr2[2] - (dataPtr2 + widthStep)[2]));

                    if (blue > 255)
                        blue = 255;

                    if (green > 255)
                        green = 255;

                    if (red > 255)
                        red = 255;

                    dataPtr1[0] = (byte)blue;
                    dataPtr1[1] = (byte)green;
                    dataPtr1[2] = (byte)red;


                    dataPtr1 += (padding + nChan);
                    dataPtr2 += (padding + nChan);
                }

                //ultima linha
                for (x = 0; x < (width - 1); x++)
                {

                    blue = (int)(2 * Math.Abs(dataPtr2[0] - (dataPtr2 + nChan)[0]));

                    green = (int)(2 * Math.Abs(dataPtr2[1] - (dataPtr2 + nChan)[1]));

                    red = (int)(2 * Math.Abs(dataPtr2[2] - (dataPtr2 + nChan)[2]));

                    if (blue > 255)
                        blue = 255;

                    if (green > 255)
                        green = 255;

                    if (red > 255)
                        red = 255;

                    dataPtr1[0] = (byte)blue;
                    dataPtr1[1] = (byte)green;
                    dataPtr1[2] = (byte)red;

                    dataPtr1 += nChan;
                    dataPtr2 += nChan;
                }

                //canto inferior direito

                dataPtr1[0] = (byte)(0);
                dataPtr1[1] = (byte)(0);
                dataPtr1[2] = (byte)(0);


            }
        }

        public static string CharacterRecognize(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy)
        {
            unsafe
            {
                Image<Bgr, byte> result = img.Copy();

                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right
                //-------------------DESTINO-----------------------
                MIplImage m = result.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthstep = m.widthStep; // size of a line
                int padding = m.widthStep - m.nChannels * m.width;


                //-------------------ORIGEM------------------------
                ConvertToBW_Otsu(imgCopy);
                MIplImage mo = imgCopy.MIplImage;
                byte* dataPtrO = (byte*)mo.imageData.ToPointer(); // Pointer to the image


                //---------------OUTRAS VARIAVEIS------------------
                Image<Bgr, byte> imgCharacter, img_char_print;
                byte* dataPtrRefreshO = dataPtrO;
                byte* dataPtrRefreshD = dataPtr;
                int i, xd, yd;
                int diff = 0;
                int diffTotal = 0;
                int indexChar = 0;

                string path = Directory.GetCurrentDirectory();
                string target = "BD";    //Colocar a diretoria onde tem as imagens dos caracteres

                //----GUARDA TODOS OS FICHEIROS DA DIRETORIA-------
                string[] filesList = Directory.GetFiles(target);

                //----------ENCONTRA CARACTER ESCOLHIDO------------
                for (i = 0; i < filesList.Length; i++)
                {
                    diff = 0;
                    imgCharacter = new Image<Bgr, byte>(filesList[i]);
                    imgCharacter = imgCharacter.Resize(width, height, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC).Copy();
                    ConvertToBW_Otsu(imgCharacter);
                    MIplImage mchar = imgCharacter.MIplImage;
                    byte* dataPtrChar = (byte*)mchar.imageData.ToPointer(); // Pointer to the image
                    byte* dataPtrRefreshC = dataPtrChar;

                    if (nChan == 3) // image in RGB
                    {
                        for (yd = 0; yd < height; yd++)
                        {
                            for (xd = 0; xd < width; xd++)
                            {
                                dataPtrO = dataPtrRefreshO + yd * widthstep + xd * nChan;
                                dataPtr = dataPtrRefreshD + yd * widthstep + xd * nChan;
                                dataPtrChar = dataPtrRefreshC + yd * widthstep + xd * nChan;

                                dataPtr[0] = (byte)(dataPtrO[0] - dataPtrChar[0]);
                                dataPtr[1] = (byte)(dataPtrO[1] - dataPtrChar[1]);
                                dataPtr[2] = (byte)(dataPtrO[2] - dataPtrChar[2]);

                                if ((dataPtr[0] + dataPtr[1] + dataPtr[2]) != 0)
                                {
                                    diff++;
                                }
                            }
                        }
                    }
                    if (i == 0)
                    {
                        diffTotal = diff;
                    }
                    if (diffTotal > diff)
                    {
                        diffTotal = diff;
                        indexChar = i;
                    }
                }

                string character = Path.GetFileName(filesList[indexChar]);
                char[] remove = { '.', 'b', 'm', 'p' };
                character = character.TrimEnd(remove);
                Console.WriteLine("The Letter is {0}", character);
                img_char_print = new Image<Bgr, byte>(filesList[indexChar]);

                return character;
            }
        }


        public static Rectangle[] CharacterSeparate(Image<Bgr, byte> img)
        {
            unsafe
            {
                Image<Bgr, byte> result = img.Copy();
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right
                //-------------------DESTINO-----------------------
                MIplImage m = result.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthstep = m.widthStep; // size of a line
                int padding = m.widthStep - m.nChannels * m.width;

                //---------------OUTRAS VARIAVEIS------------------
                byte* dataPtrRefreshD = dataPtr;
                int x, y;
                int[] numColPretos = new int[width];
                int[] numLinPretos = new int[height];
                int Ylin = 0, characterHeight = 0;
                int[] xChar = new int[6];
                int[] widthChar = new int[6];
                int[][] white_hist;
                int min_value, min_value_size;
               

                //--------------APLICA FILTRO BW OTSU--------------
                ConvertToBW_Otsu(result);
                //--------------APLICA FILTRO NEGATIVO--------------
                Negative(result);
                //--------------APLICA HISTOGRAMA DE BRANCOS-----------
                white_hist = WhiteGraph(result);

                min_value = white_hist[1].Length / 11; //divide by 11 and not 10 so it catches the base of the U and the tips of 1, T, etc
                min_value_size = 4 * (white_hist[1].Length / 10)*(white_hist[1].Length / 10);

                for (int i = 0, a = 0, fc = 0, k = 0, size = 0; i < white_hist[0].Length; i++)
                {
                    if (a == 0)
                    {
                        if ((i != 0 && white_hist[0][i] >= min_value && white_hist[0][i - 1] < min_value) || (i == 0 && white_hist[0][i] >= min_value))
                        {
                            fc = i;
                            a = 1;
                            size = white_hist[0][i];
                        }
                    }
                    else
                    {
                        if (white_hist[0][i] >= min_value)
                        {
                            size += white_hist[0][i];
                        }
                        else
                        {
                            if (size <= min_value_size)
                            {
                                a = 0;
                                size = 0;
                                i--;
                            }
                            else
                            {
                                xChar[k] = fc;
                                widthChar[k] = i - fc;
                                k++;
                                if (k==6)
                                {
                                    break;
                                }
                                a = 0;
                            }
                        }                        
                    }
                    if (i == (white_hist[0].Length - 1))
                    {
                        xChar[k] = fc;
                        widthChar[k] = i - fc;
                    }
                }

                Ylin = 0;
                characterHeight = height;

                Rectangle LP_Chr1 = new Rectangle(xChar[0], Ylin, widthChar[0], characterHeight);
                Rectangle LP_Chr2 = new Rectangle(xChar[1], Ylin, widthChar[1], characterHeight);
                Rectangle LP_Chr3 = new Rectangle(xChar[2], Ylin, widthChar[2], characterHeight);
                Rectangle LP_Chr4 = new Rectangle(xChar[3], Ylin, widthChar[3], characterHeight);
                Rectangle LP_Chr5 = new Rectangle(xChar[4], Ylin, widthChar[4], characterHeight);
                Rectangle LP_Chr6 = new Rectangle(xChar[5], Ylin, widthChar[5], characterHeight);

                Rectangle[] charPositions = { LP_Chr1, LP_Chr2, LP_Chr3, LP_Chr4, LP_Chr5, LP_Chr6 };

                return charPositions;
            }
        }

        public static int[][] WhiteGraph(Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int[] histx = new int[width];
                int[] histy = new int[height];
                int[][] hist = new int[2][];
                int x, y;
                double blue, green, red;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        int white = 0;

                        for (x = 0; x < width; x++)
                        {
                            //retrieve 3 colour components
                            blue = (double)dataPtr[0];
                            green = (double)dataPtr[1];
                            red = (double)dataPtr[2];

                            // check if white
                            white = (int)Math.Round((blue + green + red) / 3.0);

                            if (white == 255)
                            {
                                // store the white values in array
                                histx[x]++;
                                histy[y]++;
                            }

                            //Go to the next pixel in the line
                            dataPtr += nChan;
                        }

                        // Go to the next line
                        dataPtr += padding;
                    }
                }

                hist[0] = histx;
                hist[1] = histy;
                
                return hist;
            }
        }

        public static int[] Histogram_Blue(Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int[] histx = new int[width];
                int blue, red, green, x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //retrieve 3 colour components
                            blue = (int)dataPtr[0];
                            green = (int)dataPtr[1];
                            red = (int)dataPtr[2];
                            
                            if (blue >= 100 && green <= blue && red < green && red < 100 && blue - red >= 50) 
                            {
                                // store the white values in array
                                histx[x]++;
                            }

                            //Go to the next pixel in the line
                            dataPtr += nChan;
                        }

                        // Go to the next line
                        dataPtr += padding;
                    }
                }
                return histx;
            }
        }

        public static void Dilatation(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = widthStep - nChan * m.width; // alinhament bytes (padding)

                //pixel do canto superior esquerdo
                if (dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255)
                {
                    
                    (dataPtr + nChan)[0] = 255;
                    (dataPtr + nChan)[1] = 255;
                    (dataPtr + nChan)[2] = 255;

                    (dataPtr + widthStep)[0] = 255;
                    (dataPtr + widthStep)[1] = 255;
                    (dataPtr + widthStep)[2] = 255;
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                //pixeis da linha superior exceto os cantos
                for (int x = 1; x < width - 1; x++)
                {
                    if (dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255)
                    {
                        (dataPtr - nChan)[0] = 255;
                        (dataPtr - nChan)[1] = 255;
                        (dataPtr - nChan)[2] = 255;

                        (dataPtr + nChan)[0] = 255;
                        (dataPtr + nChan)[1] = 255;
                        (dataPtr + nChan)[2] = 255;

                        (dataPtr + widthStep)[0] = 255;
                        (dataPtr + widthStep)[1] = 255;
                        (dataPtr + widthStep)[2] = 255;
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }


                //pixel do canto superior direito
                if (dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255)
                {
                    (dataPtr - nChan)[0] = 255;
                    (dataPtr - nChan)[1] = 255;
                    (dataPtr - nChan)[2] = 255;

                    (dataPtr + widthStep)[0] = 255;
                    (dataPtr + widthStep)[1] = 255;
                    (dataPtr + widthStep)[2] = 255;
                }

                dataPtr += (padding + nChan);
                dataPtrC += (padding + nChan);

                for (int y = 1; y < height - 1; y++)
                {
                    //pixeis da coluna da esquerda exceto os cantos
                    if (dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255)
                    {
                        (dataPtr - widthStep)[0] = 255;
                        (dataPtr - widthStep)[1] = 255;
                        (dataPtr - widthStep)[2] = 255;

                        (dataPtr + nChan)[0] = 255;
                        (dataPtr + nChan)[1] = 255;
                        (dataPtr + nChan)[2] = 255;

                        (dataPtr + widthStep)[0] = 255;
                        (dataPtr + widthStep)[1] = 255;
                        (dataPtr + widthStep)[2] = 255;
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;

                    //core da imagem
                    for (int x = 1; x < width - 1; x++)
                    {
                        if (dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255)
                        {
                            (dataPtr - widthStep)[0] = 255;
                            (dataPtr - widthStep)[1] = 255;
                            (dataPtr - widthStep)[2] = 255;

                            (dataPtr - nChan)[0] = 255;
                            (dataPtr - nChan)[1] = 255;
                            (dataPtr - nChan)[2] = 255;

                            (dataPtr + nChan)[0] = 255;
                            (dataPtr + nChan)[1] = 255;
                            (dataPtr + nChan)[2] = 255;

                            (dataPtr + widthStep)[0] = 255;
                            (dataPtr + widthStep)[1] = 255;
                            (dataPtr + widthStep)[2] = 255;
                        }

                        dataPtr += nChan;
                        dataPtrC += nChan;
                    }

                    //pixeis da coluna da direita exceto os cantos
                    if (dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255)
                    {
                        (dataPtr - widthStep)[0] = 255;
                        (dataPtr - widthStep)[1] = 255;
                        (dataPtr - widthStep)[2] = 255;

                        (dataPtr - nChan)[0] = 255;
                        (dataPtr - nChan)[1] = 255;
                        (dataPtr - nChan)[2] = 255;

                        (dataPtr + widthStep)[0] = 255;
                        (dataPtr + widthStep)[1] = 255;
                        (dataPtr + widthStep)[2] = 255;
                    }

                    dataPtr += (padding + nChan);
                    dataPtrC += (padding + nChan);
                }

                //pixel do canto inferior esquerdo
                if (dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255)
                {
                    (dataPtr - widthStep)[0] = 255;
                    (dataPtr - widthStep)[1] = 255;
                    (dataPtr - widthStep)[2] = 255;

                    (dataPtr + nChan)[0] = 255;
                    (dataPtr + nChan)[1] = 255;
                    (dataPtr + nChan)[2] = 255;
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                //pixeis da linha inferior exceto os cantos
                for (int x = 1; x < width - 1; x++)
                {
                    if (dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255)
                    {
                        (dataPtr - widthStep)[0] = 255;
                        (dataPtr - widthStep)[1] = 255;
                        (dataPtr - widthStep)[2] = 255;

                        (dataPtr - nChan)[0] = 255;
                        (dataPtr - nChan)[1] = 255;
                        (dataPtr - nChan)[2] = 255;

                        (dataPtr + nChan)[0] = 255;
                        (dataPtr + nChan)[1] = 255;
                        (dataPtr + nChan)[2] = 255;
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                //pixel do canto inferior direito
                if (dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255)
                {
                    (dataPtr - widthStep)[0] = 255;
                    (dataPtr - widthStep)[1] = 255;
                    (dataPtr - widthStep)[2] = 255;

                    (dataPtr - nChan)[0] = 255;
                    (dataPtr - nChan)[1] = 255;
                    (dataPtr - nChan)[2] = 255;
                }
            }
        }

        public static void Erosion(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = widthStep - nChan * m.width; // alinhament bytes (padding)

                //pixel do canto superior esquerdo
                if (!(dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255 &&
                     (dataPtrC + nChan)[0] == 255 && (dataPtrC + nChan)[1] == 255 && (dataPtrC + nChan)[2] == 255 && 
                     (dataPtrC + widthStep)[0] == 255 && (dataPtrC + widthStep)[1] == 255 && (dataPtrC + widthStep)[2] == 255)) 
                {
                    dataPtr[0] = 0;
                    dataPtr[1] = 0;
                    dataPtr[2] = 0;
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                //pixeis da linha superior exceto os cantos
                for (int x = 1; x < width - 1; x++)
                {
                    if (!((dataPtrC - nChan)[0] == 255 && (dataPtrC - nChan)[1] == 255 && (dataPtrC - nChan)[2] == 255 &&
                           dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255 &&
                          (dataPtrC + nChan)[0] == 255 && (dataPtrC + nChan)[1] == 255 && (dataPtrC + nChan)[2] == 255 &&
                          (dataPtrC + widthStep)[0] == 255 && (dataPtrC + widthStep)[1] == 255 && (dataPtrC + widthStep)[2] == 255))
                    {
                        (dataPtr)[0] = 0;
                        (dataPtr)[1] = 0;
                        (dataPtr)[2] = 0;
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }


                //pixel do canto superior direito
                if (!((dataPtrC - nChan)[0] == 255 && (dataPtrC - nChan)[1] == 255 && (dataPtrC - nChan)[2] == 255 &&
                       dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255 &&
                      (dataPtrC + widthStep)[0] == 255 && (dataPtrC + widthStep)[1] == 255 && (dataPtrC + widthStep)[2] == 255))
                {
                    dataPtr[0] = 0;
                    dataPtr[1] = 0;
                    dataPtr[2] = 0;
                }

                dataPtr += (padding + nChan);
                dataPtrC += (padding + nChan);

                for (int y = 1; y < height - 1; y++)
                {
                    //pixeis da coluna da esquerda exceto os cantos
                    if (!((dataPtrC - widthStep)[0] == 255 && (dataPtrC - widthStep)[1] == 255 && (dataPtrC - widthStep)[2] == 255 &&
                           dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255 &&
                          (dataPtrC + nChan)[0] == 255 && (dataPtrC + nChan)[1] == 255 && (dataPtrC + nChan)[2] == 255 &&
                          (dataPtrC + widthStep)[0] == 255 && (dataPtrC + widthStep)[1] == 255 && (dataPtrC + widthStep)[2] == 255))
                    {
                        (dataPtr)[0] = 0;
                        (dataPtr)[1] = 0;
                        (dataPtr)[2] = 0;
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;

                    //core da imagem
                    for (int x = 1; x < width - 1; x++)
                    {
                        if (!((dataPtrC - widthStep)[0] == 255 && (dataPtrC - widthStep)[1] == 255 && (dataPtrC - widthStep)[2] == 255 &&
                              (dataPtrC - nChan)[0] == 255 && (dataPtrC - nChan)[1] == 255 && (dataPtrC - nChan)[2] == 255 &&
                               dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255 &&
                              (dataPtrC + nChan)[0] == 255 && (dataPtrC + nChan)[1] == 255 && (dataPtrC + nChan)[2] == 255 &&
                              (dataPtrC + widthStep)[0] == 255 && (dataPtrC + widthStep)[1] == 255 && (dataPtrC + widthStep)[2] == 255))
                        {
                            (dataPtr)[0] = 0;
                            (dataPtr)[1] = 0;
                            (dataPtr)[2] = 0;
                        }

                        dataPtr += nChan;
                        dataPtrC += nChan;
                    }

                    //pixeis da coluna da direita exceto os cantos
                    if (!((dataPtrC - widthStep)[0] == 255 && (dataPtrC - widthStep)[1] == 255 && (dataPtrC - widthStep)[2] == 255 &&
                          (dataPtrC - nChan)[0] == 255 && (dataPtrC - nChan)[1] == 255 && (dataPtrC - nChan)[2] == 255 &&
                           dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255 &&
                          (dataPtrC + widthStep)[0] == 255 && (dataPtrC + widthStep)[1] == 255 && (dataPtrC + widthStep)[2] == 255))
                    {
                        (dataPtr)[0] = 0;
                        (dataPtr)[1] = 0;
                        (dataPtr)[2] = 0;
                    }

                    dataPtr += (padding + nChan);
                    dataPtrC += (padding + nChan);
                }

                //pixel do canto inferior esquerdo
                if (!((dataPtrC - widthStep)[0] == 255 && (dataPtrC - widthStep)[1] == 255 && (dataPtrC - widthStep)[2] == 255 &&
                       dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255 &&
                      (dataPtrC + nChan)[0] == 255 && (dataPtrC + nChan)[1] == 255 && (dataPtrC + nChan)[2] == 255))
                {
                    (dataPtr)[0] = 0;
                    (dataPtr)[1] = 0;
                    (dataPtr)[2] = 0;
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                //pixeis da linha inferior exceto os cantos
                for (int x = 1; x < width - 1; x++)
                {
                    if (!((dataPtrC - widthStep)[0] == 255 && (dataPtrC - widthStep)[1] == 255 && (dataPtrC - widthStep)[2] == 255 &&
                          (dataPtrC - nChan)[0] == 255 && (dataPtrC - nChan)[1] == 255 && (dataPtrC - nChan)[2] == 255 &&
                           dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255 &&
                          (dataPtrC + nChan)[0] == 255 && (dataPtrC + nChan)[1] == 255 && (dataPtrC + nChan)[2] == 255))
                    {
                        (dataPtr)[0] = 0;
                        (dataPtr)[1] = 0;
                        (dataPtr)[2] = 0;
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                //pixel do canto inferior direito
                if (!((dataPtrC - widthStep)[0] == 255 && (dataPtrC - widthStep)[1] == 255 && (dataPtrC - widthStep)[2] == 255 &&
                              (dataPtrC - nChan)[0] == 255 && (dataPtrC - nChan)[1] == 255 && (dataPtrC - nChan)[2] == 255 &&
                               dataPtrC[0] == 255 && dataPtrC[1] == 255 && dataPtrC[2] == 255))
                {
                    (dataPtr)[0] = 0;
                    (dataPtr)[1] = 0;
                    (dataPtr)[2] = 0;
                }
            }
        }

        public static void Sobel_vertical(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = widthStep - nChan * m.width; // alinhament bytes (padding)
                int blue, green, red;

                blue = (int)(Math.Abs((3 * (dataPtrC)[0] + (dataPtrC + widthStep)[0]) - (3 * (dataPtrC + nChan)[0] + (dataPtrC + widthStep + nChan)[0])));
                green = (int)(Math.Abs((3 * (dataPtrC)[1] + (dataPtrC + widthStep)[1]) - (3 * (dataPtrC + nChan)[1] + (dataPtrC + widthStep + nChan)[1])));
                red = (int)(Math.Abs((3 * (dataPtrC)[2] + (dataPtrC + widthStep)[2]) - (3 * (dataPtrC + nChan)[2] + (dataPtrC + widthStep + nChan)[2])));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                for (int x = 1; x < width - 1; x++)
                {
                    blue = (int)(Math.Abs((3 * (dataPtrC - nChan)[0] + (dataPtrC + widthStep - nChan)[0]) - (3 * (dataPtrC + nChan)[0] + (dataPtrC + widthStep + nChan)[0])));
                    green = (int)(Math.Abs((3 * (dataPtrC - nChan)[1] + (dataPtrC + widthStep - nChan)[1]) - (3 * (dataPtrC + nChan)[1] + (dataPtrC + widthStep + nChan)[1])));
                    red = (int)(Math.Abs((3 * (dataPtrC - nChan)[2] + (dataPtrC + widthStep - nChan)[2]) - (3 * (dataPtrC + nChan)[2] + (dataPtrC + widthStep + nChan)[2])));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                blue = (int)(Math.Abs((3 * (dataPtrC - nChan)[0] + (dataPtrC + widthStep - nChan)[0]) - (3 * dataPtrC[0] + (dataPtrC + widthStep)[0])));
                green = (int)(Math.Abs((3 * (dataPtrC - nChan)[1] + (dataPtrC + widthStep - nChan)[1]) - (3 * dataPtrC[1] + (dataPtrC + widthStep)[1])));
                red = (int)(Math.Abs((3 * (dataPtrC - nChan)[2] + (dataPtrC + widthStep - nChan)[2]) - (3 * dataPtrC[2] + (dataPtrC + widthStep)[2])));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                dataPtr += (padding + nChan);
                dataPtrC += (padding + nChan);

                for (int y = 1; y < height - 1; y++)
                {

                    blue = (int)(Math.Abs(((dataPtrC - widthStep)[0] + 2 * dataPtrC[0] + (dataPtrC + widthStep)[0]) - ((dataPtrC - widthStep + nChan)[0] + 2 * (dataPtrC + nChan)[0] + (dataPtrC + widthStep + nChan)[0])));
                    green = (int)(Math.Abs(((dataPtrC - widthStep)[1] + 2 * dataPtrC[1] + (dataPtrC + widthStep)[1]) - ((dataPtrC - widthStep + nChan)[1] + 2 * (dataPtrC + nChan)[1] + (dataPtrC + widthStep + nChan)[1])));
                    red = (int)(Math.Abs(((dataPtrC - widthStep)[2] + 2 * dataPtrC[2] + (dataPtrC + widthStep)[2]) - ((dataPtrC - widthStep + nChan)[2] + 2 * (dataPtrC + nChan)[2] + (dataPtrC + widthStep + nChan)[2])));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;

                    for (int x = 1; x < width - 1; x++)
                    {
                        // store in the image
                        blue = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[0] + 2 * (dataPtrC - nChan)[0] + (dataPtrC + widthStep - nChan)[0]) - ((dataPtrC - widthStep + nChan)[0] + 2 * (dataPtrC + nChan)[0] + (dataPtrC + widthStep + nChan)[0])));
                        green = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[1] + 2 * (dataPtrC - nChan)[1] + (dataPtrC + widthStep - nChan)[1]) - ((dataPtrC - widthStep + nChan)[1] + 2 * (dataPtrC + nChan)[1] + (dataPtrC + widthStep + nChan)[1])));
                        red = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[2] + 2 * (dataPtrC - nChan)[2] + (dataPtrC + widthStep - nChan)[2]) - ((dataPtrC - widthStep + nChan)[2] + 2 * (dataPtrC + nChan)[2] + (dataPtrC + widthStep + nChan)[2])));

                        {
                            if (blue > 255)
                            {
                                dataPtr[0] = 255;
                            }
                            else
                            {
                                if (blue < 0)
                                {
                                    dataPtr[0] = 0;
                                }
                                else
                                {
                                    dataPtr[0] = (byte)blue;
                                }
                            }
                            if (green > 255)
                            {
                                dataPtr[1] = 255;
                            }
                            else
                            {
                                if (green < 0)
                                {
                                    dataPtr[1] = 0;
                                }
                                else
                                {
                                    dataPtr[1] = (byte)green;
                                }
                            }
                            if (red > 255)
                            {
                                dataPtr[2] = 255;
                            }
                            else
                            {
                                if (red < 0)
                                {
                                    dataPtr[2] = 0;
                                }
                                else
                                {
                                    dataPtr[2] = (byte)red;
                                }
                            }
                        }

                        dataPtr += nChan;
                        dataPtrC += nChan;
                    }

                    blue = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[0] + 2 * (dataPtrC - nChan)[0] + (dataPtrC + widthStep - nChan)[0]) - ((dataPtrC - widthStep)[0] + 2 * dataPtrC[0] + (dataPtrC + widthStep)[0])));
                    green = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[1] + 2 * (dataPtrC - nChan)[1] + (dataPtrC + widthStep - nChan)[1]) - ((dataPtrC - widthStep)[1] + 2 * dataPtrC[1] + (dataPtrC + widthStep)[1])));
                    red = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[2] + 2 * (dataPtrC - nChan)[2] + (dataPtrC + widthStep - nChan)[2]) - ((dataPtrC - widthStep)[2] + 2 * dataPtrC[2] + (dataPtrC + widthStep)[2])));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += (padding + nChan);
                    dataPtrC += (padding + nChan);
                }

                blue = (int)(Math.Abs(((dataPtrC - widthStep)[0] + 3 * dataPtrC[0]) - ((dataPtrC - widthStep + nChan)[0] + 3 * (dataPtrC + nChan)[0])));
                green = (int)(Math.Abs(((dataPtrC - widthStep)[1] + 3 * dataPtrC[1]) - ((dataPtrC - widthStep + nChan)[1] + 3 * (dataPtrC + nChan)[1])));
                red = (int)(Math.Abs(((dataPtrC - widthStep)[2] + 3 * dataPtrC[2]) - ((dataPtrC - widthStep + nChan)[2] + 3 * (dataPtrC + nChan)[2])));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                for (int x = 1; x < width - 1; x++)
                {
                    blue = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[0] + 3 * (dataPtrC - nChan)[0]) - ((dataPtrC - widthStep + nChan)[0] + 3 * (dataPtrC + nChan)[0])));
                    green = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[1] + 3 * (dataPtrC - nChan)[1]) - ((dataPtrC - widthStep + nChan)[1] + 3 * (dataPtrC + nChan)[1])));
                    red = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[2] + 3 * (dataPtrC - nChan)[2]) - ((dataPtrC - widthStep + nChan)[2] + 3 * (dataPtrC + nChan)[2])));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                blue = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[0] + 3 * (dataPtrC - nChan)[0]) - ((dataPtrC - widthStep)[0] + 3 * dataPtrC[0])));
                green = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[1] + 3 * (dataPtrC - nChan)[1]) - ((dataPtrC - widthStep)[1] + 3 * dataPtrC[1])));
                red = (int)(Math.Abs(((dataPtrC - widthStep - nChan)[2] + 3 * (dataPtrC - nChan)[2]) - ((dataPtrC - widthStep)[2] + 3 * dataPtrC[2])));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

            }
        }

        public static void Sobel_horizontal(Image<Bgr, byte> img, Image<Bgr, byte> imgCopy)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image

                MIplImage mC = imgCopy.MIplImage;
                byte* dataPtrC = (byte*)mC.imageData.ToPointer(); // Pointer to the image

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = widthStep - nChan * m.width; // alinhament bytes (padding)
                int blue, green, red;

                blue = (int)(Math.Abs((3 * (dataPtrC + widthStep)[0] + (dataPtrC + widthStep + nChan)[0]) - (3 * dataPtrC[0] + (dataPtrC + nChan)[0])));
                green = (int)(Math.Abs((3 * (dataPtrC + widthStep)[1] + (dataPtrC + widthStep + nChan)[1]) - (3 * dataPtrC[1] + (dataPtrC + nChan)[1])));
                red = (int)(Math.Abs((3 * (dataPtrC + widthStep)[2] + (dataPtrC + widthStep + nChan)[2]) - (3 * dataPtrC[2] + (dataPtrC + nChan)[2])));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                for (int x = 1; x < width - 1; x++)
                {
                    blue = (int)(Math.Abs(((dataPtrC + widthStep - nChan)[0] + 2 * (dataPtrC + widthStep)[0] + (dataPtrC + widthStep + nChan)[0]) - ((dataPtrC - nChan)[0] + 2 * dataPtrC[0] + (dataPtrC + nChan)[0])));
                    green = (int)(Math.Abs(((dataPtrC + widthStep - nChan)[1] + 2 * (dataPtrC + widthStep)[1] + (dataPtrC + widthStep + nChan)[1]) - ((dataPtrC - nChan)[1] + 2 * dataPtrC[1] + (dataPtrC + nChan)[1])));
                    red = (int)(Math.Abs(((dataPtrC + widthStep - nChan)[2] + 2 * (dataPtrC + widthStep)[2] + (dataPtrC + widthStep + nChan)[2]) - ((dataPtrC - nChan)[2] + 2 * dataPtrC[2] + (dataPtrC + nChan)[2])));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                blue = (int)(Math.Abs(((dataPtrC + widthStep - nChan)[0] + 3 * (dataPtrC + widthStep)[0]) - ((dataPtrC - nChan)[0] + 3 * dataPtrC[0])));
                green = (int)(Math.Abs(((dataPtrC + widthStep - nChan)[1] + 3 * (dataPtrC + widthStep)[1]) - ((dataPtrC - nChan)[1] + 3 * dataPtrC[1])));
                red = (int)(Math.Abs(((dataPtrC + widthStep - nChan)[2] + 3 * (dataPtrC + widthStep)[2]) - ((dataPtrC - nChan)[2] + 3 * dataPtrC[2])));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                dataPtr += (padding + nChan);
                dataPtrC += (padding + nChan);

                for (int y = 1; y < height - 1; y++)
                {

                    blue = (int)(Math.Abs((3 * (dataPtrC + widthStep)[0] + (dataPtrC + widthStep + nChan)[0]) - (3 * (dataPtrC - widthStep)[0] + (dataPtrC - widthStep + nChan)[0])));
                    green = (int)(Math.Abs((3 * (dataPtrC + widthStep)[1] + (dataPtrC + widthStep + nChan)[1]) - (3 * (dataPtrC - widthStep)[1] + (dataPtrC - widthStep + nChan)[1])));
                    red = (int)(Math.Abs((3 * (dataPtrC + widthStep)[2] + (dataPtrC + widthStep + nChan)[2]) - (3 * (dataPtrC - widthStep)[2] + (dataPtrC - widthStep + nChan)[2])));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;

                    for (int x = 1; x < width - 1; x++)
                    {
                        // store in the image
                        blue = (int)(Math.Abs(((dataPtrC + widthStep - nChan)[0] + 2 * (dataPtrC + widthStep)[0] + (dataPtrC + widthStep + nChan)[0]) - ((dataPtrC - widthStep - nChan)[0] + 2 * (dataPtrC - widthStep)[0] + (dataPtrC - widthStep + nChan)[0])));
                        green = (int)(Math.Abs(((dataPtrC + widthStep - nChan)[1] + 2 * (dataPtrC + widthStep)[1] + (dataPtrC + widthStep + nChan)[1]) - ((dataPtrC - widthStep - nChan)[1] + 2 * (dataPtrC - widthStep)[1] + (dataPtrC - widthStep + nChan)[1])));
                        red = (int)(Math.Abs(((dataPtrC + widthStep - nChan)[2] + 2 * (dataPtrC + widthStep)[2] + (dataPtrC + widthStep + nChan)[2]) - ((dataPtrC - widthStep - nChan)[2] + 2 * (dataPtrC - widthStep)[2] + (dataPtrC - widthStep + nChan)[2])));

                        {
                            if (blue > 255)
                            {
                                dataPtr[0] = 255;
                            }
                            else
                            {
                                if (blue < 0)
                                {
                                    dataPtr[0] = 0;
                                }
                                else
                                {
                                    dataPtr[0] = (byte)blue;
                                }
                            }
                            if (green > 255)
                            {
                                dataPtr[1] = 255;
                            }
                            else
                            {
                                if (green < 0)
                                {
                                    dataPtr[1] = 0;
                                }
                                else
                                {
                                    dataPtr[1] = (byte)green;
                                }
                            }
                            if (red > 255)
                            {
                                dataPtr[2] = 255;
                            }
                            else
                            {
                                if (red < 0)
                                {
                                    dataPtr[2] = 0;
                                }
                                else
                                {
                                    dataPtr[2] = (byte)red;
                                }
                            }
                        }

                        dataPtr += nChan;
                        dataPtrC += nChan;
                    }

                    blue = (int)(Math.Abs(((dataPtrC + widthStep - nChan)[0] + 3 * (dataPtrC + widthStep)[0]) - ((dataPtrC - widthStep - nChan)[0] + 3 * (dataPtrC - widthStep)[0])));
                    green = (int)(Math.Abs(((dataPtrC + widthStep - nChan)[1] + 3 * (dataPtrC + widthStep)[1]) - ((dataPtrC - widthStep - nChan)[1] + 3 * (dataPtrC - widthStep)[1])));
                    red = (int)(Math.Abs(((dataPtrC + widthStep - nChan)[2] + 3 * (dataPtrC + widthStep)[2]) - ((dataPtrC - widthStep - nChan)[2] + 3 * (dataPtrC - widthStep)[2])));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += (padding + nChan);
                    dataPtrC += (padding + nChan);
                }

                blue = (int)(Math.Abs((3 * dataPtrC[0] + (dataPtrC + nChan)[0]) - (3 * (dataPtrC - widthStep)[0] + (dataPtrC - widthStep + nChan)[0])));
                green = (int)(Math.Abs((3 * dataPtrC[1] + (dataPtrC + nChan)[1]) - (3 * (dataPtrC - widthStep)[1] + (dataPtrC - widthStep + nChan)[1])));
                red = (int)(Math.Abs((3 * dataPtrC[2] + (dataPtrC + nChan)[2]) - (3 * (dataPtrC - widthStep)[2] + (dataPtrC - widthStep + nChan)[2])));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

                dataPtr += nChan;
                dataPtrC += nChan;

                for (int x = 1; x < width - 1; x++)
                {
                    blue = (int)(Math.Abs(((dataPtrC - nChan)[0] + 2 * dataPtrC[0] + (dataPtrC + nChan)[0]) - ((dataPtrC - widthStep - nChan)[0] + 2 * (dataPtrC - widthStep)[0] + (dataPtrC - widthStep + nChan)[0])));
                    green = (int)(Math.Abs(((dataPtrC - nChan)[1] + 2 * dataPtrC[1] + (dataPtrC + nChan)[1]) - ((dataPtrC - widthStep - nChan)[1] + 2 * (dataPtrC - widthStep)[1] + (dataPtrC - widthStep + nChan)[1])));
                    red = (int)(Math.Abs(((dataPtrC - nChan)[2] + 2 * dataPtrC[2] + (dataPtrC + nChan)[2]) - ((dataPtrC - widthStep - nChan)[2] + 2 * (dataPtrC - widthStep)[2] + (dataPtrC - widthStep + nChan)[2])));

                    {
                        if (blue > 255)
                        {
                            dataPtr[0] = 255;
                        }
                        else
                        {
                            if (blue < 0)
                            {
                                dataPtr[0] = 0;
                            }
                            else
                            {
                                dataPtr[0] = (byte)blue;
                            }
                        }
                        if (green > 255)
                        {
                            dataPtr[1] = 255;
                        }
                        else
                        {
                            if (green < 0)
                            {
                                dataPtr[1] = 0;
                            }
                            else
                            {
                                dataPtr[1] = (byte)green;
                            }
                        }
                        if (red > 255)
                        {
                            dataPtr[2] = 255;
                        }
                        else
                        {
                            if (red < 0)
                            {
                                dataPtr[2] = 0;
                            }
                            else
                            {
                                dataPtr[2] = (byte)red;
                            }
                        }
                    }

                    dataPtr += nChan;
                    dataPtrC += nChan;
                }

                blue = (int)(Math.Abs(((dataPtrC - nChan)[0] + 3 * dataPtrC[0]) - ((dataPtrC - widthStep - nChan)[0] + 3 * (dataPtrC - widthStep)[0])));
                green = (int)(Math.Abs(((dataPtrC - nChan)[1] + 3 * dataPtrC[1]) - ((dataPtrC - widthStep - nChan)[1] + 3 * (dataPtrC - widthStep)[1])));
                red = (int)(Math.Abs(((dataPtrC - nChan)[2] + 3 * dataPtrC[2]) - ((dataPtrC - widthStep - nChan)[2] + 3 * (dataPtrC - widthStep)[2])));

                {
                    if (blue > 255)
                    {
                        dataPtr[0] = 255;
                    }
                    else
                    {
                        if (blue < 0)
                        {
                            dataPtr[0] = 0;
                        }
                        else
                        {
                            dataPtr[0] = (byte)blue;
                        }
                    }
                    if (green > 255)
                    {
                        dataPtr[1] = 255;
                    }
                    else
                    {
                        if (green < 0)
                        {
                            dataPtr[1] = 0;
                        }
                        else
                        {
                            dataPtr[1] = (byte)green;
                        }
                    }
                    if (red > 255)
                    {
                        dataPtr[2] = 255;
                    }
                    else
                    {
                        if (red < 0)
                        {
                            dataPtr[2] = 0;
                        }
                        else
                        {
                            dataPtr[2] = (byte)red;
                        }
                    }
                }

            }
        }

        static Rectangle[] SlicesY(int[][] hist_slicesY, int height, int width, int average_value, int X)
        {
            Rectangle[] ySlices = new Rectangle[height];
            int k = 0, begin = 0, end, sumw = 0, first_max = 0, second_max = 0, first_max_point = 0, second_max_point, a = 0;

            //check how many slices of the image can potencialy have the license plate
            //if j = 1 it means is in a potencial slice
            //the slices ends when it is found a line without whites
            
            for (int i = 0; i < (hist_slicesY[1].Length - 1); i++)
            {
                if (i == 0 && hist_slicesY[1][i] > average_value)
                {
                    a = 1;
                }

                if (a == 0)
                {
                    if ((hist_slicesY[1][i] > average_value) && (hist_slicesY[1][i - 1] <= average_value))
                    {
                        begin = i;
                        a = 1;
                        sumw = 1;
                        first_max = 0;
                        second_max = 0;
                        first_max_point = i;
                    }
                }
                else 
                {
                    if (hist_slicesY[1][i] > average_value)
                    {
                        sumw++;

                        if ((hist_slicesY[1][i] > first_max) && (i - first_max_point <= 15))
                        {
                            first_max = hist_slicesY[1][i];
                            first_max_point = i;
                        }
                        else if ((hist_slicesY[1][i] > second_max))
                        {
                            second_max = hist_slicesY[1][i];
                            second_max_point = i;
                        }

                        if (hist_slicesY[1][i + 1] <= average_value || i == (hist_slicesY[1].Length - 1))
                        {
                            end = i;
                            a = 0;

                            if ((sumw > 70) && (Math.Abs(first_max - second_max) < 100) && (end - begin > 40))
                            {
                                ySlices[k] = new Rectangle(X, begin, width, end - begin);

                                k++;
                            }
                        }
                    }
                }
            }

            return ySlices;
        }

        static Rectangle[] SlicesX(int[][] hist_slicesX, int height, int width, int average_value, int Y)
        {
            Rectangle[] xSlices = new Rectangle[height];
            int k = 0, begin = 0, end, sumw = 0, first_max = 0, second_max = 0, first_max_point = 0, second_max_point, a = 0;

            //check how many slices of the image can potencialy have the license plate
            //if j = 1 it means is in a potencial slice
            //the slices ends when it is found a line without whites

            for (int i = 0; i < (hist_slicesX[0].Length - 1); i++)
            {
                if (hist_slicesX[0][i] > average_value && i == 0)
                {
                    a = 1;
                }

                if (a == 0)
                {
                    if ((hist_slicesX[0][i] > average_value) && (hist_slicesX[0][i - 1] <= average_value))
                    {
                        begin = i;
                        a = 1;
                        sumw = 1;
                        first_max = 0;
                        second_max = 0;
                        first_max_point = i;
                    }
                }
                else
                {
                    if (hist_slicesX[0][i] > average_value)
                    {
                        sumw++;

                        if ((hist_slicesX[0][i] > first_max) && (i - first_max_point <= 15))
                        {
                            first_max = hist_slicesX[0][i];
                            first_max_point = i;
                        }
                        else if ((hist_slicesX[0][i] > second_max))
                        {
                            second_max = hist_slicesX[0][i];
                            second_max_point = i;
                        }

                        if (hist_slicesX[0][i + 1] <= average_value || i == (hist_slicesX[0].Length - 1))
                        {
                            end = i;
                            a = 0;

                            if ((sumw > 120) && (Math.Abs(first_max - second_max) < 30) && (end - begin > hist_slicesX[1].Length))
                            {
                                xSlices[k] = new Rectangle(begin, Y, end - begin, hist_slicesX[1].Length);

                                k++;
                            }
                        }
                    }
                }
            }

            return xSlices;
        }


        public static Rectangle LicensePlateRecognition(Image<Bgr, Byte> img, Image<Bgr, byte> imgCopy)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right
                //-------------------DESTINO-----------------------
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int widthstep = m.widthStep; // size of a line
                int padding = m.widthStep - m.nChannels * m.width;

                //-------------------ORIGEM------------------------
                MIplImage mo = imgCopy.MIplImage;
                byte* dataPtrO = (byte*)mo.imageData.ToPointer(); // Pointer to the image
                int nChanO = mo.nChannels; // number of channels - 3
                int widthstepO = mo.widthStep; // size of a line

                //---------------OUTRAS VARIAVEIS------------------
                Image<Bgr, Byte> img_transformed;
                Image<Bgr, Byte> img_sobel;
                Image<Bgr, Byte> img_LP_BW;
                Rectangle[] xSlices = new Rectangle[width];
                Rectangle ySlice;
                Rectangle license_plate;
                byte* dataPtr_initial = dataPtr;
                int[][] hist_slicesY;
                int[][] hist_slicesX;
                int[,] hist_BGR = new int[3, 256];
                int[] hist_Blue;
                int sumx = 0, sumw = 0, max = 0, max_value = 0, min_value = 0, average_value = 0, whites_line, first_line = 0, second_line = 0, first_column = 0, second_column = 0, height_LP = 0, width_LP, height_LP_percentage;

                //**************CHECK HORIZONTALLY***************************
                 
                ConvertToGray(img);
                Median(img, img.Copy());
                Mean(img, img.Copy());
                Mean(img, img.Copy());
                Roberts(img, img.Copy());
                Sobel_vertical(img, img.Copy());

                img_sobel = img.Copy();
                //ConvertToBW_Otsu(img);
                Median(img, img.Copy());
                Median(img, img.Copy());
                Dilatation(img, img.Copy());
                Erosion(img, img.Copy());
                Erosion(img, img.Copy());

                hist_slicesY = WhiteGraph(img);
                for (int i = 0; i < height; i++)
                {
                    sumw += hist_slicesY[1][i];
                }
                if (sumw < ((height * width) * 10) / 100)
                {
                    Rotation(img, img_sobel, 0); //So img goes back the 2 erosion and the dilatation

                    ConvertToBW_Otsu(img);
                    Median(img, img.Copy());
                    Median(img, img.Copy());
                    Dilatation(img, img.Copy());
                    Erosion(img, img.Copy());
                    Erosion(img, img.Copy());
                }
                //save the modified image
                img_transformed = img.Copy();

                hist_slicesY = WhiteGraph(img);

                do { 
                  
                    max_value = 0;
                    for (int j = 0; j < height; j++) //"ver" quantidade de brancos por linha 
                    {
                        if (hist_slicesY[1][j] > max_value && (j <= first_line || j >= second_line))  //percorrer hist, descobrir maior valor
                        {
                            max_value = hist_slicesY[1][j];
                            average_value = j;
                        }
                    }

                    Dilatation(img, img.Copy());
                    hist_slicesY = WhiteGraph(img);
                    whites_line = hist_slicesY[1][average_value]; //max value

                    //Rotation(img, imgCopy, 0); 

                    //CvInvoke.cvLine(img, new Point(0, average_value), new Point(width, average_value), new MCvScalar(0, 0, 255), 1, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, 0);
                    //CvInvoke.cvShowImage("max line", img);

                    for (int j = average_value; j > 0; j--)
                    {
                        if (hist_slicesY[1][j] < whites_line / 4)
                        {
                            first_line = j + 2;
                            break;
                        }
                    }
                    for (int j = average_value; j < height; j++)
                    {
                        if (hist_slicesY[1][j] < whites_line / 4)
                        {
                            second_line = j + 2;
                            break;
                        }
                    }

                    height_LP = second_line - first_line;
                    height_LP_percentage = height_LP * 100 / height;
                } while (height_LP_percentage <= 3);

                ySlice = new Rectangle(0, first_line, width, height_LP);
                //Rotation(img, imgCopy, 0); //So img goes back to original image
                //img.Draw(ySlice, new Bgr(0,0,255), 1);
                //CvInvoke.cvShowImage("FINAL OF HORIZONTAL SLICES", img);

                //**************CHECK VERTICALLY***************************

                //Rotation(img, imgCopy, 0); //So img goes back to original image
                hist_slicesX = WhiteGraph(img_transformed.Copy(ySlice)); //valores de brancos da imagem com corte feito na horizontal

                width_LP = (int)(height_LP * 4.65);

                for (int i = 0, j = 0, a = 0; i < hist_slicesX[0].Length - 1; i++)
                {
                    if (a == 0)
                    {
                        if (hist_slicesX[0][i] > 0)
                        {
                            first_column = i;
                            a = 1;
                            j = 1;
                        }
                    }
                    else
                    {
                        if (hist_slicesX[0][i] == 0)
                        {
                            sumx++;
                            j++;
                            if (sumx == height_LP)
                            {
                                a = 0;
                            }
                        }
                        else
                        {
                            second_column = i;
                            sumx = 0;
                            j++;
                        }
                    }
                    if (sumx == height_LP && j >= width_LP)
                    {
                        break;
                    }
                }
                
                width_LP = second_column - first_column;

                Rotation(img, imgCopy, 0); //So img goes back to original image
                license_plate = new Rectangle(first_column, first_line, width_LP, height_LP);
                //img.Draw(license_plate, new Bgr(0, 0, 255), 1);
                //CvInvoke.cvShowImage("license plate", img);

                Rotation(img, imgCopy, 0); //So img goes back to original image
                hist_Blue = Histogram_Blue(img.Copy(license_plate));
                width_LP = (height_LP * 5);
                max_value = 0;
                for (int i = 0; i < (hist_Blue.Length - 1); i++)
                {
                    if (hist_Blue[i] > max_value)
                    {
                        max_value = hist_Blue[i];
                    }
                }
                min_value = (max_value * 30) / 100;
                if (height_LP  < (height * 70) / 100 )
                {
                    for (int i = 0, a = 0, fc = 0; i < hist_Blue.Length; i++)
                    {
                        if (a == 0)
                        {
                            if (i != 0 && hist_Blue[i] <= min_value && hist_Blue[i - 1] > min_value)
                            {
                                fc = i;
                                a = 1;
                            }
                        }
                        else
                        {
                            if (hist_Blue[i] > min_value && hist_Blue[i + 1] > min_value && hist_Blue[i + 2] > min_value)
                            {
                                if (((i-1) - fc) < width_LP)
                                {
                                    a = 0;
                                    i--;
                                }
                                else
                                {
                                    first_column += fc;
                                    break;
                                }
                            }
                        }
                        if (i == (hist_Blue.Length - 1))
                        {
                            first_column += fc;
                        }
                    }
                    width_LP = second_column - first_column;
                    license_plate = new Rectangle(first_column, first_line, width_LP, height_LP);
                    img.Draw(license_plate, new Bgr(0, 0, 255), 1);
                    //CvInvoke.cvShowImage("Better license plate", img);
                }

                Negative(img);
                hist_Blue = Histogram_Blue(img.Copy(license_plate));
                max_value = 0;
                for (int i = 0; i < (hist_Blue.Length - 1); i++)
                {
                    if (hist_Blue[i] > max_value)
                    {
                        max_value = hist_Blue[i];
                    }
                }
                if (max_value < (height_LP * 90) / 100)
                {
                    min_value = (max_value * 30) / 100;
                    if (height_LP < (height * 70) / 100)
                    {
                        for (int i = 0; i < hist_Blue.Length - 1; i++)
                        {
                            if (hist_Blue[i] <= min_value && hist_Blue[i + 1] > min_value)
                            {
                                second_column = i;
                                break;
                            }
                        }
                        width_LP = second_column;
                        license_plate = new Rectangle(first_column, first_line, width_LP, height_LP);

                        Rotation(img, imgCopy, 0); //So img goes back to original image
                        img.Draw(license_plate, new Bgr(0, 0, 255), 1);
                        //CvInvoke.cvShowImage("Better Better license plate", img);
                    }
                }
                Rotation(img, imgCopy, 0); //So img goes back to original image
                license_plate = new Rectangle(first_column, first_line, width_LP, height_LP);
                img.Draw(license_plate, new Bgr(0, 0, 255), 1);
                return license_plate;
            }
        }

        public static void LP_Recognition(Image<Bgr, byte> img, // imagem a alterar
                                            Image<Bgr, byte> imgCopy, // cópia da imagem
                                            int difficultyLevel, //nível de dificuldade
                                            string LPType, //tipo de matricula (A ou B)
                                            out Rectangle LP_Location, // rectangulo(x,y,largura, altura) contendo a matricula
                                            out Rectangle LP_Chr1, // rectangulo contendo o primeiro carater
                                            out Rectangle LP_Chr2, // rectangulo contendo o segundo carater
                                            out Rectangle LP_Chr3, // rectangulo contendo o terceiro carater
                                            out Rectangle LP_Chr4, // rectangulo contendo o quarto carater
                                            out Rectangle LP_Chr5, // rectangulo contendo o quinto carater
                                            out Rectangle LP_Chr6, // rectangulo contendo o sexto carater
                                            out string LP_C1, // valor do primeiro carater
                                            out string LP_C2, // valor do segundo carater
                                            out string LP_C3, // valor do terceiro carater
                                            out string LP_C4, // valor do quarto carater
                                            out string LP_C5, // valor do quinto carater
                                            out string LP_C6 // valor do sexto carater
                                         )
        {
            LP_Location = LicensePlateRecognition(img, imgCopy); //

            Image<Bgr, byte> LicensePlate = imgCopy.Copy(LP_Location);
            

            Rectangle[] charPositionsRect = CharacterSeparate(LicensePlate);     //Obtem os caracteres da matricula separados
            LP_Chr1 = charPositionsRect[0];
            LP_Chr2 = charPositionsRect[1];
            LP_Chr3 = charPositionsRect[2];
            LP_Chr4 = charPositionsRect[3];
            LP_Chr5 = charPositionsRect[4];
            LP_Chr6 = charPositionsRect[5];

            Image<Bgr, byte>[] imgCharacters = new Image<Bgr, byte>[6];
            string[] listCharacters = new string[6];

            for (int i = 0; i < charPositionsRect.Length; i++)
            {
                LicensePlate.ROI = charPositionsRect[i];
                imgCharacters[i] = LicensePlate.Copy();
            }
            for (int i = 0; i < imgCharacters.Length; i++)
            {
                listCharacters[i] = CharacterRecognize(imgCharacters[i], imgCharacters[i].Copy());      //Identifica o caracter
            }
            LP_C1 = listCharacters[0];
            LP_C2 = listCharacters[1];
            LP_C3 = listCharacters[2];
            LP_C4 = listCharacters[3];
            LP_C5 = listCharacters[4];
            LP_C6 = listCharacters[5];
        }

    }
}