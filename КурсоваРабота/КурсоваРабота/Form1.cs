using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсоваРабота
{
    public partial class Form1 : Form
    {
        internal List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool b = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                label1.Hide();
                b = false;
            }
            else
            {
                label1.Show();
                b = true;
            }
        }

        private void names_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void show_Click(object sender, EventArgs e)
        {
            foreach(var item in employees)
            listBox1.Items.Add($"{item.id} - {item.fname} - {item.mname} {item.lname} - {item.wage}лв. - {item.proffesion} - {item.department} - {item.date_of_emoloyment}");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                int x = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(x);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this); // Pass Form1 instance to Form2 constructor
            form2.Show();
        }
    }
}
