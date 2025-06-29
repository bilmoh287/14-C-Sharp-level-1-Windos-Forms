﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowPart1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void btnShowMessageBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMessageBox();
            frm1.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void ChkBRadioGp_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmChkRadioGroup();
            frm1.ShowDialog();
        }

        private void btMoreAbtTextBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMoreTextBox();
            frm1.ShowDialog();
        }

        private void btnImageBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmImageBox();
            frm1.ShowDialog();
        }

        private void btnImgBoxExer_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmImageBoxExer();
            frm1.ShowDialog();
        }

        private void btnTicTacToeGame_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTicTacToeGame();
            frm1.ShowDialog();
        }

        private void btnMaskedBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMaskedBox();
            frm1.ShowDialog();
        }

        private void btnLabelink_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmlinkTabel();
            frm1.ShowDialog();
        }

        private void btnchkListBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmCheckedLisBox();
            frm1.ShowDialog();
        }

        private void btnDateTimePicker_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmDateTimePicker();
            frm1.ShowDialog();
        }

        private void btnMonthCalander_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMonthCalander();
            frm1.ShowDialog();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTimer();
            frm1.ShowDialog();
        }

        private void btnNotifyIcon_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmNotifyIcon();
            frm1.ShowDialog();
        }

        private void btnProgressBar_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmProgressBar();
            frm1.ShowDialog();
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmListView();
            frm1.ShowDialog();
        }

        private void btnErrorProvider_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmErrorProvider();
            frm1.ShowDialog();
        }

        private void btnTrackBar_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTrackBar();
            frm1.ShowDialog();
        }

        private void btnNumeric_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmNumericUpDown();
            frm1.ShowDialog();
        }

        private void btnEmpMgSys_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmEmployeeManagementSystem();
            frm1.ShowDialog();
        }

        private void btnPanelandColorDialog_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmPanelAndColorDialog();
            frm1.ShowDialog();
        }
    }
}
