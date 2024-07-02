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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 15, 15));
            pictureBox2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox2.Width, pictureBox2.Height, 15, 15));
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));

            //Redondear Bordes A Los Botones

            button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));
            button2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));
            button3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));
            button4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));
            button5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));
            button6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));
        }


        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpiar el panel
            panel1.Controls.Clear();

            //Mostrar el form en el panel
            Seven seven = new Seven();
            seven.TopLevel = false;               
            seven.FormBorderStyle = FormBorderStyle.None; 
            seven.Dock = DockStyle.Fill;          
            panel1.Controls.Add(seven);           
            seven.Show();
            label2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpiar el panel
            panel1.Controls.Clear();

            //Mostrar el form en el panel
            Optima optima = new Optima();
            optima.TopLevel = false;
            optima.FormBorderStyle = FormBorderStyle.None;
            optima.Dock = DockStyle.Fill;
            panel1.Controls.Add(optima);
            optima.Show();
            label2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Limpiar el panel
            panel1.Controls.Clear();

            //Mostrar el form en el panel
            Frunatural frunatural = new Frunatural();
            frunatural.TopLevel = false;
            frunatural.FormBorderStyle = FormBorderStyle.None;
            frunatural.Dock = DockStyle.Fill;
            panel1.Controls.Add(frunatural);
            frunatural.Show();
            label2.Visible = false;
        }
    }
}
