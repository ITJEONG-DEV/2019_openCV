using System;
using System.Drawing;
using System.Windows.Forms;

using OpenCvSharp;
using Microsoft.WindowsAPICodePack.Dialogs;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    enum MODE { videotoImage, imagetoVideo };

    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog;
        CommonOpenFileDialog commonOpenFileDialog;

        int currentMode = (int)MODE.videotoImage;
        int count = -1;

        Paths targetPath;
        String outputPath;

        File file;

        public Form1()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Users\\이다정\\Desktop\\file";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckPathExists = true;

            commonOpenFileDialog = new CommonOpenFileDialog();
            commonOpenFileDialog.InitialDirectory = "C:\\Users\\이다정\\Desktop\\file";
            commonOpenFileDialog.RestoreDirectory = true;

            currentMode = (int)MODE.videotoImage;
            SetSwitchImageMode();

            file = new File();
        }

        private void SetTargetOpenFileDialog()
        {
            openFileDialog.Multiselect = false;

            openFileDialog.CheckFileExists = true;

            openFileDialog.Title = "select file";

            switch (currentMode)
            {
                case (int)MODE.videotoImage:
                    openFileDialog.Filter = "Video Files(*.mov;*.mp4)|*.mov;*.mp4";
                    openFileDialog.FilterIndex = 2;
                    break;

                case (int)MODE.imagetoVideo:
                    openFileDialog.Multiselect = true;
                    openFileDialog.Filter = "Image Files(*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
                    openFileDialog.FilterIndex = 3;
                    break;
            }
        }

        private void SetSwitchImageMode()
        {
            String[] imageFormatData = { "bmp(*.bmp)", "png(*.png)", "jpg(*.jpg)" };
            String[] videoFormatData = { "avi(*.avi)" };
            //String[] videoFormatData = { "mov(*.mov)", "mp4(*.mp4)" };

            targetInput.Clear();
            outputInput.Clear();
            fileNameInput.Clear();
            formatDropdown.Items.Clear();

            imageperFrameInput.Text = "5";

            switch(currentMode)
            {
                case (int)MODE.videotoImage:
                    formatDropdown.Items.AddRange(imageFormatData);
                    break;

                case (int)MODE.imagetoVideo:
                    formatDropdown.Items.AddRange(videoFormatData);
                    break;
            }

            formatDropdown.SelectedIndex = 0;
        }

        private void VideotoImage_Click(object sender, EventArgs e)
        {
            currentMode = (int)MODE.videotoImage;

            SetSwitchImageMode();
        }

        private void ImagetoVideo_Click(object sender, EventArgs e)
        {
            currentMode = (int)MODE.imagetoVideo;

            SetSwitchImageMode();
        }

        private void TargetButton_Click(object sender, EventArgs e)
        {
            targetInput.Clear();
            SetTargetOpenFileDialog();

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {

                String[] fileNames = openFileDialog.FileNames;
                int count = fileNames.Length;

                targetPath = new Paths(fileNames.Length);

                for (int i = 0; i < count; i++)
                {
                    targetPath[i] = fileNames[i];
                    targetInput.Text += targetPath[i];
                }
            }

        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            outputInput.Clear();

            commonOpenFileDialog.Multiselect = false;

            commonOpenFileDialog.IsFolderPicker = true;

            if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                outputPath = commonOpenFileDialog.FileName;
                outputInput.Text = outputPath;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked)
            {
                widthInput.BackColor = Color.Gray;
                heightInput.BackColor = Color.Gray;
                widthInput.ReadOnly = true;
                heightInput.ReadOnly = true;
            }
            else
            {
                widthInput.BackColor = Color.White;
                heightInput.BackColor = Color.White;
                widthInput.ReadOnly = false;
                heightInput.ReadOnly = false;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            convertButton.Enabled = false;

            notification.Text = "click convert button\n";

            // target
            file.TargetPath = targetPath;
            notification.Text = "target path\n";

            // output
            file.OutputPath = outputPath;
            notification.Text = "output path\n";

            // filename
            String fileName = fileNameInput.Text;

            if (fileNameInput.Equals(null))
                fileName = "image";

            file.FileName = fileName;
            notification.Text = "file name\n";

            // FPS
            float fPS;

            if (imageperFrameInput.Text.Equals(null))
                fPS = 5;
            else
                fPS = float.Parse(imageperFrameInput.Text);

            file.FPS = fPS;
            notification.Text = "fps\n";


            // output format
            String format = formatDropdown.SelectedItem.ToString().Split('(')[0];
            file.OutputFormat = "." + format;
            notification.Text = "output format : " + file.OutputFormat + "\n";

            switch (currentMode)
            {
                case (int)MODE.videotoImage:
                    var capture = new VideoCapture(file.TargetPath[0]);
                    
                    // max frame
                    int maxFrame = (int)Math.Round(capture.Fps / file.FPS);
                    notification.Text = "videoFrame : " + capture.Fps + "\nfileFPS : " + file.FPS + "\nmaxFrame : " + maxFrame;
                    if (maxFrame < 1) maxFrame = 1;

                    // size
                    System.Drawing.Size size = new System.Drawing.Size();

                    if (!checkBox.Checked && !widthInput.Text.Equals(null))
                        size.Width = Int32.Parse(widthInput.Text);
                    else
                        size.Width = capture.FrameWidth;
                    notification.Text = "width\n";

                    if (!checkBox.Checked && !heightInput.Text.Equals(null))
                        size.Height = Int32.Parse(heightInput.Text);
                    else
                        size.Height = capture.FrameHeight;
                    notification.Text = "height\n";

                    file.Size = size;

                    bool flag = false;
                    using (Mat image = new Mat())
                    {
                        while (!flag)
                        {
                            notification.Text = "capture . . . " + count.ToString("D5");

                            for(int i=0; i<maxFrame; i++)
                            {
                                capture.Read(image);

                                Mat resizing = new Mat();
                                OpenCvSharp.Size resize = new OpenCvSharp.Size(file.Size.Width, file.Size.Height);
                                //Cv2.Resize(image, resizing, resize);

                                if (image.Empty())
                                {
                                    flag = true;
                                    break;
                                }
                                else if (i==0)
                                {
                                    //Cv2.ImWrite(@outputPath + "\\" + fileName + (++count).ToString("D5") + file.OutputFormat, resizing);
                                    Cv2.ImWrite(@outputPath + "\\" + (++count).ToString("D5") + file.OutputFormat, image);
                                    //samplePictureBox.Image.Save(outputPath + "\\" + fileName + (++count).ToString("D5") + ".png" , System.Drawing.Imaging.ImageFormat.Png);
                                    //bitmapImage.Save(@outputPath + "\\" + fileName + count.ToString("D5") + ".bmp");
                                }
                            }

                            if (image.Empty())
                                break;
                        }
                    }
                    notification.Text = "success! \n";
                    notification.Text += "videoFrame : " + capture.Fps + "\nfileFPS : " + file.FPS + "\nmaxFrame : " + maxFrame;
                    break;
                case (int)MODE.imagetoVideo:
                    notification.Text = "length : " + file.TargetPath.Length;
                    notification.Text += "\nlink : " + @outputPath + "\\" + fileName + file.OutputFormat;
                    notification.Text += "\nlink : " + file.TargetPath[3];

                    // size
                    System.Drawing.Size size2 = new System.Drawing.Size();
                    OpenCvSharp.Size videoSize = new OpenCvSharp.Size();

                    if (!checkBox.Checked && !widthInput.Text.Equals(null))
                        videoSize.Width = Int32.Parse(widthInput.Text);
                    else
                        videoSize.Width = Cv2.ImRead(file.TargetPath[0]).Width;
                    notification.Text = "width\n";

                    if (!checkBox.Checked && !heightInput.Text.Equals(null))
                        videoSize.Height = Int32.Parse(heightInput.Text);
                    else
                        videoSize.Height = Cv2.ImRead(file.TargetPath[0]).Height;
                    notification.Text = "height\n";

                    size2.Width = videoSize.Width;
                    size2.Height = videoSize.Height;

                    file.Size = size2;

                    notification.Text = "size : " + videoSize.Width + ", " + videoSize.Height;

                    VideoWriter videoWriter = new VideoWriter(@outputPath + "\\" + fileName + ".avi", FourCC.Default, file.FPS, videoSize);
                    {
                        if (!videoWriter.IsOpened())
                        {
                            notification.Text = "could not open the output video file for writer\n";
                            return;
                        }

                        //videoWriter.Open(@"F:\20190709\abc.avi", "DIVX", file.FPS, videoSize);

                        notification.Text = "make video . . . ";

                        for (int i =0; i<file.TargetPath.Length; i++)
                        {
                            Mat mat = Cv2.ImRead(file.TargetPath[i]);
                            if (mat.Empty()) break;

                            Mat resizing = new Mat();
                            Cv2.Resize(mat, resizing, videoSize);

                            videoWriter.Write(resizing);
                            samplePictureBox.Image = MatToBitmap(resizing);
                        }
                        videoWriter.Release();
                    }
                    notification.Text += "\nsuccess! \n";
                    break;
            }

            convertButton.Enabled = true;
        }

        public static Bitmap MatToBitmap(Mat image)
        {
            return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
        }

    }

    class Paths
    {
        int count;
        String[] path;

        public Paths(int _count)
        {
            count = _count;
            path = new String[count];
        }
        public int Length
        {
            get { return count; }
            set { count = value; }
        }
        public String this[int index]
        {
            get { return path[index]; }
            set { path[index] = value; }
        }
    }

    class File
    {
        Paths targetPath;
        String outputPath, fileName, outputFormat;
        float fPS;
        System.Drawing.Size size;

        public File()
        {
        }
        public File(Paths _path)
        {
            targetPath = _path;
        }

        public Paths TargetPath
        {
            get { return targetPath; }
            set { targetPath = value; }
        }

        public String OutputPath
        {
            get { return OutputPath; }
            set { outputPath = value; }
        }

        public String FileName
        {
            get { return FileName; }
            set { fileName = value; }
        }

        public String OutputFormat
        {
            get { return outputFormat; }
            set { outputFormat = value; }
        }

        public float FPS
        {
            get { return fPS; }
            set { fPS = value; }
        }

        public System.Drawing.Size Size
        {
            get { return size; }
            set { size = value; }
        }

    };
}
