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
            Encode_TextBox = new System.Windows.Forms.TextBox();
            Encode_Btn = new System.Windows.Forms.Button();
            Decode_Btn = new System.Windows.Forms.Button();
            Decode_TextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            Target_TextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            RemotePackage_TextBox = new System.Windows.Forms.TextBox();
            Exp_Btn = new System.Windows.Forms.Button();
            Detect_Btn = new System.Windows.Forms.Button();
            PayloadStatus_PicBox = new System.Windows.Forms.PictureBox();
            Log_TextBox = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            Help_PicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)PayloadStatus_PicBox).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Help_PicBox).BeginInit();
            SuspendLayout();
            // 
            // Encode_TextBox
            // 
            Encode_TextBox.Location = new System.Drawing.Point(15, 41);
            Encode_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Encode_TextBox.Multiline = true;
            Encode_TextBox.Name = "Encode_TextBox";
            Encode_TextBox.Size = new System.Drawing.Size(420, 76);
            Encode_TextBox.TabIndex = 0;
            // 
            // Encode_Btn
            // 
            Encode_Btn.Location = new System.Drawing.Point(448, 62);
            Encode_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Encode_Btn.Name = "Encode_Btn";
            Encode_Btn.Size = new System.Drawing.Size(88, 38);
            Encode_Btn.TabIndex = 1;
            Encode_Btn.Text = "Encode";
            Encode_Btn.UseVisualStyleBackColor = true;
            Encode_Btn.Click += Encode_Btn_Click;
            // 
            // Decode_Btn
            // 
            Decode_Btn.Location = new System.Drawing.Point(448, 163);
            Decode_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Decode_Btn.Name = "Decode_Btn";
            Decode_Btn.Size = new System.Drawing.Size(88, 38);
            Decode_Btn.TabIndex = 2;
            Decode_Btn.Text = "Decode";
            Decode_Btn.UseVisualStyleBackColor = true;
            Decode_Btn.Click += Decode_Btn_Click;
            // 
            // Decode_TextBox
            // 
            Decode_TextBox.Location = new System.Drawing.Point(15, 143);
            Decode_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Decode_TextBox.Multiline = true;
            Decode_TextBox.Name = "Decode_TextBox";
            Decode_TextBox.Size = new System.Drawing.Size(420, 76);
            Decode_TextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 38);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 17);
            label1.TabIndex = 4;
            label1.Text = "    Target   :";
            // 
            // Target_TextBox
            // 
            Target_TextBox.Location = new System.Drawing.Point(122, 35);
            Target_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Target_TextBox.Name = "Target_TextBox";
            Target_TextBox.PlaceholderText = "http://www.example.com";
            Target_TextBox.Size = new System.Drawing.Size(338, 23);
            Target_TextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 81);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 17);
            label2.TabIndex = 6;
            label2.Text = "RemotePackage:";
            // 
            // RemotePackage_TextBox
            // 
            RemotePackage_TextBox.Location = new System.Drawing.Point(122, 80);
            RemotePackage_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            RemotePackage_TextBox.Name = "RemotePackage_TextBox";
            RemotePackage_TextBox.PlaceholderText = "http://www.example.com/xxx.zip";
            RemotePackage_TextBox.Size = new System.Drawing.Size(302, 23);
            RemotePackage_TextBox.TabIndex = 7;
            // 
            // Exp_Btn
            // 
            Exp_Btn.Location = new System.Drawing.Point(481, 31);
            Exp_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Exp_Btn.Name = "Exp_Btn";
            Exp_Btn.Size = new System.Drawing.Size(88, 33);
            Exp_Btn.TabIndex = 8;
            Exp_Btn.Text = "Exploit";
            Exp_Btn.UseVisualStyleBackColor = true;
            Exp_Btn.Click += Exp_Btn_Click;
            // 
            // Detect_Btn
            // 
            Detect_Btn.Location = new System.Drawing.Point(481, 72);
            Detect_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Detect_Btn.Name = "Detect_Btn";
            Detect_Btn.Size = new System.Drawing.Size(88, 33);
            Detect_Btn.TabIndex = 9;
            Detect_Btn.Text = "Detect";
            Detect_Btn.UseVisualStyleBackColor = true;
            Detect_Btn.Click += Detect_Btn_Click;
            // 
            // PayloadStatus_PicBox
            // 
            PayloadStatus_PicBox.Location = new System.Drawing.Point(432, 72);
            PayloadStatus_PicBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            PayloadStatus_PicBox.Name = "PayloadStatus_PicBox";
            PayloadStatus_PicBox.Size = new System.Drawing.Size(29, 31);
            PayloadStatus_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PayloadStatus_PicBox.TabIndex = 10;
            PayloadStatus_PicBox.TabStop = false;
            // 
            // Log_TextBox
            // 
            Log_TextBox.Location = new System.Drawing.Point(18, 125);
            Log_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Log_TextBox.Multiline = true;
            Log_TextBox.Name = "Log_TextBox";
            Log_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            Log_TextBox.Size = new System.Drawing.Size(550, 214);
            Log_TextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Encode_TextBox);
            groupBox1.Controls.Add(Decode_TextBox);
            groupBox1.Controls.Add(Encode_Btn);
            groupBox1.Controls.Add(Decode_Btn);
            groupBox1.Location = new System.Drawing.Point(18, 385);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox1.Size = new System.Drawing.Size(551, 261);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payload En/Decoder";
            // 
            // Help_PicBox
            // 
            Help_PicBox.Location = new System.Drawing.Point(272, 346);
            Help_PicBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Help_PicBox.Name = "Help_PicBox";
            Help_PicBox.Size = new System.Drawing.Size(38, 42);
            Help_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Help_PicBox.TabIndex = 13;
            Help_PicBox.TabStop = false;
            Help_PicBox.Click += Help_PicBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(588, 667);
            Controls.Add(Help_PicBox);
            Controls.Add(groupBox1);
            Controls.Add(Log_TextBox);
            Controls.Add(PayloadStatus_PicBox);
            Controls.Add(Detect_Btn);
            Controls.Add(Exp_Btn);
            Controls.Add(RemotePackage_TextBox);
            Controls.Add(label2);
            Controls.Add(Target_TextBox);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(604, 706);
            MinimumSize = new System.Drawing.Size(604, 706);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SiteServer4.x-5.x RTD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PayloadStatus_PicBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Help_PicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

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

