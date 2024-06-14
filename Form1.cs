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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //button1.FlatStyle = FlatStyle.Flat;
            //button1.FlatAppearance.BorderSize = 0;

            button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void button1_Click(object sender, EventArgs e)
        {
            funciones.login(txtUsuario.Text, txtContr.Text);
        }
    }
}
