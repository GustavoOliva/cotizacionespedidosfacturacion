using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllconnectionDataBase;

namespace cotizacionpedidofacturacion
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

        private void button1_Click(object sender, EventArgs e)
        {
            String stringpad = "server=localhost;user id=root;database=hotelSanCarlos";
            dllconnectionDataBase.dllconnectionDataBase connection = new dllconnectionDataBase.dllconnectionDataBase(stringpad);
            if (connection.OpenConnection())
            {
                /*We open the connection*/
                MessageBox.Show("Conexion exitosa");
            }
            else
            {
                /*We have an error*/
                MessageBox.Show("Error");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String stringpad = "server=localhost;user id=root;database=analisisdata";
            dllconnectionDataBase.dllconnectionDataBase connection = new dllconnectionDataBase.dllconnectionDataBase(stringpad);

            connection.OpenConnection();
            connection.InsertarRegistro("insert into cotizaciones ( `idProducto`, `cantidad`, `fechaCotizacion`, `total`, `idEmpleado`) VALUES ( '" + this.idProducto.Text + "', '" + this.cantidad.Text + "','" + this.fecha.Text + "','" + this.total.Text + "','" + this.idVendedor.Text + "');");
            connection.CloseConnection();

       
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewPredictivo1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
