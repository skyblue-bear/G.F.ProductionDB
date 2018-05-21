using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*********************************/
/* MIT License                   */
/* Copyright (c) 2018 이상한녀석 */
/*********************************/

namespace ProductionDB
{
    public partial class FrmMain : Form
    {
        List<Doll> DollData = new List<Doll>();
        List<Equipment> EquipmentData = new List<Equipment>();
        List<Fairy> FairyData = new List<Fairy>();
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void CmdFind_Click(object sender, EventArgs e)
        {
            if (RadioDoll.Checked)
                Find_Doll();
            else if (int.Parse(TxtHour.Text) < 3)
                Find_Equipment();
            else
                Find_Fariy();
            TxtHour.Focus();
        }

        private void TxtHour_Enter(object sender, EventArgs e)
        {
            TxtHour.SelectAll();
        }

        private void TxtMinute_Enter(object sender, EventArgs e)
        {
            TxtMinute.SelectAll();
        }

        private void TxtHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                TxtMinute.Focus();
        }

        private void TxtMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtHour_Leave(object sender, EventArgs e)
        {
            if (TxtHour.Text == "")
                TxtHour.Text = "0";
        }

        private void TxtMinute_Leave(object sender, EventArgs e)
        {
            if (TxtMinute.Text == "")
                TxtMinute.Text = "0";
        }

        private void TxtHour_MouseClick(object sender, MouseEventArgs e)
        {
            TxtHour.SelectAll();
        }

        private void TxtMinute_MouseClick(object sender, MouseEventArgs e)
        {
            TxtMinute.SelectAll();
        }

        private void TxtHour_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TxtHour.Text, out int i) == true && i > 8)
                TxtHour.Text = "8";
        }

        private void TxtMinute_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TxtMinute.Text, out int i) == true && i > 59)
                TxtMinute.Text = "59";
        }

        private void RadioDoll_Click(object sender, EventArgs e)
        {
            TxtHour.Focus();
        }

        private void RadioEquipment_Click(object sender, EventArgs e)
        {
            TxtHour.Focus();
        }
    }
}
