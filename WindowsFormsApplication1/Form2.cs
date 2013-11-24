using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2(string std, string op2, string op3, string op4)
        {
            InitializeComponent();
            label2.Text = std;
            label3.Text = op2;
            label4.Text = op3;
            label5.Text = op4;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
