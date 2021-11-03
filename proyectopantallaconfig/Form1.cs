using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech;
using System.Speech.Recognition;
using System.Media;
namespace proyectopantallaconfig
{
    public partial class Form1 : Form
    {
        public static int VolSS;
        public Form1()
        {
            InitializeComponent();
        }

        private void trckBrVolumen_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trckBrVolumen, trckBrVolumen.Value.ToString());
            VolSS = trckBrVolumen.Value;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
        }

        private void trackbrbrillo_Scroll(object sender, EventArgs e)
        {

        }
    }
}
