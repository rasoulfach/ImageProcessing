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
    public partial class showfrm : Form
    {
        int[] x = new int[256];
        string colorsh;
        public showfrm(int[] input , string colorshoon)
        {
            InitializeComponent();
            x = input;
            colorsh = colorshoon;
        }

        private void showfrm_Load(object sender, EventArgs e)
        {
            for(int i =0; i<256; i++)
            {
                chart1.Series["Bits"].Points.AddXY("", x[i]);
                if(colorsh=="red") chart1.Series["Bits"].Color = Color.Red;
                else if (colorsh=="green") chart1.Series["Bits"].Color = Color.Green;
                else if (colorsh=="Blue") chart1.Series["Bits"].Color = Color.Blue;
            }
        }

        private void showfrm_Load()
        {
            
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
