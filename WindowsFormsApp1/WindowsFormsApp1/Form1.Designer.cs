namespace WindowsFormsApp1
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
            this.videotoImage = new System.Windows.Forms.Button();
            this.imagetoVideo = new System.Windows.Forms.Button();
            this.targetLabel = new System.Windows.Forms.Label();
            this.selectTarget = new System.Windows.Forms.OpenFileDialog();
            this.targetButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputInput = new System.Windows.Forms.TextBox();
            this.targetInput = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.imageperFrameLabel = new System.Windows.Forms.Label();
            this.imageperFrameInput = new System.Windows.Forms.TextBox();
            this.formatLabel = new System.Windows.Forms.Label();
            this.formatDropdown = new System.Windows.Forms.ComboBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.selectOutput = new System.Windows.Forms.OpenFileDialog();
            this.fileNameInput = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.samplePictureBox = new System.Windows.Forms.PictureBox();
            this.notification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.samplePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // videotoImage
            // 
            this.videotoImage.Location = new System.Drawing.Point(12, 12);
            this.videotoImage.Name = "videotoImage";
            this.videotoImage.Size = new System.Drawing.Size(208, 38);
            this.videotoImage.TabIndex = 1;
            this.videotoImage.Text = "video to image";
            this.videotoImage.UseVisualStyleBackColor = true;
            this.videotoImage.Click += new System.EventHandler(this.VideotoImage_Click);
            // 
            // imagetoVideo
            // 
            this.imagetoVideo.Location = new System.Drawing.Point(235, 12);
            this.imagetoVideo.Name = "imagetoVideo";
            this.imagetoVideo.Size = new System.Drawing.Size(208, 38);
            this.imagetoVideo.TabIndex = 2;
            this.imagetoVideo.Text = "image to video";
            this.imagetoVideo.UseVisualStyleBackColor = true;
            this.imagetoVideo.Click += new System.EventHandler(this.ImagetoVideo_Click);
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(43, 95);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(36, 12);
            this.targetLabel.TabIndex = 3;
            this.targetLabel.Text = "target";
            // 
            // selectTarget
            // 
            this.selectTarget.FileName = "selectDirectory";
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(398, 91);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(75, 21);
            this.targetButton.TabIndex = 5;
            this.targetButton.Text = "open";
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.Click += new System.EventHandler(this.TargetButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(40, 121);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 12);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "output";
            // 
            // outputInput
            // 
            this.outputInput.Location = new System.Drawing.Point(115, 118);
            this.outputInput.Name = "outputInput";
            this.outputInput.Size = new System.Drawing.Size(250, 21);
            this.outputInput.TabIndex = 7;
            // 
            // targetInput
            // 
            this.targetInput.Location = new System.Drawing.Point(115, 91);
            this.targetInput.Name = "targetInput";
            this.targetInput.Size = new System.Drawing.Size(250, 21);
            this.targetInput.TabIndex = 8;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(42, 231);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 12);
            this.widthLabel.TabIndex = 9;
            this.widthLabel.Text = "width";
            // 
            // widthInput
            // 
            this.widthInput.BackColor = System.Drawing.SystemColors.Window;
            this.widthInput.Location = new System.Drawing.Point(115, 226);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(150, 21);
            this.widthInput.TabIndex = 10;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(39, 256);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(39, 12);
            this.heightLabel.TabIndex = 11;
            this.heightLabel.Text = "height";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(115, 253);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(150, 21);
            this.heightInput.TabIndex = 12;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(388, 298);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(112, 24);
            this.convertButton.TabIndex = 13;
            this.convertButton.Text = "convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(398, 118);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 21);
            this.outputButton.TabIndex = 14;
            this.outputButton.Text = "open";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // imageperFrameLabel
            // 
            this.imageperFrameLabel.AutoSize = true;
            this.imageperFrameLabel.Location = new System.Drawing.Point(43, 175);
            this.imageperFrameLabel.Name = "imageperFrameLabel";
            this.imageperFrameLabel.Size = new System.Drawing.Size(28, 12);
            this.imageperFrameLabel.TabIndex = 15;
            this.imageperFrameLabel.Text = "FPS";
            // 
            // imageperFrameInput
            // 
            this.imageperFrameInput.Location = new System.Drawing.Point(115, 172);
            this.imageperFrameInput.Name = "imageperFrameInput";
            this.imageperFrameInput.Size = new System.Drawing.Size(29, 21);
            this.imageperFrameInput.TabIndex = 16;
            this.imageperFrameInput.Text = "5";
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Location = new System.Drawing.Point(21, 202);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(78, 12);
            this.formatLabel.TabIndex = 17;
            this.formatLabel.Text = "output format";
            // 
            // formatDropdown
            // 
            this.formatDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatDropdown.FormattingEnabled = true;
            this.formatDropdown.Location = new System.Drawing.Point(115, 199);
            this.formatDropdown.Name = "formatDropdown";
            this.formatDropdown.Size = new System.Drawing.Size(250, 20);
            this.formatDropdown.TabIndex = 19;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(282, 241);
            this.checkBox.Name = "checkBox";
            this.checkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox.Size = new System.Drawing.Size(124, 16);
            this.checkBox.TabIndex = 20;
            this.checkBox.Text = "using default size";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // selectOutput
            // 
            this.selectOutput.FileName = "selectDirectory";
            // 
            // fileNameInput
            // 
            this.fileNameInput.Location = new System.Drawing.Point(115, 145);
            this.fileNameInput.Name = "fileNameInput";
            this.fileNameInput.Size = new System.Drawing.Size(250, 21);
            this.fileNameInput.TabIndex = 22;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(31, 148);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(57, 12);
            this.fileNameLabel.TabIndex = 21;
            this.fileNameLabel.Text = "file name";
            // 
            // samplePictureBox
            // 
            this.samplePictureBox.Location = new System.Drawing.Point(532, 22);
            this.samplePictureBox.Name = "samplePictureBox";
            this.samplePictureBox.Size = new System.Drawing.Size(405, 300);
            this.samplePictureBox.TabIndex = 23;
            this.samplePictureBox.TabStop = false;
            // 
            // notification
            // 
            this.notification.AutoSize = true;
            this.notification.Location = new System.Drawing.Point(31, 298);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(38, 12);
            this.notification.TabIndex = 24;
            this.notification.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 355);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.samplePictureBox);
            this.Controls.Add(this.fileNameInput);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.formatDropdown);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.imageperFrameInput);
            this.Controls.Add(this.imageperFrameLabel);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.targetInput);
            this.Controls.Add(this.outputInput);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.targetButton);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.imagetoVideo);
            this.Controls.Add(this.videotoImage);
            this.Name = "Form1";
            this.Text = "application1";
            ((System.ComponentModel.ISupportInitialize)(this.samplePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button videotoImage;
        private System.Windows.Forms.Button imagetoVideo;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.OpenFileDialog selectTarget;
        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputInput;
        private System.Windows.Forms.TextBox targetInput;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label imageperFrameLabel;
        private System.Windows.Forms.TextBox imageperFrameInput;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.ComboBox formatDropdown;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.OpenFileDialog selectOutput;
        private System.Windows.Forms.TextBox fileNameInput;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.PictureBox samplePictureBox;
        private System.Windows.Forms.Label notification;
    }
}

