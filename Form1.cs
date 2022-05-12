using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityDataModelDemo
{
    public partial class Form1 : Form
    {
        ApplicationEntities dbcontext = new ApplicationEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeTbl emp = new EmployeeTbl();
                emp.EmpName = txtEmpName.Text;
                emp.EmpDesignation = txtEmpDesi.Text;
                emp.EmpSalary = Convert.ToInt32(txtEmpSal.Text);
                dbcontext.EmployeeTbls.Add(emp);
                dbcontext.SaveChanges();
                MessageBox.Show("Done");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                EmployeeTbl emp = dbcontext.EmployeeTbls.Find(Convert.ToInt32(txtEmpId.Text));
                if (emp != null)
                {
                    emp.EmpName = txtEmpName.Text;
                    emp.EmpDesignation = txtEmpDesi.Text; 
                    emp.EmpSalary = Convert.ToInt32(txtEmpSal.Text);

                    dbcontext.SaveChanges();
                    MessageBox.Show("Updated");

                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeTbl emp = dbcontext.EmployeeTbls.Find(Convert.ToInt32(txtEmpId.Text));
                if (emp != null)
                {
                    txtEmpName.Text = emp.EmpName;
                    txtEmpDesi.Text = emp.EmpDesignation;
                    txtEmpSal.Text = emp.EmpSalary.ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeTbl emp = dbcontext.EmployeeTbls.Find(Convert.ToInt32(txtEmpId.Text));
                if (emp != null)
                {
                    dbcontext.EmployeeTbls.Remove(emp);
                    dbcontext.SaveChanges();
                    MessageBox.Show("deleted");
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowRecord_Click(object sender, EventArgs e)
        {
            dgvEmp.DataSource = dbcontext.EmployeeTbls.ToList();
           
        }
    }
}
