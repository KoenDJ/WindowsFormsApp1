using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winfor.oef2
{
    public partial class Form1 : Form
    {

        // oefening 2. forms
        public Form1()
        {
            InitializeComponent();
        }

        private void cbMijnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }            

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMijnComboBox.Items.Add("koen");
            cbMijnComboBox.Items.Add("Ann");
            cbMijnComboBox.Items.Add("Miek");
            cbMijnComboBox.Items.Add("Stijn");
            cbMijnComboBox.Items.Add("Piet");

        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            cbMijnComboBox.Items.RemoveAt(cbMijnComboBox.SelectedIndex);
        }

        
    }
}
