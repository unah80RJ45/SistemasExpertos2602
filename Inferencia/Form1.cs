using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inferencia
{
    public partial class Form1 : Form
    {
        Motor motor = new Motor();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            motor.nuevaRegla("huracan", "llueve");
            motor.nuevaRegla("llueve", "la calle esta mojada");
            motor.nuevaRegla("tiembla", "hay derrumbes");
            motor.nuevaRegla("la calle esta mojada", "los carros no frenan bien");
            motor.nuevaRegla("los carros no frenan bien", "hay accidentes");
            motor.nuevaRegla("hay derrumbes", "hay accidentes");
            motor.nuevaRegla("hay accidentes", "hay emergencias");
            motor.nuevaRegla("hay emergencias", "Hospitales llenos");
        }

        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            if (!chkHuracan.Checked && !chkLluvia.Checked && !chkTerremoto.Checked)
                MessageBox.Show("Debe seleccionar al menos un hecho", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                richTextBox1.Clear(); motor.Limpiar();
                if (chkLluvia.Checked) motor.nuevoHecho("llueve");
                if (chkTerremoto.Checked) motor.nuevoHecho("tiembla");
                if (chkHuracan.Checked) motor.nuevoHecho("huracan");

                motor.Ejecutar(richTextBox1); motor.Mostrar(richTextBox1);
            }
        }
    }
}
