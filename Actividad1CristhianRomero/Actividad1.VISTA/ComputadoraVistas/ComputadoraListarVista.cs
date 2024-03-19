﻿using Actividad1.BSS;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1.VISTA.ComputadoraVistas
{ 
    public partial class ComputadoraListarVista : Form
    {

        public ComputadoraListarVista()
        {
            InitializeComponent();
        }


        ComputadoraBss bss = new ComputadoraBss();

        private void ComputadoraListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarComputadoraBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComputadoraInsertarVista fr = new ComputadoraInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarComputadoraBss();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int IdComputadoraSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ComputadoraEditarVista fr = new ComputadoraEditarVista(IdComputadoraSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarComputadoraBss();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int IdComputadoraSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta computadora?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarComputadoraBss(IdComputadoraSeleccionada);
                dataGridView1.DataSource = bss.ListarComputadoraBss();
            }
        }
    }
}
