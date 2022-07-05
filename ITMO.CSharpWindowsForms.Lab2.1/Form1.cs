using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSharpWindowsForms.Lab2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались, что Вы так думаете!");
        }

        private void buttonNo_MouseMove(object sender, MouseEventArgs e)
        {
            buttonNo.Top -= e.Y;
            buttonNo.Left += e.X;
            if (buttonNo.Top < -10 || buttonNo.Top > 100)
                buttonNo.Top = 60;
            if (buttonNo.Left < -80 || buttonNo.Left > 250)
                buttonNo.Left = 120;
        }
    }
}
