﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semena_6___Parcial_1
{
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
        }

        private void menu_principal_Load(object sender, EventArgs e)
        {

        }



        private void combosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void combo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo1 cc = new combo1();
            cc.Show();
        }

        private void combo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            combo2 c2 = new combo2();
            c2.Show();
        }

        private void combo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo3 c3 = new combo3();
            c3.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fatura f1 = new fatura();
            f1.ShowDialog();
        }

        private void heladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helado h1 = new helado();
            h1.Show();
        }

        private void bocadillosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bocadillos bb = new bocadillos();
            bb.Show();
        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acerdade aa = new acerdade();
            aa.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda a1 = new ayuda();
            a1.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empleados ee = new empleados();
            ee.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes cc = new clientes();
            cc.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
