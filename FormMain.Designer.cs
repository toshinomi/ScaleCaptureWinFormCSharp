namespace ScaleCaptureWinFormCSharp
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMinimizedIcon = new System.Windows.Forms.Button();
            this.btnCloseIcon = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.sliderScale = new System.Windows.Forms.TrackBar();
            this.labelValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderScale)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimizedIcon
            // 
            this.btnMinimizedIcon.BackColor = System.Drawing.Color.Black;
            this.btnMinimizedIcon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimizedIcon.ForeColor = System.Drawing.Color.White;
            this.btnMinimizedIcon.Location = new System.Drawing.Point(337, 0);
            this.btnMinimizedIcon.Name = "btnMinimizedIcon";
            this.btnMinimizedIcon.Size = new System.Drawing.Size(35, 25);
            this.btnMinimizedIcon.TabIndex = 16;
            this.btnMinimizedIcon.Text = "-";
            this.btnMinimizedIcon.UseVisualStyleBackColor = false;
            this.btnMinimizedIcon.Click += new System.EventHandler(this.OnClickBtnMinimizedIcon);
            // 
            // btnCloseIcon
            // 
            this.btnCloseIcon.BackColor = System.Drawing.Color.Black;
            this.btnCloseIcon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseIcon.ForeColor = System.Drawing.Color.White;
            this.btnCloseIcon.Location = new System.Drawing.Point(382, 0);
            this.btnCloseIcon.Name = "btnCloseIcon";
            this.btnCloseIcon.Size = new System.Drawing.Size(35, 25);
            this.btnCloseIcon.TabIndex = 15;
            this.btnCloseIcon.Text = "×";
            this.btnCloseIcon.UseVisualStyleBackColor = false;
            this.btnCloseIcon.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(10, 81);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(1, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(418, 28);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Screen Capture";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(10, 30);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(283, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Value = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(301, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "1";
            // 
            // sliderScale
            // 
            this.sliderScale.LargeChange = 1;
            this.sliderScale.Location = new System.Drawing.Point(10, 30);
            this.sliderScale.Maximum = 20;
            this.sliderScale.Minimum = 1;
            this.sliderScale.Name = "sliderScale";
            this.sliderScale.Size = new System.Drawing.Size(283, 45);
            this.sliderScale.TabIndex = 17;
            this.sliderScale.Value = 10;
            this.sliderScale.Scroll += new System.EventHandler(this.OnScrollSliderScale);
            // 
            // labelValue
            // 
            this.labelValue.Location = new System.Drawing.Point(304, 38);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(73, 29);
            this.labelValue.TabIndex = 18;
            this.labelValue.Text = "1";
            // 
            // FormMaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(420, 488);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.sliderScale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnMinimizedIcon);
            this.Controls.Add(this.btnCloseIcon);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormMaint";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimizedIcon;
        private System.Windows.Forms.Button btnCloseIcon;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar sliderScale;
        private System.Windows.Forms.Label labelValue;
    }
}

