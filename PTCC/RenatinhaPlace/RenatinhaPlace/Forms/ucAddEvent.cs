﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using RenatinhaPlace.Entity;


namespace RenatinhaPlace.Forms
{
    public partial class ucAddEvent : UserControl
    {
        public ucAddEvent()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ucAddEvent_Load(object sender, EventArgs e)
        {
            lblNameEvent.Text = Strings.EventName;
            lblDescEvent.Text = Strings.Desc;
            lblArtEvent.Text = Strings.Artist;
            lblMenuEvent.Text = Strings.Menu;
            lblDateEvent.Text = Strings.Date;
            lblTimeEvent.Text = Strings.Time;
            btnRegistrer.Text = Strings.Register;
            btnClear.Text = Strings.ClearFields;

        }

        private void lblNameEvent_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameEvent.Clear();
            txtDescEvent.Clear();
            mcbArtEvent.SelectedItem = "";
            mcbMenuEvent.SelectedItem = "";
            txtTimeEvent1.Clear();
            txtTimeEvent2.Clear();
            txtNameEvent.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, Strings.ConfRegister, Strings.Register, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //EntitiesContext context = new EntitiesContext();
                //Event eve = new Event()
                //{
                //    Name = txtNameEvent.Text,
                //    Desc = txtDescEvent.Text,
                //    TimeBegin = txtTimeEvent1.Text,
                //    TimeEnd = txtTimeEvent2.Text,
                //    ArtistId = (ARRUMAR),
                //    MenuId = (ARRUMAR)

                //};
                //context.Events.Add(eve);
                //context.SaveChanges();
                //context.Dispose();
            }
        }

        private void RegisterEvent()
        {

        }

    }
}
