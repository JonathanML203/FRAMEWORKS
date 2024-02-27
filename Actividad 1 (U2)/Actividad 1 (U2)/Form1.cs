using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_1__U2_
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            double Num = Convert.ToDouble(metroTextBox1.Text);
            if (Par(Num))
            {
                metroLabel3.Text = "Es Par";
            }
            else
            {
                metroLabel3.Text = "Es Impar";
            }
        }

        static bool Par(double Nume)
        {
            return Nume % 2 == 0;
        }
    }
}
