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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLeerlingen.Items.Add("Martijn");
            cbLeerlingen.Items.Add("Benjamin");
            cbLeerlingen.Items.Add("Koen");
            cbLeerlingen.Items.Add("Antal");
            cbLeerlingen.Items.Add("Yannick");
            cbLeerlingen.Items.Add("Latha");

            foreach (var item in cbLeerlingen.Items)
            {
                lbLeerlingen.Items.Add(item);
            }
        }

        private void cbLeerlingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbLeerlingen.SelectedIndex.ToString());
            lbMijnLabel.Text = cbLeerlingen.SelectedItem.ToString();
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            lbLeerlingen.Items.Add(txtMijnTextBox.Text);
        }

        private void txtMijnTextBox_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(" nu kan je niets toevoegen");
        }
    }
}
