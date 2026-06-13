using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace invExperto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Articulo> Inventario()
        {
            var inventario = new List<Articulo>();
            string url = "Server = 3.128.144.165; DataBase = SE202602; User ID=db2; Password=123";
            SqlConnection cnx = new SqlConnection(url);
            SqlDataAdapter adpInv = new SqlDataAdapter("select * from articulo", cnx);
            DataTable tabInv = new DataTable(); adpInv.Fill(tabInv);

            foreach (DataRow row in tabInv.Rows)
            {
                inventario.Add(new Articulo(row));
            }

            return inventario;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdMotor_Click(object sender, EventArgs e)
        {
            var inventario = Inventario();
            var motor = new Motor(inventario);

            // Regla1   Si la existencia en menor que cantidad minima, Reabastecer al maximo permito
            //          donde el maximo permitido en 3 veces la cantidad minima.
            // Regla2   Si el tiempo cubierto por las existencias en menor que el tiempo de reabastecimiento
            //          Alerta de deshabatecimiento

            motor.nuevaRegla(item => item.Existencia < item.Minimo,
                             item => $"Se necesitan comprar {item.Minimo * 3 - item.Existencia} unidades");
            motor.nuevaRegla(item => item.Existencia / item.Promedio < item.Tiempo,
                             item => "Peligro de deshabatecimiento");
            motor.nuevaRegla(item => item.Existencia > item.Minimo * 3,
                             item => "Tiene demasiadas existencia");

            var conclusiones = motor.Evaluar();

            richTextBox1.AppendText("Las conclusiones obtenidad a partir del inventario acutal son:\n");

            foreach (var conclusion in conclusiones)
            {
                richTextBox1.AppendText("\n - " + conclusion);
            }
        }
    }
}
