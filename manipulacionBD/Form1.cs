using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace manipulacionBD
{
    public partial class Form1 : Form
    {
        MySqlConnection conexionBD;
        MySqlDataAdapter adapt;
        MySqlCommand cmd;
        MySqlDataReader reader = null;
        int ID = 0;


        public void verificarBD()
        {
            string cadenaconexion = "server=localhost; port=3306; user id=root; password=; database=videojuegosFrag;";//En caso marque error inserter la contraseña y la base de datos tiene que ser la que se quiera usar
            conexionBD = new MySqlConnection(cadenaconexion);

            try
            {
                conexionBD.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexionBD.Close();
        }

        public void DisplayData()
        {
            conexionBD.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from sucursales1 union select * from sucursales2 union select * from sucursales3", conexionBD);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conexionBD.Close();
        }
        private void ClearData()
        {
            txt_Name.Text = "";
            txt_State.Text = "";
            ID = 0;
        }

        public Form1()
        {
            InitializeComponent();
            verificarBD();
            DisplayData();
            ClearData();            
        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
