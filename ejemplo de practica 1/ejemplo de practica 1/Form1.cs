﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_de_practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Aceptar(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje con boton aceptar", "Ejemplo Mensaje Aceptar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje con boton aceptar y cance",  "Ejemplo Mensaje Aceptar";
            MessageBox.Show("Mensaje con boton Cancelar", "Ejemplo Mensaje Cancelar");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
