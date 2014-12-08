using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mwImports
{
    public partial class Form1 : Form
    {
        private Malcode_Grab malcodeGrab;
        public Form1()
        {
            InitializeComponent();
            // Each grab needs to be passed a copy of the form that calls them.
            malcodeGrab = new Malcode_Grab(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btGetData_Click(object sender, EventArgs e)
        {
            string pageData = malcodeGrab.getPage("http://google.com");
        }
    }
}
