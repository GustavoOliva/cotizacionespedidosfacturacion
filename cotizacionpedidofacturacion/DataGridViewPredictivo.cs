using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dllconnectionDataBase
{
    public partial class DataGridViewPredictivo : UserControl
    {

        [Description("Nombre de la tabla ")]
        [Category("Datos Importantes")]
        public String NombreTabla { get; set; }
        [Description("Nombre del campo")]
        [Category("Datos Importantes")]
        public String NombreCampo { get; set; }


        public static String stringpad = "server=localhost;user id=root;database=analisisdata";
        dllconnectionDataBase connection = new dllconnectionDataBase(stringpad);

        public DataGridViewPredictivo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connection.OpenConnection();
            dataGridView1.DataSource = connection.llenarDataGridView("select * from " + NombreTabla + " where " + NombreCampo + " like '" + textBox1.Text + "%'");
            connection.CloseConnection();
        }
    }
}
