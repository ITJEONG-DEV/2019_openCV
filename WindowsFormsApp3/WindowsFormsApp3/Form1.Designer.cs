namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.input_target = new System.Windows.Forms.TextBox();
            this.label_target = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_output = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_segmentation = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.input_output2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input_target2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.input_num_color = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_converting = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rgb = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.claer_log = new System.Windows.Forms.Button();
            this.samplePicture = new System.Windows.Forms.PictureBox();
            this.log = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.input_output3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickTargetFindButton);
            // 
            // input_target
            // 
            this.input_target.Location = new System.Drawing.Point(87, 33);
            this.input_target.Name = "input_target";
            this.input_target.Size = new System.Drawing.Size(214, 26);
            this.input_target.TabIndex = 1;
            // 
            // label_target
            // 
            this.label_target.AutoSize = true;
            this.label_target.Location = new System.Drawing.Point(27, 33);
            this.label_target.Name = "label_target";
            this.label_target.Size = new System.Drawing.Size(54, 16);
            this.label_target.TabIndex = 4;
            this.label_target.Text = "Target";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // input_output
            // 
            this.input_output.Location = new System.Drawing.Point(87, 73);
            this.input_output.Name = "input_output";
            this.input_output.Size = new System.Drawing.Size(214, 26);
            this.input_output.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClickOutputFindButton);
            // 
            // button_segmentation
            // 
            this.button_segmentation.Location = new System.Drawing.Point(293, 121);
            this.button_segmentation.Name = "button_segmentation";
            this.button_segmentation.Size = new System.Drawing.Size(154, 32);
            this.button_segmentation.TabIndex = 8;
            this.button_segmentation.Text = "segmentation";
            this.button_segmentation.UseVisualStyleBackColor = true;
            this.button_segmentation.Click += new System.EventHandler(this.ClickSegmentationButton);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClickOutput2FindButton);
            // 
            // input_output2
            // 
            this.input_output2.Location = new System.Drawing.Point(88, 67);
            this.input_output2.Name = "input_output2";
            this.input_output2.Size = new System.Drawing.Size(214, 26);
            this.input_output2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Output";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Target";
            // 
            // input_target2
            // 
            this.input_target2.Location = new System.Drawing.Point(88, 32);
            this.input_target2.Name = "input_target2";
            this.input_target2.Size = new System.Drawing.Size(214, 26);
            this.input_target2.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(308, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Find";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClickTarget2FindButton);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "number of colors";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // input_num_color
            // 
            this.input_num_color.Location = new System.Drawing.Point(165, 155);
            this.input_num_color.Name = "input_num_color";
            this.input_num_color.Size = new System.Drawing.Size(218, 26);
            this.input_num_color.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "<from>";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "<to>";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "<R=G=B>";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F);
            this.label8.Location = new System.Drawing.Point(21, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "* example of input type ( from, to )";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F);
            this.label9.Location = new System.Drawing.Point(38, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "255 0 0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F);
            this.label10.Location = new System.Drawing.Point(38, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "0 255 0";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F);
            this.label11.Location = new System.Drawing.Point(38, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "0 0 255";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_converting
            // 
            this.button_converting.Location = new System.Drawing.Point(366, 388);
            this.button_converting.Name = "button_converting";
            this.button_converting.Size = new System.Drawing.Size(113, 35);
            this.button_converting.TabIndex = 28;
            this.button_converting.Text = "converting";
            this.button_converting.UseVisualStyleBackColor = true;
            this.button_converting.Click += new System.EventHandler(this.ClickConvertButton);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9F);
            this.label13.Location = new System.Drawing.Point(229, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "/ (rgb)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 9F);
            this.label14.Location = new System.Drawing.Point(232, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 24;
            this.label14.Text = "0";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 9F);
            this.label15.Location = new System.Drawing.Point(232, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 25;
            this.label15.Text = "50";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 9F);
            this.label16.Location = new System.Drawing.Point(232, 406);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 26;
            this.label16.Text = "100";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_target);
            this.groupBox1.Controls.Add(this.label_target);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.input_output);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button_segmentation);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 176);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Image Segmentation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.input_output3);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.rgb);
            this.groupBox2.Controls.Add(this.to);
            this.groupBox2.Controls.Add(this.from);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.input_target2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.input_output2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.button_converting);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.input_num_color);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F);
            this.groupBox2.Location = new System.Drawing.Point(15, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 433);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Image Converting";
            // 
            // rgb
            // 
            this.rgb.Location = new System.Drawing.Point(316, 242);
            this.rgb.MinimumSize = new System.Drawing.Size(115, 115);
            this.rgb.Name = "rgb";
            this.rgb.Size = new System.Drawing.Size(115, 115);
            this.rgb.TabIndex = 32;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(174, 242);
            this.to.MinimumSize = new System.Drawing.Size(115, 115);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(115, 115);
            this.to.TabIndex = 31;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(39, 242);
            this.from.MinimumSize = new System.Drawing.Size(115, 115);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(115, 115);
            this.from.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.claer_log);
            this.groupBox3.Controls.Add(this.samplePicture);
            this.groupBox3.Controls.Add(this.log);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 12F);
            this.groupBox3.Location = new System.Drawing.Point(531, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 623);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // claer_log
            // 
            this.claer_log.Location = new System.Drawing.Point(277, 284);
            this.claer_log.Name = "claer_log";
            this.claer_log.Size = new System.Drawing.Size(137, 23);
            this.claer_log.TabIndex = 9;
            this.claer_log.Text = "clear";
            this.claer_log.UseVisualStyleBackColor = true;
            this.claer_log.Click += new System.EventHandler(this.ClickClearLogButton);
            // 
            // samplePicture
            // 
            this.samplePicture.Location = new System.Drawing.Point(16, 313);
            this.samplePicture.Name = "samplePicture";
            this.samplePicture.Size = new System.Drawing.Size(398, 295);
            this.samplePicture.TabIndex = 1;
            this.samplePicture.TabStop = false;
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("굴림", 9F);
            this.log.FormattingEnabled = true;
            this.log.ItemHeight = 12;
            this.log.Location = new System.Drawing.Point(16, 33);
            this.log.Name = "log";
            this.log.ScrollAlwaysVisible = true;
            this.log.Size = new System.Drawing.Size(398, 244);
            this.log.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Output2";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // input_output3
            // 
            this.input_output3.Location = new System.Drawing.Point(87, 99);
            this.input_output3.Name = "input_output3";
            this.input_output3.Size = new System.Drawing.Size(214, 26);
            this.input_output3.TabIndex = 34;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 35;
            this.button5.Text = "Find";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ClickOutput3FindButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 651);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.samplePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox input_target;
        private System.Windows.Forms.Label label_target;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_output;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_segmentation;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox input_output2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_target2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_num_color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_converting;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox rgb;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.PictureBox samplePicture;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.Button claer_log;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox input_output3;
        private System.Windows.Forms.Button button5;
    }
}

