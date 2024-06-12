using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sozdanie2form
{
    public partial class Form2 : Form
    {
        public bool isclick = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isclick = true;
        }

        public string T_R_A_V()
        {
            if (isclick)
            {
                return "Penisist";
            }
            return "";
        }
    }
}
