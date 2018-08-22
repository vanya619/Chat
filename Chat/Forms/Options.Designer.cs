namespace Chat
{
    partial class Options
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxEncoding = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxReadTime = new System.Windows.Forms.TextBox();
            this.TbxWriteTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxPortName = new System.Windows.Forms.ComboBox();
            this.CbxDataBits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxBaudRate = new System.Windows.Forms.ComboBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxEncoding);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbxReadTime);
            this.groupBox1.Controls.Add(this.TbxWriteTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CbxPortName);
            this.groupBox1.Controls.Add(this.CbxDataBits);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CbxBaudRate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // CbxEncoding
            // 
            this.CbxEncoding.FormattingEnabled = true;
            this.CbxEncoding.Location = new System.Drawing.Point(108, 151);
            this.CbxEncoding.Name = "CbxEncoding";
            this.CbxEncoding.Size = new System.Drawing.Size(118, 21);
            this.CbxEncoding.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Кодировка";
            // 
            // TbxReadTime
            // 
            this.TbxReadTime.Location = new System.Drawing.Point(108, 99);
            this.TbxReadTime.Name = "TbxReadTime";
            this.TbxReadTime.Size = new System.Drawing.Size(118, 20);
            this.TbxReadTime.TabIndex = 10;
            // 
            // TbxWriteTime
            // 
            this.TbxWriteTime.Location = new System.Drawing.Point(108, 125);
            this.TbxWriteTime.Name = "TbxWriteTime";
            this.TbxWriteTime.Size = new System.Drawing.Size(118, 20);
            this.TbxWriteTime.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Время записи";
            // 
            // CbxPortName
            // 
            this.CbxPortName.FormattingEnabled = true;
            this.CbxPortName.Location = new System.Drawing.Point(108, 72);
            this.CbxPortName.Name = "CbxPortName";
            this.CbxPortName.Size = new System.Drawing.Size(121, 21);
            this.CbxPortName.TabIndex = 7;
            // 
            // CbxDataBits
            // 
            this.CbxDataBits.FormattingEnabled = true;
            this.CbxDataBits.Location = new System.Drawing.Point(108, 45);
            this.CbxDataBits.Name = "CbxDataBits";
            this.CbxDataBits.Size = new System.Drawing.Size(121, 21);
            this.CbxDataBits.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Бод (Бит/с)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Бит данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя порта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Время чтения";
            // 
            // CbxBaudRate
            // 
            this.CbxBaudRate.FormattingEnabled = true;
            this.CbxBaudRate.Location = new System.Drawing.Point(108, 18);
            this.CbxBaudRate.Name = "CbxBaudRate";
            this.CbxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.CbxBaudRate.TabIndex = 5;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(81, 198);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 224);
            this.ControlBox = false;
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "Options";
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbxPortName;
        private System.Windows.Forms.ComboBox CbxDataBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxBaudRate;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox TbxReadTime;
        private System.Windows.Forms.TextBox TbxWriteTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbxEncoding;
        private System.Windows.Forms.Label label6;
    }
}