using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog_target;
        CommonOpenFileDialog commonOpenFileDialog_output;
        Paths targetPath;
        String outputPath;
        String outputPath_2;

        public Form1()
        {
            InitializeComponent();

            openFileDialog_target = new OpenFileDialog();
            openFileDialog_target.RestoreDirectory = true;
            openFileDialog_target.CheckPathExists = true;
            openFileDialog_target.InitialDirectory = "C:\\";

            commonOpenFileDialog_output = new CommonOpenFileDialog();
            commonOpenFileDialog_output.RestoreDirectory = true;
            commonOpenFileDialog_output.InitialDirectory = "C:\\";

            from.Multiline = true;
            to.Multiline = true;
            rgb.Multiline = true;

            log.ResetText();
        }

        private void AllButtonEnabled(bool state)
        {
            button1.Enabled = state;
            button2.Enabled = state;
            button3.Enabled = state;
            button4.Enabled = state;
            button_segmentation.Enabled = state;
            button_converting.Enabled = state;

            input_target.Enabled = state;
            input_output.Enabled = state;
            input_target2.Enabled = state;
            input_output2.Enabled = state;
            input_num_color.Enabled = state;
            from.Enabled = state;
            to.Enabled = state;
            rgb.Enabled = state;
        }

        private void PrintLog(String message)
        {
            int LENGTH = 50;
            String str = "";
            for(int i=0; i<message.Length; i++)
            {
                if (i!=0&&i % LENGTH == 0)
                {
                    log.Items.Add(str);
                    str = "";
                }
                str = str + message.Substring(i, 1);
            }
            log.Items.Add(str);
        }

        private void ClickTargetFindButton(object sender, EventArgs e)
        {
            PrintLog("Click Target Find Button\n");
            input_target.Clear();

            openFileDialog_target.Multiselect = true;
            openFileDialog_target.Filter = "Image Files(*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

            DialogResult dialogResult = openFileDialog_target.ShowDialog();

            if(dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                String[] fileNames = openFileDialog_target.FileNames;
                int count = fileNames.Length;

                targetPath = new Paths(fileNames.Length);

                for(int i=0; i<count; i++)
                {
                    targetPath[i] = fileNames[i];
                    input_target.Text += targetPath[i];
                }
            }

        }

        private void ClickTarget2FindButton(object sender, EventArgs e)
        {
            PrintLog("Click Target2 Find Button\n");
            input_target.Clear();

            openFileDialog_target.Multiselect = true;
            openFileDialog_target.Filter = "Image Files(*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

            DialogResult dialogResult = openFileDialog_target.ShowDialog();

            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                String[] fileNames = openFileDialog_target.FileNames;
                int count = fileNames.Length;

                targetPath = new Paths(fileNames.Length);

                for (int i = 0; i < count; i++)
                {
                    targetPath[i] = fileNames[i];
                    input_target2.Text += targetPath[i];
                }
            }

        }

        private void ClickOutputFindButton(object sender, EventArgs e)
        {
            PrintLog("Click Output Find Button\n");
            input_output.Clear();

            commonOpenFileDialog_output.Multiselect = false;
            commonOpenFileDialog_output.IsFolderPicker = true;

            if (commonOpenFileDialog_output.ShowDialog() == CommonFileDialogResult.Ok)
            {
                outputPath = commonOpenFileDialog_output.FileName;
                input_output.Text = outputPath;
            }
        }

        private void ClickOutput2FindButton(object sender, EventArgs e)
        {
            PrintLog("Click Output 2-1 Target Button\n");
            input_output.Clear();

            commonOpenFileDialog_output.Multiselect = false;
            commonOpenFileDialog_output.IsFolderPicker = true;

            if(commonOpenFileDialog_output.ShowDialog()==CommonFileDialogResult.Ok)
            {
                outputPath = commonOpenFileDialog_output.FileName;
                input_output2.Text = outputPath;
            }
        }

        private void ClickOutput3FindButton(object sender, EventArgs e)
        {
            PrintLog("Click Output 2-2 Target Button\n");
            input_output.Clear();

            commonOpenFileDialog_output.Multiselect = false;
            commonOpenFileDialog_output.IsFolderPicker = true;

            if (commonOpenFileDialog_output.ShowDialog() == CommonFileDialogResult.Ok)
            {
                outputPath_2 = commonOpenFileDialog_output.FileName;
                input_output3.Text = outputPath;
            }
        }

        private void ClickSegmentationButton(object sender, EventArgs e)
        {
            AllButtonEnabled(false);

            PrintLog("Click Segmenation Button");
            PrintLog("Target Location : " + targetPath[0]);
            PrintLog("and other " + (targetPath.Length-1) + " link");
            PrintLog("Output Location : " + outputPath);
            PrintLog("\n");

            for(int i=0; i<targetPath.Length; i++)
            {
                PrintLog("Segmentation . . ." + (i + 1).ToString("D5"));

                var engine = IronPython.Hosting.Python.CreateEngine();

                var scope = engine.CreateScope();

                try
                {
                    var source = engine.CreateScriptSourceFromFile("segmentation.py");
                    source.Execute(scope);

                    var FnSegmentation = scope.GetVariable<Func<string, string, string>>("segmentation");


                    PrintLog(FnSegmentation(targetPath[i], outputPath));

                }
                catch(Exception ex)
                {
                    PrintLog(ex.Message);
                }
            }

            AllButtonEnabled(true);
        }

        private void ClickConvertButton(object sender, EventArgs e)
        {
            AllButtonEnabled(false);

            PrintLog("Click Segmentation Button");
            PrintLog("Target Location : " + targetPath[0]);
            PrintLog("and other " + (targetPath.Length - 1) + " link");
            PrintLog("Output Location : " + outputPath);
            PrintLog("\n");

            String numColor = input_num_color.Text;
            int num_of_color;
            int[,] from_list;
            int[,] to_list;
            int[,] rgb_list;

            String[] from_text, to_text, rgb_text;
            String[] temp;

            try
            {
                num_of_color = Int32.Parse(numColor);

                from_list = new int[num_of_color,3];
                to_list = new int[num_of_color, 3];
                rgb_list = new int[num_of_color, 3];

                from_text = from.Text.Split('\n');
                to_text = to.Text.Split('\n');
                rgb_text = rgb.Text.Split('\n');

                for(int k=0; k<3; k++)
                    for (int i = 0; i < num_of_color; i++)
                    {
                        switch(k)
                        {
                            case 0: // from
                                temp = from_text[i].Split(' ');

                                for (int j = 0; j < 3; j++)
                                    from_list[i,j] = Int32.Parse(temp[j]);

                                break;
                            case 1: // to
                                temp = to_text[i].Split(' ');

                                for (int j = 0; j < 3; j++)
                                    to_list[i, j] = Int32.Parse(temp[j]);

                                break;
                            case 2: // rgb
                                temp = rgb_text[i].Split(' ');

                                for (int j = 0; j < 3; j++)
                                    rgb_list[i, j] = Int32.Parse(temp[j]);

                                break;
                        }
                    }


                for (int i = 0; i < targetPath.Length; i++)
                {
                    PrintLog("Converting . . ." + (i + 1).ToString("D5"));

                    var engine = IronPython.Hosting.Python.CreateEngine();

                    var scope = engine.CreateScope();

                    try
                    {
                        var source = engine.CreateScriptSourceFromFile("converting.py");
                        source.Execute(scope);
                        PrintLog("execute");

                        var FnConverting = scope.GetVariable<Func<string, string, int, int[,], int[,], string>>("converting");

                        PrintLog(FnConverting(targetPath[i], outputPath, num_of_color, from_list, to_list));
                        PrintLog(FnConverting(targetPath[i], outputPath_2, num_of_color, from_list, rgb_list));
                    }
                    catch (Exception ex)
                    {
                        PrintLog(ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                PrintLog(ex.Message);
            }

            
        }

        private void ClickClearLogButton(object sender, EventArgs e)
        {
            log.Items.Clear();
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
