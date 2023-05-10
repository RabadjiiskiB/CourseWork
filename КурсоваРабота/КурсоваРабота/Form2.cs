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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void add_employee_Click(object sender, EventArgs e)
        {
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void add_employee_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (names.Text == "" || id.Text == "" || profession.Text == "" || department.SelectedIndex == -1 || salary.Text == "" || hiring_date.Text == "")
                {
                    MessageBox.Show("Попълни всички полета");
                }
                else
                {
                    string[] data = names.Text.Split(' ');
                    int employeeId = int.Parse(id.Text);
                    string firstName = data[0];
                    string middleName = data[1];
                    string lastName = data[2];
                    string professionName = profession.Text;
                    string departmentName = department.Text;
                    decimal wage = decimal.Parse(salary.Text);
                    int hiringDate = int.Parse(hiring_date.Text);
                    
                    Employee employee = new Employee(employeeId, firstName, middleName, lastName, professionName, departmentName, wage, hiringDate);
                    form1.employees.Add(employee);
                    this.Close();
                    form1.listBox1.Items.Clear();

                    // Repopulate the listBox1 control with the updated employee list
                    foreach (var item in form1.employees)
                    {
                        form1.listBox1.Items.Add($"{item.id} - {item.fname} - {item.mname} {item.lname} - {item.wage}лв. - {item.proffesion} - {item.department} - {item.date_of_emoloyment}");
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
