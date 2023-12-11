﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_page
{
    public partial class closet : Form
    {
        public closet()
        {
            InitializeComponent();
        }

        private void closet_Load(object sender, EventArgs e)
        {
            logo.Parent = Background;
            logo.BackColor = Color.Transparent;

            cart.BackColor = Color.Transparent;
            cart.Parent = Background;

            cart_inside.Parent = Background;
            cart_inside.BackColor = Color.Transparent;

            colors.BackColor = Color.Transparent;
            colors.Parent = Background;

            back.BackColor = Color.Transparent;
            back.Parent = Background;

            next.BackColor = Color.Transparent;
            next.Parent = Background;

        }

        private void back_Click(object sender, EventArgs e)
        {
            Bed form= new Bed();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Homepage form = new Homepage();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void colors_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.colors.CreateGraphics();
            Pen p = new Pen(Color.Brown, 15);
            g.DrawEllipse(p, 15, 15, 15, 15);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("item added to cart successfully");
        }
    }
}
