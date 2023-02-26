using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder
{
    public partial class Mainform : Form
    {
        string reminderTime1;
        string reminderTime2;
        string reminderTime3;
        string reminderTime4;
        string reminderTime5;
        string CurrentTime;
        string reminderText1;
        string reminderText2;
        string reminderText3;
        string reminderText4;
        string reminderText5;

        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void realTimetimer_Tick(object sender, EventArgs e)
        {
            string CurrentTime = DateTime.Now.ToString("dd:MM:yyyy");
            realTimelabel.Text = CurrentTime;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string reminderTime1 = remindermaskedTextBox1.Text;
            string reminderText1 = remindertextBox1.Text;
            remindertimer1.Start();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reminderTime1 = remindermaskedTextBox1.Text;
            string reminderText1 = remindertextBox1.Text;
            remindertimer1.Start();
        }

        private void remindertimer1_Tick(object sender, EventArgs e)
        {
            if (CurrentTime == reminderTime1)
            {
                remindertimer1.Stop();
                MessageBox.Show(reminderText1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string reminderTime2 = remindermaskedTextBox2.Text;
            string reminderText2 = remindertextBox2.Text;
            remindertimer2.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string reminderTime3 = remindermaskedTextBox3.Text;
            string reminderText3 = remindertextBox3.Text;
            remindertimer3.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string reminderTime4 = remindermaskedTextBox4.Text;
            string reminderText4 = remindertextBox4.Text;
            remindertimer4.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string reminderTime5 = remindermaskedTextBox5.Text;
            string reminderText5 = remindertextBox5.Text;
            remindertimer5.Start();
        }

        private void remindertimer2_Tick(object sender, EventArgs e)
        {
            if (CurrentTime == reminderTime1)
            {
                remindertimer2.Stop();
                MessageBox.Show(reminderText2);
            }
        }

        private void remindertimer3_Tick(object sender, EventArgs e)
        {

            remindertimer3.Stop();
            MessageBox.Show(reminderText3);
        }

        private void remindertimer4_Tick(object sender, EventArgs e)
        {

            remindertimer4.Stop();
            MessageBox.Show(reminderText4);
        }

        private void remindertimer5_Tick(object sender, EventArgs e)
        {

            remindertimer5.Stop();
            MessageBox.Show(reminderText5);
        }
    }
    }
    
    

