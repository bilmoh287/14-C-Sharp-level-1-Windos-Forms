namespace WindowsFormsApp1
{
    partial class frmListView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListView));
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnList = new System.Windows.Forms.RadioButton();
            this.btnLargeIcon = new System.Windows.Forms.RadioButton();
            this.btnTile = new System.Windows.Forms.RadioButton();
            this.btnSmallIcon = new System.Windows.Forms.RadioButton();
            this.rbDetail = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(25, 278);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1151, 351);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Boy.jpg");
            this.imageList1.Images.SetKeyName(1, "girl.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Boy.jpg");
            this.imageList2.Images.SetKeyName(1, "girl.png");
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(297, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 54);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(474, 93);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(171, 54);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Rmove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(651, 93);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(171, 54);
            this.btnFill.TabIndex = 3;
            this.btnFill.Text = "Fill Random";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(69, 97);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(189, 22);
            this.txtID.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 138);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 22);
            this.txtName.TabIndex = 7;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(40, 215);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(76, 29);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(137, 215);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(98, 29);
            this.rbFemale.TabIndex = 9;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnLargeIcon);
            this.groupBox1.Controls.Add(this.btnTile);
            this.groupBox1.Controls.Add(this.btnSmallIcon);
            this.groupBox1.Controls.Add(this.rbDetail);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(853, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 190);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // btnList
            // 
            this.btnList.AutoSize = true;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(149, 80);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(59, 26);
            this.btnList.TabIndex = 19;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.CheckedChanged += new System.EventHandler(this.btnList_CheckedChanged_1);
            // 
            // btnLargeIcon
            // 
            this.btnLargeIcon.AutoSize = true;
            this.btnLargeIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargeIcon.Location = new System.Drawing.Point(149, 37);
            this.btnLargeIcon.Name = "btnLargeIcon";
            this.btnLargeIcon.Size = new System.Drawing.Size(115, 26);
            this.btnLargeIcon.TabIndex = 18;
            this.btnLargeIcon.Text = "Large Icon";
            this.btnLargeIcon.UseVisualStyleBackColor = true;
            this.btnLargeIcon.CheckedChanged += new System.EventHandler(this.btnLargeIcon_CheckedChanged_1);
            // 
            // btnTile
            // 
            this.btnTile.AutoSize = true;
            this.btnTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTile.Location = new System.Drawing.Point(7, 127);
            this.btnTile.Name = "btnTile";
            this.btnTile.Size = new System.Drawing.Size(61, 26);
            this.btnTile.TabIndex = 17;
            this.btnTile.Text = "Tile";
            this.btnTile.UseVisualStyleBackColor = true;
            this.btnTile.CheckedChanged += new System.EventHandler(this.btnTile_CheckedChanged_1);
            // 
            // btnSmallIcon
            // 
            this.btnSmallIcon.AutoSize = true;
            this.btnSmallIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmallIcon.Location = new System.Drawing.Point(7, 83);
            this.btnSmallIcon.Name = "btnSmallIcon";
            this.btnSmallIcon.Size = new System.Drawing.Size(113, 26);
            this.btnSmallIcon.TabIndex = 16;
            this.btnSmallIcon.Text = "Small Icon";
            this.btnSmallIcon.UseVisualStyleBackColor = true;
            this.btnSmallIcon.CheckedChanged += new System.EventHandler(this.btnSmallIcon_CheckedChanged_1);
            // 
            // rbDetail
            // 
            this.rbDetail.AutoSize = true;
            this.rbDetail.Checked = true;
            this.rbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDetail.Location = new System.Drawing.Point(7, 37);
            this.rbDetail.Name = "rbDetail";
            this.rbDetail.Size = new System.Drawing.Size(82, 29);
            this.rbDetail.TabIndex = 15;
            this.rbDetail.TabStop = true;
            this.rbDetail.Text = "Detail";
            this.rbDetail.UseVisualStyleBackColor = true;
            this.rbDetail.CheckedChanged += new System.EventHandler(this.rbDetail_CheckedChanged_1);
            // 
            // frmListView
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 717);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listView1);
            this.Name = "frmListView";
            this.Text = "frmListView";
            this.Load += new System.EventHandler(this.frmListView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnList;
        private System.Windows.Forms.RadioButton btnLargeIcon;
        private System.Windows.Forms.RadioButton btnTile;
        private System.Windows.Forms.RadioButton btnSmallIcon;
        private System.Windows.Forms.RadioButton rbDetail;
    }
}