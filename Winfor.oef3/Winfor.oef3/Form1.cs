using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winfor.oef3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<string> mijnLijst = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            mijnLijst.Add("Koen");
            mijnLijst.Add("ssssst");
            mijnLijst.Add("soep");
            mijnLijst.Add("snoepen");

            foreach (var item in mijnLijst)
            {
                lbMijnListBox.Items.Add(item);
            }

           
        }


        private void btnMijnButton_Click(object sender, EventArgs e)
        {
            lbMijnListBox.Items.Clear();

            foreach (var item in mijnLijst)
            {
                if (item.ToLower().Contains(tbMijnTextBox.Text.ToLower()))
                {
                    lbMijnListBox.Items.Add(item);
                }

            }
            
        }

       
    }
}
