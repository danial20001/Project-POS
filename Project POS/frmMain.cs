﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project_POS
{
    public partial class frmMain : Form
    {
        // Property to store the username
        public string UserName { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        // Use the OnLoad method to set the label text to the username when the form loads
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label1.Text = UserName; // Assuming 'label1' is the name of your label control
        }

        // Event handlers for other controls, if needed
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Code for what happens when guna2Button1 is clicked
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }
    }
}





