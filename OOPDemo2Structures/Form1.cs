using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Aline Vetrov
 * Date: 01/13/2020
 * Desc: OOP Demo Structures
 * Notes: Structures are UDT and are value type
 */

namespace OOPDemo2Structures
{
    /*
     * Employee Structure creation
     */

    /// <summary>
    /// Structure of an Employee
    /// </summary>
    public struct Employee //pascal case for structure names
    {
        public string FirstName; //pascal case for mamber names
        public string LastName;
        public long Extension;
        public decimal Salary;
    }

    public partial class Form1 : Form
    {
        private Employee employee;
        private ArrayList allEmployees = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                employee.FirstName = txtFirstName.Text.Trim();
                employee.LastName = txtLastName.Text.Trim();
                employee.Extension = long.Parse(txtExt.Text);
                employee.Salary = decimal.Parse(txtSalary.Text);

                allEmployees.Add(employee);

                MessageBox.Show("Employee added to arraylist");

                foreach(Control ctr in this.Controls)
                {
                    if (ctr is TextBox)
                    {
                        ctr.ResetText();
                    }
                }

                txtFirstName.Focus();

                if (allEmployees.Count % 5 == 0)
                {
                    printAllEmployees();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            printAllEmployees();
        }

        private void printAllEmployees()
        {
            string mssg = "";

            foreach (Employee emp in allEmployees)
            {
                mssg += $"{emp.FirstName} {emp.LastName} {emp.Extension} {emp.Salary.ToString("c")} {Environment.NewLine}";
            }

            MessageBox.Show(mssg);
        }
    }
}
