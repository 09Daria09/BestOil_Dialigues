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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BestOil_Dialigues
{
    public partial class Mini_cafe : Form
    {
        private int price1 = 0;
        private int price2 = 0;
        private int price3 = 0;
        private int price4 = 0;
        public Form ParentForm { get; set; }
        public Mini_cafe()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox11.ReadOnly = false;
            }
            else
            {
                textBox11.Clear();
                textBox11.ReadOnly = true;

            }
            if (checkBox2.Checked)
            {
                textBox10.ReadOnly = false;
            }
            else
            {
                textBox10.Clear();
                textBox10.ReadOnly = true;
            }
            if (checkBox3.Checked)
            {
                textBox8.ReadOnly = false;
            }
            else
            {
                textBox8.Clear();
                textBox8.ReadOnly = true;
            }
            if (checkBox4.Checked)
            {
                textBox9.ReadOnly = false;
            }
            else
            {
                textBox9.Clear();
                textBox9.ReadOnly = true;
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int priceProduct = 0;

            int.TryParse(textBox11.Text, out count);
            int.TryParse(textBox4.Text, out priceProduct);

            int price = count * priceProduct;
            price1 = price;


            label8.Text = (price1 + price2 + price3 + price4).ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int priceProduct = 0;

            int.TryParse(textBox10.Text, out count);
            int.TryParse(textBox7.Text, out priceProduct);

            int price = count * priceProduct;
            price2 = price;

            label8.Text = (price1 + price2 + price3 + price4).ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int priceProduct = 0;

            int.TryParse(textBox9.Text, out count);
            int.TryParse(textBox6.Text, out priceProduct);

            int price = count * priceProduct;
            price3 = price;

            label8.Text = (price1 + price2 + price3 + price4).ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int priceProduct = 0;

            int.TryParse(textBox8.Text, out count);
            int.TryParse(textBox5.Text, out priceProduct);

            int price = count * priceProduct;
            price4 = price;

            label8.Text = (price1 + price2 + price3 + price4).ToString();
        }
    }
}
