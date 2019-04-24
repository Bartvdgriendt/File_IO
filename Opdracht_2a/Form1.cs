using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Opdracht_2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbDrives.Items.Clear();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                lbDrives.Items.Add(drive.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                lPathDirectory.Text = "Path: " + path;
            }            
        }

        private void bFindFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lPathFile.Text = "Path: " + openFileDialog.FileName;
            }
        }

        private void bCopyFile_Click(object sender, EventArgs e)
        {
            string filename = null;
            string destination = null;
            string source = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select destination";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                source = openFileDialog.FileName;
                filename = Path.GetFileName(source);

                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                folderBrowserDialog.Description = "Select destination";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    destination = folderBrowserDialog.SelectedPath;
                }
            }

            File.Copy(source, destination+"/"+filename);
        }

        private void bGetInfoFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] tekst = File.ReadAllLines(openFileDialog.FileName);
                textBox1.Text = tekst[0];
                textBox2.Text = tekst[1];
                textBox3.Text = tekst[2];
                textBox4.Text = tekst[3];
                textBox5.Text = tekst[4];
                textBox6.Text = tekst[5];
            }
        }

        private void bWriteInfo_Click(object sender, EventArgs e)
        {
            string[] tekst = {
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text,
                textBox6.Text
            };

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, tekst);
            }
        }
    }
}
