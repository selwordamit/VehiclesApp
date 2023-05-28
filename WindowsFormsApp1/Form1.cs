using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FourWheelsButton_Click(object sender, EventArgs e)
        {
            FourWheelForm fourWheelForm = new FourWheelForm();
            fourWheelForm.Show();
            this.Hide();
        }

        private void TwoWheelsButton_Click(object sender, EventArgs e)
        {
            TwoWheelForm twoWheelForm = new TwoWheelForm(); 
            twoWheelForm.Show();
            this.Hide();
        }
    }
}
