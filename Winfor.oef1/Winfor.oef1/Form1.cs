using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winfor.oef1
{
    public partial class Form1 : Form
    {

        // Hoe nu deze oefening beginnen.
        // 1. aanmaken van een lijstbox.  noemen we lbMijnList
        // 2. aanmaken van een tektbox.  noemen we txtMijnText
        // 3. aanmaken van een button.   noemen we btnMijnButton
        // 4. dubbel klink op de button
        // nu zijn we in de form1.cs
        // her vullen we lbMijnList.Items.Add(txtMijnText.Text);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMijnButton_Click(object sender, EventArgs e)
        {
            lbMijnList.Items.Add(txtMijnText.Text);
            txtMijnText.Text = "";
        }
    }
}
