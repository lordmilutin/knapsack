using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Knapsack
{
    public partial class Form1 : Form
    {
        Knapsack knap = new Knapsack();

        public Form1()
        {
            InitializeComponent();
        }

        private void calcBut_Click(object sender, EventArgs e)
        {
            if (fsMemberBox.TextLength == 0 || numMemBox.TextLength == 0)
                MessageBox.Show("Enter 1st element and number of elements!");
            else if (keyBox.Text == "" || knap.FsMem != fsMemberBox.Text || knap.NumMem != numMemBox.Text)
            {
                if ((Convert.ToInt32(numMemBox.Text) < Convert.ToInt32(knap.NumMem)) && (keyBox.Text != "") && (fsMemberBox.Text == knap.FsMem))
                { 
                    knap.NumMem = numMemBox.Text;
                    knap.ModifyQueue();
                    queueBox.Text = knap.Queue;
                    keyBox.Text = knap.Key;
                    //imNBox.Text = knap.N1 + " " + knap.Im;
                }
                else 
                {
                    knap.FsMem = fsMemberBox.Text;
                    knap.NumMem = numMemBox.Text;
                    knap.Queue = fsMemberBox.Text + " ";
                    queueBox.Text = knap.GenerateQueue();
                    keyBox.Text = knap.GenerateKey();
                    imNBox.Text = knap.N1 + " " + knap.Im;
                }
            }
            else if (knap.Queue != queueBox.Text)
            {  
                string[] pom = queueBox.Text.Split(' ');
                fsMemberBox.Text = pom[0];
                numMemBox.Text = pom.Length.ToString();
                knap.FsMem = pom[0];
                knap.NumMem = pom.Length.ToString();
                knap.Queue = queueBox.Text;
                keyBox.Text = knap.GenerateKey();
                fsMemberBox.Text = knap.FsMem;
                numMemBox.Text = knap.NumMem;
                imNBox.Text = knap.N1 + " " + knap.Im;
            }
            
        }

        private void encryptBut_Click(object sender, EventArgs e)
        {
            if (plainTxt.TextLength == 0)
                MessageBox.Show("Enter plain text!");
            else
                cryptTxt.Text = knap.Crypt(plainTxt.Text);
        }

        private void decryptBut_Click(object sender, EventArgs e)
        {
            if (cryptTxt.TextLength == 0)
                MessageBox.Show("Enter crypted data!");
            else
                decryptTxt.Text = knap.Decrypt(cryptTxt.Text);
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            if (decryptTxt.Text != "")
                saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string saveAs = saveFileDialog1.FileName + ".txt";
            File.WriteAllText(saveAs, this.decryptTxt.Text);
        }
    }
}
