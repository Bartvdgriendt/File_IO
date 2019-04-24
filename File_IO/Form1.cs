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

namespace File_IO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string randomWordFromTextFile(string path)
        {
            string[] words = File.ReadAllLines(path);
            List<string> wordlist = new List<string>();
            int nrOfWords = Convert.ToInt32(words[0]);
            int nrOfLines = words.Count();
            int minNrSubString = 0;
            for(int i = 1; i< nrOfLines; i++)
            {
                int subStringNr = words[i].IndexOf(" ");
                string subString = words[i].Substring(minNrSubString, subStringNr);
                wordlist.Add(subString);
                minNrSubString += subStringNr + 1;
                words[i].Replace()
            }

            




            return null;
        }

        private void bReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               randomWordFromTextFile(openFileDialog.FileName);


            }





        }
    }
}
