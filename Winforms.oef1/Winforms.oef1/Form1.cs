using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.oef1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void tbTekstBox(object sender, EventArgs e)
        {
            List<string> mijnLijst = new List<string>();
            foreach (var item in mijnLijst)
            {
                tbTestBox.mijnLijst.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbTekstBox.Items.Addt(tbTekstBox.Text);
        }
    }
}
