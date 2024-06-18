namespace DemoWinform
{
    public partial class Form1 : Form
    {
        private NorthwindContext context;

        public void LoadData()
        {
            dgvEmployees.DataSource = (from c in context.Employees
                                       select new
                                       {
                                           c.EmployeeId,
                                           c.FirstName,
                                           c.LastName,
                                           c.Address,
                                           c.BirthDate
                                       }).ToList();
        }

        public Form1()
        {
            context = new NorthwindContext();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastname.Text,
                Address = tbAddress.Text,
                BirthDate = dtpBirthDate.Value
            };

            if (!string.IsNullOrEmpty(tbFirstName.Text) && !string.IsNullOrEmpty(tbLastname.Text))
            {
                context.Employees.Add(emp);
                context.SaveChanges();
                LoadData();
            }
            else
            {
                MessageBox.Show("First Name and Last Name cannot be empty");
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                tbEmpId.Text = dgvEmployees.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                tbFirstName.Text = dgvEmployees.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                tbLastname.Text = dgvEmployees.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                tbAddress.Text = dgvEmployees.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                dtpBirthDate.Value = DateTime.Parse(dgvEmployees.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            }
        }
        private Employee GetEmployeeFromUI()
        {
            Employee emp = new Employee();
            emp.FirstName = tbFirstName.Text;
                emp.LastName = tbLastname.Text;
                emp.Address = tbAddress.Text;
            emp.BirthDate = dtpBirthDate.Value;
            return emp;
            
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbFirstName.Text) == false && string.IsNullOrEmpty(tbLastname.Text) == false)
                {
                    Employee newEmp = GetEmployeeFromUI();
                    newEmp.EmployeeId = int.Parse(tbEmpId.Text);
                    Employee oldEmployee = context.Employees.FirstOrDefault(x => x.EmployeeId == newEmp.EmployeeId);
                    // Update the existing employee's details
                    oldEmployee.FirstName = tbFirstName.Text;
                    oldEmployee.LastName = tbLastname.Text;
                    oldEmployee.Address = tbAddress.Text;
                    oldEmployee.BirthDate = dtpBirthDate.Value;

                    context.SaveChanges();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("First Name and Last Name cannot be empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

           
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbEmpId.Text) == false)
                {
                    Employee emp = context.Employees.FirstOrDefault(x => x.EmployeeId == int.Parse(tbEmpId.Text));
                    context.Employees.Remove(emp);
                    context.SaveChanges();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Please select a row to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btRefresh_Click(object sender, EventArgs e)
        {
            tbAddress.Text = string.Empty;
            tbEmpId.Text = string.Empty;
            tbFirstName.Text = string.Empty;
            tbLastname.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Now;
        }
    }
}
