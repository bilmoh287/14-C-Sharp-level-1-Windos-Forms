namespace WindowsFormsApp1
{
    partial class frmMaskedBox
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnToMaskedBoxForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BeepOnError = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(148, 125);
            this.maskedTextBox1.Mask = "#####";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(232, 22);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // btnToMaskedBoxForm
            // 
            this.btnToMaskedBoxForm.Location = new System.Drawing.Point(233, 217);
            this.btnToMaskedBoxForm.Name = "btnToMaskedBoxForm";
            this.btnToMaskedBoxForm.Size = new System.Drawing.Size(147, 77);
            this.btnToMaskedBoxForm.TabIndex = 1;
            this.btnToMaskedBoxForm.Text = "Masked Box Practice";
            this.btnToMaskedBoxForm.UseVisualStyleBackColor = true;
            this.btnToMaskedBoxForm.Click += new System.EventHandler(this.btnToMaskedBoxForm_Click);
            // 
            // frmMaskedBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToMaskedBoxForm);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "frmMaskedBox";
            this.Text = "frmMaskedBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnToMaskedBoxForm;
    }
}