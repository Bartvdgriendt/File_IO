namespace Opdracht_2a
{
    partial class Form1
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
            this.bFindDirectoryPath = new System.Windows.Forms.Button();
            this.lPathDirectory = new System.Windows.Forms.Label();
            this.lPathFile = new System.Windows.Forms.Label();
            this.bFindFilePath = new System.Windows.Forms.Button();
            this.lbDrives = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCopyFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.bGetInfoFromFile = new System.Windows.Forms.Button();
            this.bWriteInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bFindDirectoryPath
            // 
            this.bFindDirectoryPath.Location = new System.Drawing.Point(12, 12);
            this.bFindDirectoryPath.Name = "bFindDirectoryPath";
            this.bFindDirectoryPath.Size = new System.Drawing.Size(173, 23);
            this.bFindDirectoryPath.TabIndex = 0;
            this.bFindDirectoryPath.Text = "Find path of directory";
            this.bFindDirectoryPath.UseVisualStyleBackColor = true;
            this.bFindDirectoryPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // lPathDirectory
            // 
            this.lPathDirectory.AutoSize = true;
            this.lPathDirectory.Location = new System.Drawing.Point(12, 38);
            this.lPathDirectory.Name = "lPathDirectory";
            this.lPathDirectory.Size = new System.Drawing.Size(35, 13);
            this.lPathDirectory.TabIndex = 1;
            this.lPathDirectory.Text = "Path: ";
            // 
            // lPathFile
            // 
            this.lPathFile.AutoSize = true;
            this.lPathFile.Location = new System.Drawing.Point(12, 80);
            this.lPathFile.Name = "lPathFile";
            this.lPathFile.Size = new System.Drawing.Size(35, 13);
            this.lPathFile.TabIndex = 3;
            this.lPathFile.Text = "Path: ";
            // 
            // bFindFilePath
            // 
            this.bFindFilePath.Location = new System.Drawing.Point(12, 54);
            this.bFindFilePath.Name = "bFindFilePath";
            this.bFindFilePath.Size = new System.Drawing.Size(173, 23);
            this.bFindFilePath.TabIndex = 2;
            this.bFindFilePath.Text = "Find path of file";
            this.bFindFilePath.UseVisualStyleBackColor = true;
            this.bFindFilePath.Click += new System.EventHandler(this.bFindFilePath_Click);
            // 
            // lbDrives
            // 
            this.lbDrives.FormattingEnabled = true;
            this.lbDrives.Location = new System.Drawing.Point(191, 25);
            this.lbDrives.Name = "lbDrives";
            this.lbDrives.Size = new System.Drawing.Size(203, 95);
            this.lbDrives.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // bCopyFile
            // 
            this.bCopyFile.Location = new System.Drawing.Point(12, 97);
            this.bCopyFile.Name = "bCopyFile";
            this.bCopyFile.Size = new System.Drawing.Size(170, 23);
            this.bCopyFile.TabIndex = 6;
            this.bCopyFile.Text = "Copy file";
            this.bCopyFile.UseVisualStyleBackColor = true;
            this.bCopyFile.Click += new System.EventHandler(this.bCopyFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 272);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(191, 220);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(191, 194);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(203, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(191, 168);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(203, 20);
            this.textBox6.TabIndex = 13;
            // 
            // bGetInfoFromFile
            // 
            this.bGetInfoFromFile.Location = new System.Drawing.Point(12, 139);
            this.bGetInfoFromFile.Name = "bGetInfoFromFile";
            this.bGetInfoFromFile.Size = new System.Drawing.Size(173, 23);
            this.bGetInfoFromFile.TabIndex = 14;
            this.bGetInfoFromFile.Text = "Get info from file";
            this.bGetInfoFromFile.UseVisualStyleBackColor = true;
            this.bGetInfoFromFile.Click += new System.EventHandler(this.bGetInfoFromFile_Click);
            // 
            // bWriteInfo
            // 
            this.bWriteInfo.Location = new System.Drawing.Point(12, 168);
            this.bWriteInfo.Name = "bWriteInfo";
            this.bWriteInfo.Size = new System.Drawing.Size(173, 23);
            this.bWriteInfo.TabIndex = 15;
            this.bWriteInfo.Text = "Write info";
            this.bWriteInfo.UseVisualStyleBackColor = true;
            this.bWriteInfo.Click += new System.EventHandler(this.bWriteInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.bWriteInfo);
            this.Controls.Add(this.bGetInfoFromFile);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bCopyFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDrives);
            this.Controls.Add(this.lPathFile);
            this.Controls.Add(this.bFindFilePath);
            this.Controls.Add(this.lPathDirectory);
            this.Controls.Add(this.bFindDirectoryPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFindDirectoryPath;
        private System.Windows.Forms.Label lPathDirectory;
        private System.Windows.Forms.Label lPathFile;
        private System.Windows.Forms.Button bFindFilePath;
        private System.Windows.Forms.ListBox lbDrives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCopyFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button bGetInfoFromFile;
        private System.Windows.Forms.Button bWriteInfo;
    }
}

