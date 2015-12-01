namespace Lab3Knapsack
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
            this.fsMemberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMemBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.queueBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.plainTxt = new System.Windows.Forms.TextBox();
            this.calcBut = new System.Windows.Forms.Button();
            this.cryptTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.decryptTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.decryptBut = new System.Windows.Forms.Button();
            this.encryptBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.imNBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fsMemberBox
            // 
            this.fsMemberBox.Location = new System.Drawing.Point(83, 37);
            this.fsMemberBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fsMemberBox.MaxLength = 4;
            this.fsMemberBox.Name = "fsMemberBox";
            this.fsMemberBox.Size = new System.Drawing.Size(27, 20);
            this.fsMemberBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First element:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elements:";
            // 
            // numMemBox
            // 
            this.numMemBox.Location = new System.Drawing.Point(171, 37);
            this.numMemBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numMemBox.MaxLength = 4;
            this.numMemBox.Name = "numMemBox";
            this.numMemBox.Size = new System.Drawing.Size(27, 20);
            this.numMemBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Superincreasing array:";
            // 
            // queueBox
            // 
            this.queueBox.Location = new System.Drawing.Point(12, 78);
            this.queueBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queueBox.MaxLength = 360000000;
            this.queueBox.Name = "queueBox";
            this.queueBox.Size = new System.Drawing.Size(302, 20);
            this.queueBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Plain text:";
            // 
            // plainTxt
            // 
            this.plainTxt.Location = new System.Drawing.Point(328, 39);
            this.plainTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plainTxt.MaxLength = 300000000;
            this.plainTxt.Multiline = true;
            this.plainTxt.Name = "plainTxt";
            this.plainTxt.Size = new System.Drawing.Size(288, 114);
            this.plainTxt.TabIndex = 9;
            // 
            // calcBut
            // 
            this.calcBut.Location = new System.Drawing.Point(638, 25);
            this.calcBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calcBut.Name = "calcBut";
            this.calcBut.Size = new System.Drawing.Size(75, 43);
            this.calcBut.TabIndex = 10;
            this.calcBut.Text = "Generate";
            this.calcBut.UseVisualStyleBackColor = true;
            this.calcBut.Click += new System.EventHandler(this.calcBut_Click);
            // 
            // cryptTxt
            // 
            this.cryptTxt.Location = new System.Drawing.Point(11, 189);
            this.cryptTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cryptTxt.MaxLength = 300000000;
            this.cryptTxt.Multiline = true;
            this.cryptTxt.Name = "cryptTxt";
            this.cryptTxt.Size = new System.Drawing.Size(288, 87);
            this.cryptTxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Crypted data:";
            // 
            // decryptTxt
            // 
            this.decryptTxt.Location = new System.Drawing.Point(328, 189);
            this.decryptTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.decryptTxt.MaxLength = 300000000;
            this.decryptTxt.Multiline = true;
            this.decryptTxt.Name = "decryptTxt";
            this.decryptTxt.Size = new System.Drawing.Size(288, 87);
            this.decryptTxt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Decrypted data:";
            // 
            // decryptBut
            // 
            this.decryptBut.Location = new System.Drawing.Point(638, 158);
            this.decryptBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.decryptBut.Name = "decryptBut";
            this.decryptBut.Size = new System.Drawing.Size(75, 43);
            this.decryptBut.TabIndex = 15;
            this.decryptBut.Text = "DeCrypt";
            this.decryptBut.UseVisualStyleBackColor = true;
            this.decryptBut.Click += new System.EventHandler(this.decryptBut_Click);
            // 
            // encryptBut
            // 
            this.encryptBut.Location = new System.Drawing.Point(638, 94);
            this.encryptBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.encryptBut.Name = "encryptBut";
            this.encryptBut.Size = new System.Drawing.Size(75, 43);
            this.encryptBut.TabIndex = 16;
            this.encryptBut.Text = "Crypt";
            this.encryptBut.UseVisualStyleBackColor = true;
            this.encryptBut.Click += new System.EventHandler(this.encryptBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(638, 233);
            this.saveBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(75, 43);
            this.saveBut.TabIndex = 17;
            this.saveBut.Text = "Save";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Public key:";
            // 
            // keyBox
            // 
            this.keyBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.keyBox.Location = new System.Drawing.Point(12, 131);
            this.keyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keyBox.MaxLength = 36000000;
            this.keyBox.Name = "keyBox";
            this.keyBox.ReadOnly = true;
            this.keyBox.Size = new System.Drawing.Size(302, 20);
            this.keyBox.TabIndex = 6;
            // 
            // imNBox
            // 
            this.imNBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imNBox.Location = new System.Drawing.Point(268, 37);
            this.imNBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imNBox.MaxLength = 36000000;
            this.imNBox.Name = "imNBox";
            this.imNBox.ReadOnly = true;
            this.imNBox.Size = new System.Drawing.Size(46, 20);
            this.imNBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "N and im:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 309);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.encryptBut);
            this.Controls.Add(this.decryptBut);
            this.Controls.Add(this.calcBut);
            this.Controls.Add(this.imNBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.decryptTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cryptTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.plainTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.queueBox);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMemBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fsMemberBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knapsack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fsMemberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numMemBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox queueBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox plainTxt;
        private System.Windows.Forms.Button calcBut;
        private System.Windows.Forms.TextBox cryptTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox decryptTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button decryptBut;
        private System.Windows.Forms.Button encryptBut;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.TextBox imNBox;
        private System.Windows.Forms.Label label8;
    }
}

