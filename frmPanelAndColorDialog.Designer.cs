namespace WindowsFormsApp1
{
    partial class frmPanelAndColorDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnOpenFileDialogMulti = new System.Windows.Forms.Button();
            this.btnFolderBrowseDialog = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(92, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 184);
            this.panel1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(34, 352);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(302, 30);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "This is A Text";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 250);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 30);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "This is A Text";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 135);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 30);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "This is A Text";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "This is A Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change Back Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Change Fore Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(769, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Change Back Color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(769, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Change Font";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(534, 224);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(212, 39);
            this.btnSaveFileDialog.TabIndex = 5;
            this.btnSaveFileDialog.Text = "Save FileDialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(539, 282);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(212, 39);
            this.btnOpenFileDialog.TabIndex = 6;
            this.btnOpenFileDialog.Text = "Open FileDialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnOpenFileDialogMulti
            // 
            this.btnOpenFileDialogMulti.Location = new System.Drawing.Point(769, 268);
            this.btnOpenFileDialogMulti.Name = "btnOpenFileDialogMulti";
            this.btnOpenFileDialogMulti.Size = new System.Drawing.Size(227, 67);
            this.btnOpenFileDialogMulti.TabIndex = 7;
            this.btnOpenFileDialogMulti.Text = "Open FileDialog Multi Select";
            this.btnOpenFileDialogMulti.UseVisualStyleBackColor = true;
            this.btnOpenFileDialogMulti.Click += new System.EventHandler(this.btnOpenFileDialogMulti_Click);
            // 
            // btnFolderBrowseDialog
            // 
            this.btnFolderBrowseDialog.Location = new System.Drawing.Point(539, 336);
            this.btnFolderBrowseDialog.Name = "btnFolderBrowseDialog";
            this.btnFolderBrowseDialog.Size = new System.Drawing.Size(212, 39);
            this.btnFolderBrowseDialog.TabIndex = 8;
            this.btnFolderBrowseDialog.Text = "Folder BrowseDialog";
            this.btnFolderBrowseDialog.UseVisualStyleBackColor = true;
            this.btnFolderBrowseDialog.Click += new System.EventHandler(this.btnFolderBrowseDialog_Click);
            // 
            // frmPanelAndColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 502);
            this.Controls.Add(this.btnFolderBrowseDialog);
            this.Controls.Add(this.btnOpenFileDialogMulti);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPanelAndColorDialog";
            this.Text = "frmColorDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Button btnOpenFileDialogMulti;
        private System.Windows.Forms.Button btnFolderBrowseDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}