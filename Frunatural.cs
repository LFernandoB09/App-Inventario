using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Inventario
{
    public partial class Frunatural : Form
    {
        public Frunatural()
        {
            InitializeComponent();

            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 15, 15));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void Frunatural_Load(object sender, EventArgs e)
        {
            Funciones.cargarInventarioFrunatural(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
