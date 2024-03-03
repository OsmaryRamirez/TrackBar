using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trackbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBvolumen_Scroll(object sender, EventArgs e)
        {
            int newSize = tBTamaño.Value;
            lbl_Tamaño.Font = new System.Drawing.Font(lbl_Tamaño.Font.FontFamily, Math.Max(1, newSize));
            lbl_Tamaño.Text = "Tamaño de fuente: " + newSize.ToString();
           
        }
    }
}
