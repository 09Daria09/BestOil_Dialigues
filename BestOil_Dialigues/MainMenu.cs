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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BestOil_Dialigues
{
    public partial class MainMenu : Form
    {
        Mini_cafe mini_Cafe;
        OilStation oilStation;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mini_Cafe = new Mini_cafe();
            mini_Cafe.ParentForm = this;

            DialogResult rez = mini_Cafe.ShowDialog();
            if (rez == DialogResult.OK)
            {
                double num1, num2, result;

                num1 = double.TryParse(label1.Text, out num1) ? num1 : 0;
                num2 = double.TryParse(mini_Cafe.label8.Text, out num2) ? num2 : 0;

                result = num1 + num2;
                label1.Text = result.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oilStation = new OilStation();
            oilStation.ParentForm = this;

            DialogResult rez = oilStation.ShowDialog();
            if (rez == DialogResult.OK)
            {
                double num1, num2, result;

                num1 = double.TryParse(label1.Text, out num1) ? num1 : 0;
                num2 = double.TryParse(oilStation.label1.Text, out num2) ? num2 : 0;

                result = num1 + num2;
                label1.Text = result.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string expectedPassword = "admin";
            string password = Microsoft.VisualBasic.Interaction.InputBox("Введите пароль:", "Пароль", "", -1, -1);
            if (password != expectedPassword)
            {
                MessageBox.Show("Пароль неверный!");
                return;
            }

            mini_Cafe = new Mini_cafe();
            oilStation = new OilStation();
            oilStation.ParentForm = this;
            mini_Cafe.ParentForm = this;

            oilStation.Show();
            mini_Cafe.Show();

            string selectedValue = null;
            oilStation.textBox1.ReadOnly = false;
            if (oilStation.comboBox1.SelectedItem != null)
            {
                selectedValue = oilStation.comboBox1.SelectedItem.ToString();
            }
            if (selectedValue == oilStation.a76)
            {
                oilStation.a76 = oilStation.textBox1.Text;
            }
            else if (selectedValue == oilStation.a80)
            {
                oilStation.a80 = oilStation.textBox1.Text;
            }
            else if (selectedValue == oilStation.a92)
            {
                oilStation.a92 = oilStation.textBox1.Text;
            }
            else if (selectedValue == oilStation.a95)
            {
                oilStation.a95 = oilStation.textBox1.Text;
            }
            else if (selectedValue == oilStation.a98)
            {
                oilStation.a98 = oilStation.textBox1.Text;
            }
            else
            {
                oilStation.textBox1.Text = null;
            }

            mini_Cafe.textBox4.ReadOnly = false;
            mini_Cafe.textBox5.ReadOnly = false;
            mini_Cafe.textBox6.ReadOnly = false;
            mini_Cafe.textBox7.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оплата прошла успешно :)", "Оплата", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
