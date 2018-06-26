using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Тест
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вихід
            Close();
        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();//виклик нової форми
            newForm.Show();
        }

        private void результатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int bal; bal = 0;
            // 1-е запитання
            if (checkBox1.Checked == true &&  checkBox2.Checked == true && checkBox3.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)

                bal++;
            //2-е запитання
            if (textBox1.Text == "Main")
                bal++;
         // 3-е запитання
            if (radioButton2.Checked == true)
                bal++;
            //4- е запитання
            if (radioButton7.Checked == true)
                bal++;
            // 5-е запитання
            if (checkBox5.Checked == true && checkBox8.Checked == true)
                bal++;
            // 6-е запитання
            if (radioButton9.Checked == true)
                bal++;
            //7-е запитання
            if (radioButton15.Checked == true)
                bal++;
            // 8-е запитання
            if (checkBox11.Checked == true && checkBox13.Checked == true && checkBox14.Checked == true && checkBox16.Checked == true)

                bal++;
            //9-е запитання
            if (comboBox1.SelectedIndex == 0)
                bal++;
            //10-е запитання
            if (radioButton19.Checked == true)
                bal++;
            MessageBox.Show("Ваш результат: "+bal);
        }

       
    }
}
