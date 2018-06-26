using System;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          // ПЕРВІРКА ТЕСТІВ
            int k = 0; label4.Visible = true; label4.Text = "Всього балів:"+Convert.ToString(k);

            //Панель 1

            if (radioButton2.Checked == true)
            {
                panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
                groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
                radioButton2.BackColor = System.Drawing.Color.DarkSeaGreen;
                k = k + 1;
                label4.Text = "Всього балів:" + Convert.ToString(k);
            }

            else
            {
                panel1.BackColor = System.Drawing.Color.Red;
                groupBox1.BackColor = System.Drawing.Color.Red;
                radioButton2.BackColor = System.Drawing.Color.Red;
        }

            // панель2
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == true)
            {
                panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
                k = k + 1;
                label4.Text = "Всього балів:" + Convert.ToString(k);

            }
            else
            {
                panel2.BackColor = System.Drawing.Color.Red;
            }
            // панель 6

            if (textBox2.Text == "12")
            {
                panel6.BackColor = System.Drawing.Color.DarkSeaGreen;
                k = k + 1;
                label4.Text = "Всього балів:" + Convert.ToString(k);
            }
            else
            {
                panel6.BackColor = System.Drawing.Color.Red;
            }

            //панель8
            if (checkBox5.Checked == false && checkBox6.Checked ==false && checkBox7.Checked == true && checkBox8.Checked == true)
            {
                panel8.BackColor = System.Drawing.Color.DarkSeaGreen;
                k = k + 1;
                label4.Text = "Всього балів:" + Convert.ToString(k);

            }
            else
            {
                panel8.BackColor = System.Drawing.Color.Red;
            }
            //панель3
            if (textBox1.Text == "50")
            {
                panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
                k = k + 1;
                label4.Text = "Всього балів:" + Convert.ToString(k);
            }
            else
            {
                panel3.BackColor = System.Drawing.Color.Red;
            }
            // панель 4
            if (radioButton7.Checked == true)
            {
                panel4.BackColor = System.Drawing.Color.DarkSeaGreen;
                groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
              //  radioButton2.BackColor = System.Drawing.Color.DarkSeaGreen;
                k = k + 1;
                label4.Text = "Всього балів:" + Convert.ToString(k);
            }

            else
            {
                panel4.BackColor = System.Drawing.Color.Red;
                groupBox2.BackColor = System.Drawing.Color.Red;
              //  radioButton2.BackColor = System.Drawing.Color.Red;
            }

            // панель 7
            if (radioButton11.Checked == true)
            {
                panel7.BackColor = System.Drawing.Color.DarkSeaGreen;
                groupBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
                //  radioButton2.BackColor = System.Drawing.Color.DarkSeaGreen;
                k = k + 1;
                label4.Text = "Всього балів:" + Convert.ToString(k);
            }

            else
            {
                panel7.BackColor = System.Drawing.Color.Red;
                groupBox3.BackColor = System.Drawing.Color.Red;
                //  radioButton2.BackColor = System.Drawing.Color.Red;
            }
            // панель 6

            if (textBox4.Text == "15,8")
            {
                panel9.BackColor = System.Drawing.Color.DarkSeaGreen;
                k = k + 1;
                label4.Text = "Всього балів:" + Convert.ToString(k);
            }
            else
            {
                panel9.BackColor = System.Drawing.Color.Red;
            }

            // панель 10

            if (textBox3.Text == "25")
            {
                panel10.BackColor = System.Drawing.Color.DarkSeaGreen;
                k = k + 1;
                label4.Text = "Всього балів:" + Convert.ToString(k);
            }
            else
            {
                panel10.BackColor = System.Drawing.Color.Red;
            }

            // панель 11

            if (textBox5.Text == "3" && textBox6.Text=="1")
            {
                panel11.BackColor = System.Drawing.Color.DarkSeaGreen;
                k = k + 1;
                label4.Text = "Всього балів:" + Convert.ToString(k);
            }
            else
            {
                panel11.BackColor = System.Drawing.Color.Red;
            }
            //панель 12
            
            if (checkBox9.Checked == false && checkBox10.Checked == true && checkBox11.Checked == true && checkBox12.Checked == false)
            {
                panel12.BackColor = System.Drawing.Color.DarkSeaGreen;
                k = k + 1;
                label4.Text = "Всього балів:" + Convert.ToString(k);

            }
            else
            {
                panel12.BackColor = System.Drawing.Color.Red;
            }
            panel1.Enabled = false; panel2.Enabled = false; panel6.Enabled = false; panel8.Enabled = false;
            panel3.Enabled = false; panel4.Enabled = false; panel7.Enabled = false; panel9.Enabled = false;
            panel10.Enabled = false; panel11.Enabled = false; panel12.Enabled = false;


        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

           
    }
    }
