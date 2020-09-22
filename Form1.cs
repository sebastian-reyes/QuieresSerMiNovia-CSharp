using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuieresSerMiNovia
{
    public partial class uwu : Form
    {
        public uwu()
        {
            InitializeComponent();
        }

        private void uwu_Load(object sender, EventArgs e)
        {
            lblPregunta.Parent = pictureBox1;
            lblRespuesta.Parent = pictureBox2;
            pbCorazon.Parent = pictureBox2;
            lblAyuda.Parent = pictureBox2;
            btnSi.TabStop = false;
            btnNO.TabStop = false;
            panel2.Hide();
        }

        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - btnNO.Width);
            int y = r.Next(0, this.Height - btnNO.Height);
            btnNO.Location = new Point(x, y);
        }

        private void btnNO_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (btnNO.Location == btnSi.Location || btnNO.Location == lblPregunta.Location)
            {
                MoverBoton();
            }
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void pbCorazon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
