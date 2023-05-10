namespace КурсоваРабота
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.add_employee = new System.Windows.Forms.Button();
            this.hiring_date = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profession = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.names = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.department);
            this.groupBox1.Controls.Add(this.add_employee);
            this.groupBox1.Controls.Add(this.hiring_date);
            this.groupBox1.Controls.Add(this.salary);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.profession);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.names);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 285);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добави работник";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "IT",
            "Maintanance",
            "More IT"});
            this.department.Location = new System.Drawing.Point(121, 101);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(149, 21);
            this.department.TabIndex = 13;
            // 
            // add_employee
            // 
            this.add_employee.Location = new System.Drawing.Point(274, 201);
            this.add_employee.Name = "add_employee";
            this.add_employee.Size = new System.Drawing.Size(70, 54);
            this.add_employee.TabIndex = 12;
            this.add_employee.Text = "Добави";
            this.add_employee.UseVisualStyleBackColor = true;
            this.add_employee.Click += new System.EventHandler(this.add_employee_Click_1);
            // 
            // hiring_date
            // 
            this.hiring_date.Location = new System.Drawing.Point(121, 153);
            this.hiring_date.Name = "hiring_date";
            this.hiring_date.Size = new System.Drawing.Size(149, 20);
            this.hiring_date.TabIndex = 11;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(121, 127);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(149, 20);
            this.salary.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Дата на постъпване";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Заплата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Отдел";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Професия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ЕГН";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Три имена";
            // 
            // profession
            // 
            this.profession.Location = new System.Drawing.Point(121, 75);
            this.profession.Name = "profession";
            this.profession.Size = new System.Drawing.Size(149, 20);
            this.profession.TabIndex = 2;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(121, 49);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(99, 20);
            this.id.TabIndex = 1;
            // 
            // names
            // 
            this.names.Location = new System.Drawing.Point(121, 23);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(224, 20);
            this.names.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 309);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Button add_employee;
        private System.Windows.Forms.TextBox hiring_date;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox profession;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox names;
    }
}