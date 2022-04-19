using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class bitfrm : Form
    {
        string name;
        Bitmap check;
        public bitfrm(string namesh, Bitmap bitmap)
        {
            InitializeComponent();
            name = namesh;
            check = bitmap;
        }

        private void bitfrm_Load(object sender, EventArgs e)
        {
            label1.Text = name;
            pictureBox1.Image = check;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
