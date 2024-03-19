using Actividad1.BSS;
using Actividad1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Actividad1.VISTA.ComputadoraVistas
{
    public partial class ComputadoraEditarVista : Form
    {
        int idc = 0;
        Computadora computadora = new Computadora();
        ComputadoraBss bss = new ComputadoraBss();
        public ComputadoraEditarVista(int idx)
        {
            idc= idx;
            InitializeComponent();
        }

        private void ComputadoraEditarVista_Load(object sender, EventArgs e)
        {
            computadora = bss.ObtenerComputadoraIdBss(idc);

            textBox1.Text = computadora.Nombre;
            textBox2.Text = computadora.Descripcion;
            textBox3.Text = computadora.Precio.ToString();
            dateTimePicker1.Value = computadora.FechaDeFabricacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            computadora.Nombre = textBox1.Text;
            computadora.Descripcion = textBox2.Text;
            computadora.Precio = Convert.ToDecimal(textBox3.Text);
            computadora.FechaDeFabricacion = dateTimePicker1.Value;

            bss.EditarComputadoraBss(computadora);
            MessageBox.Show("Los Datos han sido Actualizados");
        }
    }
}
