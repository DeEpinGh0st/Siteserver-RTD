namespace SiteServer_Getshell
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Encode_TextBox = new System.Windows.Forms.TextBox();
            this.Encode_Btn = new System.Windows.Forms.Button();
            this.Decode_Btn = new System.Windows.Forms.Button();
            this.Decode_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Target_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RemotePackage_TextBox = new System.Windows.Forms.TextBox();
            this.Exp_Btn = new System.Windows.Forms.Button();
            this.Detect_Btn = new System.Windows.Forms.Button();
            this.PayloadStatus_PicBox = new System.Windows.Forms.PictureBox();
            this.Log_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Help_PicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PayloadStatus_PicBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Help_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Encode_TextBox
            // 
            this.Encode_TextBox.Location = new System.Drawing.Point(13, 29);
            this.Encode_TextBox.Multiline = true;
            this.Encode_TextBox.Name = "Encode_TextBox";
            this.Encode_TextBox.Size = new System.Drawing.Size(361, 55);
            this.Encode_TextBox.TabIndex = 0;
            // 
            // Encode_Btn
            // 
            this.Encode_Btn.Location = new System.Drawing.Point(384, 44);
            this.Encode_Btn.Name = "Encode_Btn";
            this.Encode_Btn.Size = new System.Drawing.Size(75, 27);
            this.Encode_Btn.TabIndex = 1;
            this.Encode_Btn.Text = "Encode";
            this.Encode_Btn.UseVisualStyleBackColor = true;
            this.Encode_Btn.Click += new System.EventHandler(this.Encode_Btn_Click);
            // 
            // Decode_Btn
            // 
            this.Decode_Btn.Location = new System.Drawing.Point(384, 115);
            this.Decode_Btn.Name = "Decode_Btn";
            this.Decode_Btn.Size = new System.Drawing.Size(75, 27);
            this.Decode_Btn.TabIndex = 2;
            this.Decode_Btn.Text = "Decode";
            this.Decode_Btn.UseVisualStyleBackColor = true;
            this.Decode_Btn.Click += new System.EventHandler(this.Decode_Btn_Click);
            // 
            // Decode_TextBox
            // 
            this.Decode_TextBox.Location = new System.Drawing.Point(13, 101);
            this.Decode_TextBox.Multiline = true;
            this.Decode_TextBox.Name = "Decode_TextBox";
            this.Decode_TextBox.Size = new System.Drawing.Size(361, 55);
            this.Decode_TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "    Target   :";
            // 
            // Target_TextBox
            // 
            this.Target_TextBox.Location = new System.Drawing.Point(105, 25);
            this.Target_TextBox.Name = "Target_TextBox";
            this.Target_TextBox.Size = new System.Drawing.Size(290, 21);
            this.Target_TextBox.TabIndex = 5;
            this.Target_TextBox.Text = "http://www.example.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "RemotePackage:";
            // 
            // RemotePackage_TextBox
            // 
            this.RemotePackage_TextBox.Location = new System.Drawing.Point(105, 52);
            this.RemotePackage_TextBox.Name = "RemotePackage_TextBox";
            this.RemotePackage_TextBox.Size = new System.Drawing.Size(259, 21);
            this.RemotePackage_TextBox.TabIndex = 7;
            this.RemotePackage_TextBox.Text = "http://www.example.com/xxx.zip";
            // 
            // Exp_Btn
            // 
            this.Exp_Btn.Location = new System.Drawing.Point(412, 22);
            this.Exp_Btn.Name = "Exp_Btn";
            this.Exp_Btn.Size = new System.Drawing.Size(75, 23);
            this.Exp_Btn.TabIndex = 8;
            this.Exp_Btn.Text = "Exploit";
            this.Exp_Btn.UseVisualStyleBackColor = true;
            this.Exp_Btn.Click += new System.EventHandler(this.Exp_Btn_Click);
            // 
            // Detect_Btn
            // 
            this.Detect_Btn.Location = new System.Drawing.Point(412, 51);
            this.Detect_Btn.Name = "Detect_Btn";
            this.Detect_Btn.Size = new System.Drawing.Size(75, 23);
            this.Detect_Btn.TabIndex = 9;
            this.Detect_Btn.Text = "Detect";
            this.Detect_Btn.UseVisualStyleBackColor = true;
            this.Detect_Btn.Click += new System.EventHandler(this.Detect_Btn_Click);
            // 
            // PayloadStatus_PicBox
            // 
            this.PayloadStatus_PicBox.Location = new System.Drawing.Point(370, 51);
            this.PayloadStatus_PicBox.Name = "PayloadStatus_PicBox";
            this.PayloadStatus_PicBox.Size = new System.Drawing.Size(25, 22);
            this.PayloadStatus_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PayloadStatus_PicBox.TabIndex = 10;
            this.PayloadStatus_PicBox.TabStop = false;
            // 
            // Log_TextBox
            // 
            this.Log_TextBox.Location = new System.Drawing.Point(15, 88);
            this.Log_TextBox.Multiline = true;
            this.Log_TextBox.Name = "Log_TextBox";
            this.Log_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log_TextBox.Size = new System.Drawing.Size(472, 152);
            this.Log_TextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Encode_TextBox);
            this.groupBox1.Controls.Add(this.Decode_TextBox);
            this.groupBox1.Controls.Add(this.Encode_Btn);
            this.groupBox1.Controls.Add(this.Decode_Btn);
            this.groupBox1.Location = new System.Drawing.Point(15, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 184);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payload En/Decoder";
            // 
            // Help_PicBox
            // 
            this.Help_PicBox.Location = new System.Drawing.Point(233, 244);
            this.Help_PicBox.Name = "Help_PicBox";
            this.Help_PicBox.Size = new System.Drawing.Size(33, 30);
            this.Help_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Help_PicBox.TabIndex = 13;
            this.Help_PicBox.TabStop = false;
            this.Help_PicBox.Click += new System.EventHandler(this.Help_PicBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 471);
            this.Controls.Add(this.Help_PicBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Log_TextBox);
            this.Controls.Add(this.PayloadStatus_PicBox);
            this.Controls.Add(this.Detect_Btn);
            this.Controls.Add(this.Exp_Btn);
            this.Controls.Add(this.RemotePackage_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Target_TextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 510);
            this.MinimumSize = new System.Drawing.Size(520, 510);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiteServer4.x-5.x RTD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PayloadStatus_PicBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Help_PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Encode_TextBox;
        private System.Windows.Forms.Button Encode_Btn;
        private System.Windows.Forms.Button Decode_Btn;
        private System.Windows.Forms.TextBox Decode_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Target_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RemotePackage_TextBox;
        private System.Windows.Forms.Button Exp_Btn;
        private System.Windows.Forms.Button Detect_Btn;
        private System.Windows.Forms.PictureBox PayloadStatus_PicBox;
        private System.Windows.Forms.TextBox Log_TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Help_PicBox;
    }
}

