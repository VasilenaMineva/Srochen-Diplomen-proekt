using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavedenie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void buttonBezAlk_Click(object sender, EventArgs e)
        {
            groupBoxBezalcoholno.Show();
            groupBoxAlcohol.Hide();
            groupBoxSalati.Hide();
            groupBoxOsnovno.Hide();
        }

        private void buttonAlcohol_Click(object sender, EventArgs e)
        {
            groupBoxBezalcoholno.Hide();
            groupBoxAlcohol.Show();
            groupBoxSalati.Hide();
            groupBoxOsnovno.Hide();
        }

        private void buttonSalads_Click(object sender, EventArgs e)
        {
            groupBoxBezalcoholno.Hide();
            groupBoxAlcohol.Hide();
            groupBoxSalati.Show();
            groupBoxOsnovno.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            groupBoxBezalcoholno.Hide();
            groupBoxAlcohol.Hide();
            groupBoxSalati.Hide();
            groupBoxOsnovno.Show();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBoxBezalcoholno.Hide();
            groupBoxAlcohol.Hide();
            groupBoxSalati.Hide();
            groupBoxOsnovno.Hide();
        }

        
    }
}
