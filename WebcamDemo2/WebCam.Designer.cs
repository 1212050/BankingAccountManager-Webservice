﻿namespace WebcamDemo
{
    partial class WebCam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCaptureImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemoveAllImages = new System.Windows.Forms.Button();
            this.chkContainer = new System.Windows.Forms.CheckBox();
            this.dynamicDotNetTwain1 = new Dynamsoft.DotNet.TWAIN.DynamicDotNetTwain();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSources = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbContainer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCaptureImage
            // 
            this.btnCaptureImage.Location = new System.Drawing.Point(15, 104);
            this.btnCaptureImage.Name = "btnCaptureImage";
            this.btnCaptureImage.Size = new System.Drawing.Size(130, 23);
            this.btnCaptureImage.TabIndex = 1;
            this.btnCaptureImage.Text = "Chụp ảnh";
            this.btnCaptureImage.UseVisualStyleBackColor = true;
            this.btnCaptureImage.Click += new System.EventHandler(this.btnCaptureImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 295);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemoveAllImages
            // 
            this.btnRemoveAllImages.Location = new System.Drawing.Point(15, 145);
            this.btnRemoveAllImages.Name = "btnRemoveAllImages";
            this.btnRemoveAllImages.Size = new System.Drawing.Size(130, 23);
            this.btnRemoveAllImages.TabIndex = 4;
            this.btnRemoveAllImages.Text = "Xóa ảnh";
            this.btnRemoveAllImages.UseVisualStyleBackColor = true;
            this.btnRemoveAllImages.Click += new System.EventHandler(this.btnRemoveAllImages_Click);
            // 
            // chkContainer
            // 
            this.chkContainer.AutoSize = true;
            this.chkContainer.Location = new System.Drawing.Point(18, 62);
            this.chkContainer.Name = "chkContainer";
            this.chkContainer.Size = new System.Drawing.Size(120, 17);
            this.chkContainer.TabIndex = 10;
            this.chkContainer.Text = "Set Video Container";
            this.chkContainer.UseVisualStyleBackColor = true;
            this.chkContainer.CheckedChanged += new System.EventHandler(this.chkContainer_CheckedChanged_1);
            // 
            // dynamicDotNetTwain1
            // 
            this.dynamicDotNetTwain1.AnnotationFillColor = System.Drawing.Color.White;
            this.dynamicDotNetTwain1.AnnotationPen = null;
            this.dynamicDotNetTwain1.AnnotationTextColor = System.Drawing.Color.Black;
            this.dynamicDotNetTwain1.AnnotationTextFont = null;
            this.dynamicDotNetTwain1.BorderStyle = Dynamsoft.DotNet.TWAIN.Enums.DWTWndBorderStyle.Single3D;
            this.dynamicDotNetTwain1.IfShowCancelDialogWhenImageTransfer = false;
            this.dynamicDotNetTwain1.IfShowPrintUI = false;
            this.dynamicDotNetTwain1.IfThrowException = false;
            this.dynamicDotNetTwain1.Location = new System.Drawing.Point(160, 35);
            this.dynamicDotNetTwain1.LogLevel = ((short)(1));
            this.dynamicDotNetTwain1.Name = "dynamicDotNetTwain1";
            this.dynamicDotNetTwain1.PDFMarginBottom = ((uint)(0u));
            this.dynamicDotNetTwain1.PDFMarginLeft = ((uint)(0u));
            this.dynamicDotNetTwain1.PDFMarginRight = ((uint)(0u));
            this.dynamicDotNetTwain1.PDFMarginTop = ((uint)(0u));
            this.dynamicDotNetTwain1.PDFXConformance = ((uint)(0u));
            this.dynamicDotNetTwain1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dynamicDotNetTwain1.Size = new System.Drawing.Size(280, 300);
            this.dynamicDotNetTwain1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Webcam Source:";
            // 
            // cbxSources
            // 
            this.cbxSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSources.FormattingEnabled = true;
            this.cbxSources.Location = new System.Drawing.Point(15, 35);
            this.cbxSources.Name = "cbxSources";
            this.cbxSources.Size = new System.Drawing.Size(131, 21);
            this.cbxSources.TabIndex = 13;
            this.cbxSources.SelectedIndexChanged += new System.EventHandler(this.cbxSources_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(160, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ảnh chụp";
            // 
            // lbContainer
            // 
            this.lbContainer.AutoSize = true;
            this.lbContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbContainer.Location = new System.Drawing.Point(455, 16);
            this.lbContainer.Name = "lbContainer";
            this.lbContainer.Size = new System.Drawing.Size(56, 13);
            this.lbContainer.TabIndex = 15;
            this.lbContainer.Text = "Webcam";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(15, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 1);
            this.label4.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(455, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 300);
            this.panel1.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Lưu ảnh";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // WebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(749, 347);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSources);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkContainer);
            this.Controls.Add(this.btnRemoveAllImages);
            this.Controls.Add(this.btnCaptureImage);
            this.Controls.Add(this.dynamicDotNetTwain1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WebCam";
            this.Text = "Chụp ảnh đại diện";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dynamsoft.DotNet.TWAIN.DynamicDotNetTwain dynamicDotNetTwain1;
        private System.Windows.Forms.Button btnCaptureImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRemoveAllImages;
        private System.Windows.Forms.CheckBox chkContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSources;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
    }
}

