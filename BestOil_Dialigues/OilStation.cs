using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil_Dialigues
{
    public partial class OilStation : Form
    {
        public string a76;
        public string a80;
        public string a92;
        public string a95;
        public string a98;
        public Form ParentForm { get; set; }
        public OilStation()
        {
            InitializeComponent();
            a76 = "А-76";
            a80 = "А-80";
            a92 = "А-92";
            a95 = "А-95";
            a98 = "А-98";


            string[] items = { a76, a80, a92, a95, a98 };
            comboBox1.Items.AddRange(items);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = null;
            if (comboBox1.SelectedItem != null)
            {
                selectedValue = comboBox1.SelectedItem.ToString();
            }
            if (selectedValue == a76)
            {
                textBox1.Text = "33,23";
            }
            else if (selectedValue == a80)
            {
                textBox1.Text = "35,55";
            }
            else if (selectedValue == a92)
            {
                textBox1.Text = "46,12";
            }
            else if (selectedValue == a95)
            {
                textBox1.Text = "46,96";
            }
            else if (selectedValue == a98)
            {
                textBox1.Text = "49,60";
            }
            else
            {
                textBox1.Text = null;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = true;
            }
            else if (radioButton2.Checked)
            {
                textBox3.ReadOnly = false;
                textBox2.ReadOnly = true;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double priceOil;
            double countOil;
            bool isPriceValid = double.TryParse(textBox1.Text, out priceOil);
            bool isCountValid = double.TryParse(textBox2.Text, out countOil);

            if (isPriceValid && isCountValid)
            {
                double price = priceOil * countOil;
                label1.Text = price.ToString();
                textBox3.Text = price.ToString();
            }
            else
            {
                label1.Text = "Ошибка";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double priceOil;
            double countOil;
            bool isPriceValid = double.TryParse(textBox3.Text, out priceOil);
            bool isCountValid = double.TryParse(textBox1.Text, out countOil);
            label1.Text = priceOil.ToString();

            if (isPriceValid && isCountValid)
            {
                double price = priceOil / countOil;
                textBox2.Text = price.ToString();
            }
            else
            {
                label1.Text = "Ошибка";
            }
        }
    }
}
